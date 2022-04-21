using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getränk
{
    internal abstract class Flasche
    {
       

        public double Höhe { get; set; }

        public abstract double Volumen { get; }
            

        public Flasche( double höhe)
        {
           

            this.Höhe = höhe;


 }       }
}
