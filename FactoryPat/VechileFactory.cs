using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// Creates different types of phone objects
    /// </summary>
    static class VechicleFactory
    {
        /// <summary>
        /// Takes the users input and returns a phone type that conforms to the ICallable interface
        /// </summary>
        /// <param ></param>
        /// <returns>
        /// ICallable
        /// </returns>
        public static IVechicle GetVechicle(string wheelType)
        {
            switch (wheelType.ToLower())
            {
                case "four":
                    return new Car();                    
                case "two":                    
                return new Motorcycle();
                default:
                    return new Car();                    
            }
        }
    }
}