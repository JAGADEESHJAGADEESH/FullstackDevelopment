using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.Partial
{
    public partial class Test
    {
        public Test()
        {
            Console.WriteLine("DoSomeThing() method is declared as partial in class is Test1 class, meaning it can be implemented in another partial class with same name Test but idle class name is Test2");
            Console.WriteLine($"This class name is {this.GetType().Name}");
            DoSomeThing();
        }
        partial void DoSomeThing();
    }
}
