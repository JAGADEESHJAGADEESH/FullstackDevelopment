using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.Partial
{
    public partial class Test
    {
      
        partial void DoSomeThing()
        {
            Console.WriteLine("This is implemented");
        }
    }
}
