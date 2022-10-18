using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Animal
    {
        public virtual void GetSound()
        {
            Console.WriteLine("Aniaml sound");
        }

        public void Eat()
        {
            Console.WriteLine("Animal eating");
        }

        public void Eat(string t)
        {
            Console.WriteLine(t);
        }

        public void Eat(string t, string w)
        {
            Console.WriteLine(t,w);
        }
    }
}
