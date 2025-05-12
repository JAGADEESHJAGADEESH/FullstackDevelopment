using System;

namespace C_Basics.OOPS.Abstraction
{
    public abstract class HeadQuarters : Hotel
    {
        // Abstract method
        public override void CheckIn()
        {
            Console.WriteLine("Check-in at the headquarters.");
        }

        // Abstract property
        public abstract string Location { get; set; }

        // Make this method abstract
        public abstract void DisplayInfo();
    }
}
