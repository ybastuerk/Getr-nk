using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getränk
{
    internal class Flasche
    {
        public double Durchmesser { get; set; }

        public double Höhe { get; set; }

        public double Volumen {
            get
            {
              return  Math.Pow(Durchmesser / 2, 2) * Math.PI * Höhe;
            }



}
            

        public Flasche(double durchmesser, double höhe)
        {
            this.Durchmesser = durchmesser;

            this.Höhe = höhe


 }       }
}
