using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Human
    {
        static void Main(string[] args)
        {

            Animal defaultHuman = new Animal();


            //objects need to have all the same arguments as the constructor created
            Animal amanda = new Animal("Amanda", "Human", "Female", "Hot Pockets", 29);
            //amanda.animalName = "Amanda";
            //amanda.animalType = "Human";
            //amanda.animalGender = "Female";
            //amanda.animalAge = 29;
            //amanda.animalEats = "Hot Pockets";


            Animal captain = new Animal("YellowBeard", "Male", "Beer");

            defaultHuman.IntroduceTheAnimal();
            amanda.IntroduceTheAnimal();
            captain.IntroduceTheAnimal();

            Console.ReadKey();
        }
    }
}
