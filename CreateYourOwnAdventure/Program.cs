using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //author @Kaebob

            //title:
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine();

            //create a string for our story
            string story = "It begins on a cold rainy night. You're sitting in your \nroom and hear a noise coming from down the hall. Do you go \ninvestigate?";

            //prints the story to the console
            Console.WriteLine(story);
            Console.WriteLine();

            //gives user instructions on how to make a decision in game
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine().ToUpper();
            Console.WriteLine();

            /* Checks the players choice and responds with either ending the game or continuing on */
            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room! \nTHE END");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into a hallway and see a light coming from under \na door down the hall. \nYou walk towards it. Do you open it or knock?");
                Console.WriteLine();
            }

            //Asks the user to make a second decision
            Console.Write("Type OPEN or KNOCK ");
            string doorChoice = Console.ReadLine().ToUpper();

            //Checks players choices
            if (doorChoice == "KNOCK")
            {
                Console.WriteLine();
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this \nriddle: \"\n\"Poor People have it. Rich people need it. If you eat it \nyou die. What is it?\"");
                Console.WriteLine();
                Console.Write("Type your answer: ");
                string riddleAnswer = Console.ReadLine().ToUpper();
                if (riddleAnswer == "NOTHING")
                {
                    Console.WriteLine();
                    Console.WriteLine("The door opens and NOTHING is there. \nYou turn off the light and run back to your room and lock \nthe door.");
                    Console.WriteLine("THE END.");
                }
                else
                {
                    Console.WriteLine("Your answered incorrectly. The door doesn't open. \nTHE END.");
                }
            }
            else if (doorChoice == "OPEN")
            {
                Console.WriteLine();
                Console.WriteLine("The door is locked! See if one of your three keys will open \nit.");
                Console.Write("Enter a number (1-3): ");
                string keyChoice = Console.ReadLine().ToUpper();
                //create a switch statement
                switch (keyChoice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("You choose the first key. Lucky choice! \nThe door opens and NOTHING is there. Strange...\n");
                        Console.WriteLine("THE END.");
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("You choose the second key. The door doesn't open.\n");
                        Console.WriteLine("THE END.");
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("You choose the third key. The door doesn't open.\n");
                        Console.WriteLine("THE END.");
                        break;
                }
            }
        }
    }
}