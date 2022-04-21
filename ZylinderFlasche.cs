using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getränk
{
    internal class ZylinderFlasche : Flasche
    {
        public double Durchmesser { get; set; }

        public override double Volumen
        {
            get { return Math.Pow(Durchmesser / 2, 2) * Math.PI * Höhe; }
        }

        public ZylinderFlasche(double durchmesser, double höhe) : base(höhe)
        {
            this.Durchmesser = durchmesser;
        }


        

    }
}
