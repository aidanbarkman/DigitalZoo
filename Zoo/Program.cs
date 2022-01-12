using System;
using System.Collections.Generic;

namespace Zoo
{
    /*The Zookeepers need a system to keep track of all their animals. They need to be able to enter all their animals into the system in a way that allows them to identify and locate them. This requires identifying them by species, age and one characteristic unique to their species.

There are three cages and the user must input information about the animal in each one. After accepting input for all three cages, the program should output the contents of each cage in a way that exposes all the information about that animal.
The program should accept the following species: Lion, Bear, Wolf.
Define classes for the Lion, Bear, and Wolf species that all implement the Animal interface. All Animals should have an int field for age and a String field for species. Each species of animal should have its own unique field defined: String maneColour for Lions, int speed for Wolves, and bool isGrizzly for Bears. They should also define two methods:
RequestUniqueCharacteristic() which outputs a string asking for a value to store in the specific animal’s unique characteristic and stores it in the appropriate field (maneColour, speed, or isGrizzly)
GetDescription() which outputs a short sentence that includes all the animal’s info.
Store all the Animals in a list of animals (List<Animal>) and iterate through the list to output all the animals after input is received.
Sample Session

Cage 1
What is the animal’s species? Lion
How old is it? 6
What colour is its mane? Brown

Cage 2
What is the animal’s species? Wolf
How old is it? 9
How fast can it run (in km/h)? 20

Cage 3
What is the animal’s species? Bear
How old is it? 12
Is it a grizzly bear (true/false)? No
=====
Cage 1 contains a 6-year-old lion with a brown mane.
Cage 2 contains a 9-year-old wolf that runs 20 km/h.
Cage 3 contains a 12-year-old non-grizzly bear.
*/
    class Program
    {
        static void Main(string[] args)
        {
            //decided to do class for every animal 
            Lion lion = new Lion();
            List<Lion> lionList = new List<Lion>();
            int lionC, wolfC, bearC = 0;
            lionC = 0; //find which cage it is in
            wolfC = 0;
            bearC = 0;
            Bear bear = new Bear();
            List<Bear> bearList = new List<Bear>();

            Wolf wolf = new Wolf();
            List<Wolf> wolfList = new List<Wolf>();


            bool loop = true;
            int count = 0;
            while (loop == true && count < 3)
            {
                count++;

                Console.WriteLine("---------------------------------------------------------------------------");//Easier to read
                Console.WriteLine("Cage " + count);
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("What species is it?( Please enter Bear, Wolf, or Lion or type quit to exit)");
                String userInput = Console.ReadLine();

                if (userInput == "bear" || userInput == "Bear") //bear input
                {
                    Console.WriteLine("How old is it?"); //check age
                    userInput = Console.ReadLine();
                    bear.getAge(Convert.ToInt32(userInput)); //add age
                    Console.WriteLine("Is it a grizzly bear (yes or no)"); // check type
                    userInput = Console.ReadLine();
                    if (userInput == "yes" || userInput == "Yes")
                        bear.getDescription(true);
                    else if (userInput == "no" || userInput == "No")
                        bear.getDescription(false); //add type
                    bearList.Add(bear);//add to list
                    bearC = count;//check cage
                }
                else if (userInput == "wolf" || userInput == "Wolf")
                {
                    Console.WriteLine("How old is it?");
                    userInput = Console.ReadLine();
                    wolf.getAge(Convert.ToInt32(userInput));
                    Console.WriteLine("How fast is it?");
                    userInput = Console.ReadLine();
                    wolf.getDescription(Convert.ToInt32(userInput));
                    wolfList.Add(wolf);
                    wolfC = count;

                }
                else if (userInput == "lion" || userInput == "Lion")
                {
                    Console.WriteLine("How old is it?");
                    userInput = Console.ReadLine();
                    lion.getAge(Convert.ToInt32(userInput));
                    Console.WriteLine("What Color Mane does it have?");
                    userInput = Console.ReadLine();
                    lion.getDescription(userInput);
                    lionList.Add(lion);
                    lionC = count;
                }
                else if (userInput == "quit" || userInput == "Quit")
                {
                    loop = false;
                }
                else
                {
                    count--; //invalid input makes them retype it
                    Console.WriteLine("Invalid Input");
                }

            }

            String convString = "";

            foreach (var bears in bearList)
            {
                Console.WriteLine("Cage " + bearC.ToString() + " has " + bears.toString(convString));
            }
            foreach (var lions in lionList)
            {
                Console.WriteLine("Cage " + lionC.ToString() + " has " + lions.toString(convString));
            }
            foreach (var wolfs in wolfList)
            {
                Console.WriteLine("Cage " + wolfC.ToString() + " has " + wolfs.toString(convString));
            }
            Console.ReadLine();
        }
    }
}

