using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task36
{
    class PetShop
    {
        static void Main(string[] args)
        {
            List<Cat> myCat = new List<Cat>();
            myCat.Add(new Cat { Name = "cat2", Breed = true });
            foreach (Cat c in myCat)
                c.Add();
            List<Dog> myDog = new List<Dog>();
            myDog.Add(new Dog { Name = "dog2", Breed = true });
            foreach (Dog d in myDog)
                d.Add();
            Console.ReadKey();
            
        }
    }
}
