using DPM225416_LyDuc_Example01_AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225416_LyDuc_Patern01_AbstractFactory
{
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            // Abstract factory #1
            AbstractFactory factory1 = new PlasticFactory();
            Client client1 = new Client(factory1);
            client1.Run();
            // Abstract factory #2
            AbstractFactory factory2 = new WoodFactory();
            Client client2 = new Client(factory2);
            client2.Run();
            // Wait for user input
            Console.ReadKey();
        }
    }
}
