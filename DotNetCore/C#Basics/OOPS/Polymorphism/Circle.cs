using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.OOPS.Polymorphism
{
    public class Circle : Shape
    {
        public Circle()
        {
        }
        public Circle(int x, int y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a CIRCLE at {0},{1}", m_xpos, m_ypos);
        }
        public void DrawACircle(int x, int y)
        {
            Console.WriteLine("Drawing a CIRCLE at {0},{1}", x, y);
        }
    }
}
