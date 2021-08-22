using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{   
    //Class 'Animal' is a blue print for an datatype/object
    class Animal
    {
        //parent variable
        private string animalName;
        private string animalType;
        private string animalGender;
        private string animalEats;
        private int animalAge;


        //constructors are also members (like a method)
        // just needs the access modifier (like public/private) and the object you want to create (class)


        //default constructor
        public Animal()
        {
            Console.WriteLine("These animals are in our exibits.");
            Console.WriteLine(" ");
        }

        //parameterized constructor example
        public Animal (string animalName, string animalType, string animalGender, string animalEats, int animalAge)
        {
            // want to be able to change the NULL data to the data of your new object
            //THIS variable, not the local one (local meaning the parent variables)
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalGender = animalGender;
            this.animalEats = animalEats;
            this.animalAge = animalAge;
            //these values are created whenever an object is created with this constructor
            //a constructor is like a method that is called whenever an object is created
        }

        public Animal(string animalName, string animalType, string animalGender, string animalEats)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalGender = animalGender;
            this.animalEats = animalEats;
        }

        public Animal(string animalName, string animalGender, string animalEats)
        {
            this.animalName = animalName;
            this.animalGender = animalGender;
            this.animalEats = animalEats;
        }

        public Animal(string animalName, string animalGender)
        {
            this.animalName = animalName;
            this.animalGender = animalGender;
        }

        public Animal(string animalName)
        {
            this.animalName = animalName;
        }

        //variables are not public, so they will not be accesible to outside classes. 
        public void IntroduceTheAnimal()
        {
            //basic output
            //Console.WriteLine("This is {0}, a {1} year old {2} {3} who enjoys {4}.", animalName, animalAge, animalGender, animalType, animalEats);

            //smarter output
            if (animalName != null && animalType != null && animalGender != null && animalEats != null && animalAge != 0)
                Console.WriteLine("This is {0}, a {1} year old {2} {3} who enjoys {4}.", animalName, animalAge, animalGender, animalType, animalEats);
            else if (animalName != null && animalType != null && animalGender != null && animalEats != null)
            {
                Console.WriteLine("This is {0}, a {1} {2} who enjoys {3}.", animalName, animalGender, animalType, animalEats);
            }
            else if (animalName != null && animalGender != null && animalEats != null)
            {
                Console.WriteLine("This is {0}, a {1} of unknown origin, who enjoys {2}.", animalName, animalGender, animalEats);
            }
            else if (animalName != null && animalType != null)
            {
                Console.WriteLine("This is {0}, a {1}. The means of it's origins and nutrition habits are unknown.", animalName, animalType);
            }
            else if(animalName != null)
            {
                Console.WriteLine("This is {0}. The existance of this creature is still under investigation.", animalName);
            }
            else
            {
                Console.WriteLine(" ");
            }

           //
        }
    }
}
