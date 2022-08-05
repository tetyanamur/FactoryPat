using System;
using System.Collections.Generic;
using System.Text;



namespace FactoryPattern
{
    class Car : IVechicle
    {
        public void Drive()
        {
            ConsoleLogging.NumberofWheel();
            Console.WriteLine("Building a car!");
        }
    }
}