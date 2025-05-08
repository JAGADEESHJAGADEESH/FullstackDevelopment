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
            DoSomeThing();
        }
        partial void DoSomeThing();

        void DoSomeThing1()
        {
            Console.WriteLine("This is not implemented");
        }
    }
}
