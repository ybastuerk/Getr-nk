using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getränk
{
    internal class ZylinderFlasche : Flasche
    {
        public ZylinderFlasche(double durchmesser, double höhe) : base(höhe)
        {
            this.Durchmesser = durchmesser;
        }


        

    }
}
