using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getränk
{
    internal class QuaderFlasche : Flasche
    {
        public QuaderFlasche(double höhe, double länge, double breite) : base(höhe)
        {
        }
        public double Länge { get; set; }
        public double Breite { get; set; }

        public override double Volumen
        {
            get { return this.Länge = this.Breite = this.Höhe; }
        }
    }
}
