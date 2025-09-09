using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225416_LyDuc_Example01_AbstractFactory
{
    class WoodFactory : AbstractFactory
    {
        public override Plastic CreateProductA()
        {
            return new PlasticTable();
        }
        public override Wood CreateProductB()
        {
            return new WoodTable();
        }
    }
}
