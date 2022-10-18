using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Bird:Animal
    {
        public override void GetSound()
        {
            Console.WriteLine("bird sound");
        }
    }
}
