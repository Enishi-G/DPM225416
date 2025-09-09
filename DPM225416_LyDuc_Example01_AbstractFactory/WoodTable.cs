using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225416_LyDuc_Example01_AbstractFactory
{
    class WoodTable : Wood
    {
        public override void Interact(Plastic a)
        {
            Console.WriteLine(this.GetType().Name +
              " looks prettier than " + a.GetType().Name);
        }
    }
}
