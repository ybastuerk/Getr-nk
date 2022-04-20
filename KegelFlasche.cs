using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getränk
{
    internal class KegelFlasche : Flasche
    {
        public KegelFlasche(double durchmesser, double höhe) : base(höhe)
        {
            this.Durchmesser = durchmesser;
        }

        public override double Volumen 
        { 

            get
            { 
                return base.Volumen / 3; 
            } 
        }
    }
}
