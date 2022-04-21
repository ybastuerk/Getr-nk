using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getränk
{
    internal class KegelFlasche : ZylinderFlasche
    {
        public KegelFlasche(double durchmesser, double höhe) : base(durchmesser,höhe)
        {
            
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
