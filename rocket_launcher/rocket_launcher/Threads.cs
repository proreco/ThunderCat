using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ASMLEngineSdk;
using adapter;
using targetManager;
using Emgu.CV;
using Emgu.CV.Structure;

namespace threads
{
    class Threads
    {
        #region Members
        /// <summary>
        /// Object for synchronizing
        /// </summary>
        private object m_lockObject;
        /// <summary>
        /// The last data acquired from the camera.
        /// </summary>
        private Image<Bgr, byte> m_lastData;

        private Capture m_camera;
        /// <summary>
        /// Processing thread.
        /// </summary>
        private Thread m_thread;
        /// <summary>
        /// Flag indicating whether the thread is running.
        /// </summary>
        private bool m_isProcessing;
        /// <summary>
        /// Flag indicating whether the processing should capture data.
        /// </summary>
        private bool m_isRunning;
        /// <summary>
        /// Helps synchronize threads thread event.
        /// </summary>
        private ManualResetEvent m_waitEvent;
        #endregion

        #region Events
        /// <summary>
        /// Fired when data is ready.        
        /// </summary>
        public event EventHandler<CameraEventArgs> DataCaptured;
        /// <summary>
        /// Fired when the processing is started.
        /// </summary>
        public event EventHandler ThreadStarted;
        /// <summary>
        /// Fired when the processing is stopped.
        /// </summary>
        public event EventHandler ThreadStopped;
        #endregion

        public Threads()
        {
            Name = "Example threaded class";
            m_lastData = null;

            /// 
            /// This is a manual reset event, its a way to synchronize between threads
            /// You could also look into just using BackgroundWorkerThreads, but I do it the old fashion way...
            /// 
            m_waitEvent = new ManualResetEvent(false);

            m_isProcessing = true;
            m_isRunning = false;

            // This is used to prevent deadlocks, thread safe way like a mutex.
            m_lockObject = new object();

            m_camera = new Capture();

            // All initialization code goes here...
            SetupThread();
        }

        #region Threading
        /// <summary>
        /// Sets up and starts the processing thread.
        /// </summary>
        /// 
        private void SetupThread()
        {

            ThreadStart start1 = new ThreadStart(ImagingThread);
            m_thread = new Thread(start1);
            m_thread.IsBackground = true;
            m_thread.Start();
        }
        /// <summary>
        /// Imaging thread.
        /// </summary>
        private void ImagingThread()
        {
            WaitHandle[] events = new WaitHandle[] { m_waitEvent };

            // Wait until someone tells us not to process - this is the main loop
            while (m_isProcessing)
            {
                int eventHandle = WaitHandle.WaitAny(events);
                if (eventHandle == 0)
                {
                    m_waitEvent.Reset();

                    int runEvent = 0;
                    // otherwise we wait for a start and stop.
                    while (m_isRunning)
                    {

                        
                        // We tell it to wait for a few milliseconds for an event.
                        // In this case the events is just a trigger to collect data or abort.
                        runEvent = WaitHandle.WaitAny(events, 50);
                        if (runEvent == 0)
                        {
                            m_waitEvent.Reset();
                        }
                        else if (runEvent == 258)
                        {
                            // Wait around the data, so that when we write 
                            // we know nothing else can touch it.
                            
                                m_lastData = m_camera.QueryFrame();
                            
                            if (this.DataCaptured != null && m_lastData != null)
                            {
                                this.DataCaptured(this, new CameraEventArgs(m_lastData));
                            }
                        }
                    }
                }
            }  
        }

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the name of the device.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Starts the thread processing.
        /// </summary>

        public void Start()
        {
            m_isRunning = true;
            m_waitEvent.Set();

            if (ThreadStarted != null)
            {
                ThreadStarted(this, null);
            }
        }
        public void Stop()
        {
            m_isRunning = false;
            m_waitEvent.Set();

            if (ThreadStopped != null)
            {
                ThreadStopped(this, null);
            }
        }
        #endregion   
    }
        public class CameraEventArgs : EventArgs
        {

            /// <summary>
            /// Constructor.
            /// </summary>
            /// <param name="data">Data to share with rest of the application.</param>
            public CameraEventArgs(Image<Bgr, byte> data)
            {
                LastData = data;
            }

            /// <summary>
            /// Gets the last data .
            /// </summary>
            public Image<Bgr, byte> LastData
            {
                get;
                // we use a private set, so that no one can mess with the 
                // data later
                private set;
            }
        }
}