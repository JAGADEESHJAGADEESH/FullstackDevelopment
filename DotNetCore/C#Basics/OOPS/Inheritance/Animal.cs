using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.OOPS.Inheritance
{
    public interface IAnimal
    {
        public void Eat();
        public string MakeASound();
        internal void Sleep();
        public void Walk()
        {
            Console.WriteLine("Animal is walking");
        }
    }
    public class Animal
    {
    }
}
