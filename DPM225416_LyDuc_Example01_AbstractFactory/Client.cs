using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225416_LyDuc_Example01_AbstractFactory
{
    class Client
    {
        private Plastic _PlasticFactory;
        private Wood _WoodFactory;
        // Constructor
        public Client(AbstractFactory factory)
        {
            _PlasticFactory = factory.CreateProductA();
            _WoodFactory = factory.CreateProductB();
        }
        public void Run()
        {
            _WoodFactory.Interact(_PlasticFactory);
        }
    }
}
