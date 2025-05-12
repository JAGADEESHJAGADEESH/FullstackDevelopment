using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.OOPS.Polymorphism
{
    public class UpCastingAndDownCasting
    {
        public void UpCasting()
        {
            // Upcasting
            Shape shape = new Circle();
            shape.Draw();
        }
        public void DownCasting()
        {
            // Downcasting
            Shape shape = new Circle();
            Circle circle = (Circle)shape; // Explicit cast
            circle.Draw(); 
            circle.DrawACircle(10,10);
            circle.DrawAShape(10, 10);
            circle.TestMethod();
        }
    }
}
