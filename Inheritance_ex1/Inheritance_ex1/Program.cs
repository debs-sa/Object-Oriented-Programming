using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//polymorphsim, override

namespace InheritanceExample1
{
    class Animal
    {
        public string Name { get; set; }
        public string Food { get; set; }

        public virtual void PrintMyName()
        {
            Console.WriteLine("I am {0}.", Name);
        }
        public void PrintMyFood()
        {
            Console.WriteLine("My food is {0}.", Food);
        }

    }

    class Dog : Animal
    {
        public override void PrintMyName()
        {
            Console.WriteLine("{0} is my name.", Name);
        }

        public string Sound { get; set; }
        public void MySound()
        {
            Console.WriteLine("My sound is {0}.", Sound);
        }

    }

    class Program
        {
            static void Main(string[] args)
            {
                Animal tom = new Animal();
                tom.Name = "Tom";
                tom.Food = "Fish";
                tom.PrintMyName();
                tom.PrintMyFood();

                Console.WriteLine();

                Dog husky = new Dog(); // type = husk / reference = dog
                husky.Name = "Mr. Husky";
                husky.Food = "Bone";
                husky.Sound = "Woof";
                husky.PrintMyName();
                husky.PrintMyFood();
                husky.MySound();

                Animal husky2 = new Dog(); //every dog is a animal but not animal is a dog -> name and food from DOG CLASS
                husky2.Name = "Mr. Husky";
                husky2.Food = "Bone";

                Console.WriteLine();

                husky2.PrintMyName(); //late binding
                husky2.PrintMyFood();
            //  husky2.Sound = "Woof"; Animal class does not have sound property
            //  husky2.MySound();
            }
        }


    
}