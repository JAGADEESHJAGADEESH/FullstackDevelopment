using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.OOPS.Abstraction
{
    public abstract class Hotel
    {
        public Hotel()
        {
            
        }
        public abstract void CheckIn();
        public virtual void CheckOut()
        {
            Console.WriteLine("Check out from hotel");
        }
    }
}
