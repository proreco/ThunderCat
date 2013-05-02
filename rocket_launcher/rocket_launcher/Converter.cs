using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace converter
{
    class Converter
    {      
        // Converter class. Converts from x, y and z coordinates to theta and phi
        private double phi;
        private double theta;

        public Converter (double x, double y, double z)
        {
            if (x != 0 || y != 0)
                theta = Math.Round(Math.Atan(x / y) * 180 / Math.PI);
            else
                theta = 0;
            if (z != 0 || y != 0)
                phi = Math.Round(Math.Atan(z / y) * 180 / Math.PI);
            else
                phi = 0;
        }

        public double Phi
        {
            get { return phi; }
            set { phi = value; }
        }
        public double Theta
        {
            get { return theta; }
            set { theta = value; }
        }
    }
}


