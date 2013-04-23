using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using launcher;
using ASMLEngineSdk;

namespace adapter
{
    // Launcher Adapter
    public class LauncherAdapter : IMissileLauncher
    {
        Launcher adapter_launcher;
        // Variables to save current positions of the turret
        private double current_phi; 
        private double current_theta;

        public LauncherAdapter()
        {
            adapter_launcher = new Launcher();
        }
        // Moves the missile launcher by a relative amount
        public void MoveBy(double phi, double theta)
        {
            if (theta >= 0)
                adapter_launcher.command_Right(Convert.ToInt32(theta * 21));
            else
                adapter_launcher.command_Left(Convert.ToInt32(theta * -19));
            current_theta += theta;

            if (phi >= 0)
                adapter_launcher.command_Up(Convert.ToInt32(phi * 17));
            else
                adapter_launcher.command_Down(Convert.ToInt32(phi * -23));
            current_phi += phi;
        }
        // Moves the missile launcher to an absolute position.
        public void MoveTo(double phi, double theta)
        {
            if (theta > 0)
            {
                if (current_theta >= 0)
                {
                    if (theta > current_theta)
                        adapter_launcher.command_Right(Convert.ToInt32(theta - current_theta) * 21);
                    else
                        adapter_launcher.command_Left(Convert.ToInt32(current_theta - theta) * 19);                    
                }
                else
                    adapter_launcher.command_Right(Convert.ToInt32((theta - current_theta) * 21));
                current_theta = theta;
            }
            else
            {
                if (current_theta < 0)
                {
                    if (theta > current_theta)
                        adapter_launcher.command_Right(Convert.ToInt32(theta - current_theta) * -21);
                    else
                        adapter_launcher.command_Left(Convert.ToInt32(current_theta - theta) * -19);
                }
                else
                    adapter_launcher.command_Left(Convert.ToInt32((current_theta + theta) * 19));
                current_theta = theta;
            }

            if (phi > 0)
            {
                if (current_phi >= 0)
                {
                    if (phi > current_phi)
                        adapter_launcher.command_Up(Convert.ToInt32(phi - current_phi) * 17);
                    else
                        adapter_launcher.command_Down(Convert.ToInt32(current_phi - phi) * 23);
                }
                else
                    adapter_launcher.command_Up(Convert.ToInt32((phi - current_phi) * 17));
                current_phi = phi;
            }
            else
            {
                if (current_theta < 0)
                {
                    if (phi > current_phi)
                        adapter_launcher.command_Up(Convert.ToInt32(phi - current_phi) * -17);
                    else
                        adapter_launcher.command_Down(Convert.ToInt32(current_phi - phi) * -123);
                }
                else
                    adapter_launcher.command_Down(Convert.ToInt32((current_phi + phi) * 23));
                current_phi = phi;
            }         
        }
        // Fires a missile
        public void Fire()
        {
            adapter_launcher.command_Fire();
        }
        // Resets the missile launcher and the current positions to 0,0
        public void Reset()
        {
            adapter_launcher.command_Left(5500);
            adapter_launcher.command_Right(2900);
            adapter_launcher.command_Up(1500);
            adapter_launcher.command_Down(500);
            current_theta = 0;
            current_phi = 0;
        }

        public double Phi
        {
            get
            {return current_phi;}
            set
            {current_phi = value;}
        }

        public double Theta
        {
            get
            {return current_theta;}
            set
            {current_theta = value;}
        }
    }
}
