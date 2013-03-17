using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using launcher;

namespace adapter
{
    // Target
    public interface ILauncher
    {
        void command_Stop();
        void command_Right(int degrees);
        void command_Left(int degrees);
        void command_Up(int degrees);
        void command_Down(int degrees);
        void command_Fire();
        void command_switchLED(Boolean turnOn);
        void command_reset();
    }
    // Adapter itself
    public class LauncherAdapter : ILauncher
    {
        Launcher adapter_launcher;

        public LauncherAdapter()
        {
            adapter_launcher = new Launcher();
        }

        public void command_Stop()
        {
            adapter_launcher.command_Stop();
        }

        public void command_Right(int degrees)
        {
            adapter_launcher.command_Right(degrees * 27);
        }


        public void command_Left(int degrees)
        {
            adapter_launcher.command_Left(degrees * 25);
        }

        public void command_Up(int degrees)
        {
            adapter_launcher.command_Up(degrees * 30);
        }

        public void command_Down(int degrees)
        {
            adapter_launcher.command_Down(degrees * 30);
        }

        public void command_Fire()
        {
            adapter_launcher.command_Fire();
        }

        public void command_switchLED(Boolean turnOn)
        {
            adapter_launcher.command_switchLED(turnOn);
        }

        public void command_reset()
        {
            adapter_launcher.command_reset();
        }
    }
}
