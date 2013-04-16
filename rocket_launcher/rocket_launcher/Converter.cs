using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter
{
    class Converter
    {      
        private double phi;
        private double theta;

        public Converter (double x, double y, double z)
        {
            phi = Math.Round(Math.Atan(x / y) * 180 / Math.PI);
            theta = Math.Round(Math.Atan(z / y) * 180 / Math.PI);
        }

        public double Phi
        {
            get { return phi; }
            set { phi = value; }
        }
        public double Theta
        {
            get { return phi; }
            set { theta = value; }
        }
    }
}


