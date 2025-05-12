using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.OOPS.Abstraction
{
    public class FiveStarHotel : Hotel
    {
        public override void CheckIn()
        {
            Console.WriteLine("Check in to Five Star Hotel");
        }
        public override void CheckOut()
        {
            Console.WriteLine("Check out from Five Star Hotel");
        }
        
    }
    
}
