using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using threads;
using adapter;
using converter;
using targetManager;
using ASMLEngineSdk;
using modeType;
using System.Windows.Forms;

namespace controller
{
    class Controller
    {

        internal void destroy(TargetManager target, IMissileLauncher control, ModeType Mode)
        {
            int target_number;
            target_number = target.TargetList.Count / 7;

            while (target_number > 0 && !_shouldStop)
            {
                target.SetTarget(target_number);
                Converter coordinates = new Converter(target.X, target.Y, target.Z);
                switch (Mode)
                {
                    case ModeType.fireAll:
                        if (!_shouldStop)
                            control.MoveBy(coordinates.Phi, coordinates.Theta);
                        if (!_shouldStop)
                            control.Fire();

                        break;
                    case ModeType.fireFoes:

                        break;
                    case ModeType.fireFriends:
                        break;
                }
                target_number--;
            }
            
        }

        public void Start()
        {
            _shouldStop = false;
        }

        public void Stop()
        {
            _shouldStop = true;
        }

        private volatile bool _shouldStop;

    }
}
