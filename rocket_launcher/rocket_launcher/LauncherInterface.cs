using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launcherInterface
{
    // Target
    public interface IMissileLauncher
    {
        /// <summary>
        /// Resets the missile launcher 
        /// </summary>
        void Reset();
        /// <summary>
        /// Moves the missile launcher by a relative amount.
        /// </summary>
        /// <param name="phi"></param>
        /// <param name="phi"></param>
        void MoveBy(double phi, double psi);
        /// <summary>
        /// Moves the missile launcher to an absolute position.
        /// </summary>
        /// <param name="phi"></param>
        /// <param name="psi"></param>
        void MoveTo(double phi, double psi);
        /// <summary>
        /// Fires a missile.
        /// </summary>
        void Fire();
        double Phi { get; set; }
        double Psi { get; set; }
    }
}
