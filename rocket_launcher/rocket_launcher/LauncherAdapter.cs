using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using launcher;
using launcher_interface;

namespace adapter
{
    // Adapter
    public class LauncherAdapter : IMissileLauncher
    {
        Launcher adapter_launcher;
        private double current_phi;
        private double current_psi;

        public LauncherAdapter()
        {
            adapter_launcher = new Launcher();
        }

        public void MoveBy(double phi, double psi)
        {
            if (psi > 0)
                adapter_launcher.command_Right(Convert.ToInt32(psi));
            else
                adapter_launcher.command_Left(Convert.ToInt32(psi * -1));
            current_psi += psi;

            if (phi > 0)
                adapter_launcher.command_Up(Convert.ToInt32(phi));
            else
                adapter_launcher.command_Down(Convert.ToInt32(phi * -1));
            current_phi += phi;
        }

        public void MoveTo(double phi, double psi)
        {
            // in process           
        }

        public void Fire()
        {
            adapter_launcher.command_Fire();
        }

        public void Reset()
        {           
            adapter_launcher.command_reset();
            current_psi = 0;
            current_phi = 0;
        }

        public double Phi
        {
            get
            {
                return current_phi;
            }
            set
            {
                current_phi = value;
            }
        }

        public double Psi
        {
            get
            {
                return current_psi;
            }
            set
            {
                current_psi = value;
            }
        }
    }
}
