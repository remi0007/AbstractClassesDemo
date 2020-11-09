using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motocycle : Vehicle

        
    {
        public Motocycle()
        {

        }

        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This motocycle is in drive");
           
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive");

        }
    }
}
