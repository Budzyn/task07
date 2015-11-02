using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task36
{
    class Cat:Animal,task36.Animal.Show
    {
        public void Add()
        {
            Console.WriteLine("I am a {0} of {1}", Name, Breed);
        }
    }
}
