using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.OOPS.Polymorphism
{
    public class OverrridingAndOverloading : Shape
    {
        public OverrridingAndOverloading()
        {
            
        }
        public void OverloadingMethod(int a)
        {
            Console.WriteLine("Overloading method with int parameter: " + a);
        }
        
        public void OverloadingMethod(int a, string b)
        {
            Console.WriteLine("Overloading method with int and string parameters: " + a + ", " + b);
        }
        public string OverloadingMethod(int a, string b, string c)
        {
            return $"Overloading method with int and string parameters: " + a + ", " + b + ", " + c;
        }
        // Overriding the Draw method from the base class
        public override void Draw()
        {
            Console.WriteLine("This is from base Shape class");
        }
        // Overriding the DrawAShape(int x, int y) method from the base class
        public override void DrawAShape(int x, int y)
        {
            Console.WriteLine("This is from base Shape class");
        }
    }
}
