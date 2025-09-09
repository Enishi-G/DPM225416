using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225416_LyDuc_Example01_AbstractFactory
{
    class PlasticFactory : AbstractFactory
    {
        public override Plastic CreateProductA()
        {
            return new PlasticChair();
        }
        public override Wood CreateProductB()
        {
            return new WoodChair();
        }
    }
}
