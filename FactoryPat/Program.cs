using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for the phone they wish to create
            Console.WriteLine("How many wheels does your vechicle needs?");
            string userVechicle = Console.ReadLine();

            //Choose the correct type of phone to create through the factory method that implements the ICallable interface
            IVechicle vechicle = VechicleFactory.GetVechicle(userVechicle);
            vechicle.Drive();
            Console.ReadLine();



        }
    }
}
        
    
