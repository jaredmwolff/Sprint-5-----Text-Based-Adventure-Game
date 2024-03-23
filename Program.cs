//--------------------------------------------------------------------------------------------------------------------

using System;
using System.Data;
using System.Xml.Serialization;

//--------------------------------------------------------------------------------------------------------------------

namespace Adventure
{
    public static class Game
    {
        //The default name, just in case
        static string CharacterName = "John Smith";

        //Here, the user inputs a name for the player
        static void NameCharacter()
        {
            Console.WriteLine("What is your character's name?");
            Console.Write("> ");
            CharacterName = Console.ReadLine();

            Console.WriteLine("Excellent! The name of your character is now " + CharacterName);
            Console.ReadKey();
        }

        //This is where the ALL of the choices are
        static void Choices()
        {
            Console.Clear();
            Console.WriteLine("The player, " + CharacterName + ", wakes up in a well-lit cave with no prior memory of how they got there.");
            Console.WriteLine("To your LEFT, you see a passageway, which could potentially lead you outside.");
            Console.WriteLine("To your RIGHT, you see a wooden box. Perhaps there is something useful in there?");
            Console.WriteLine();
            Console.WriteLine("Decision: Where will the player go?");
            Console.WriteLine("A) Left");
            Console.WriteLine("B) Right");
            Console.WriteLine();

            Console.Write("> ");
            string decision1 = Console.ReadLine();

            if (decision1 == "A")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("As " + CharacterName + " walks down this passageway, you notice a bright light down the end of the tunnel.");
                Console.WriteLine();
                Console.WriteLine("Decision: What will the player do?");
                Console.WriteLine("A) Walk Towards the Light");
                Console.WriteLine("B) Go Back to the Room You Woke Up In");
                Console.WriteLine();

                Console.Write("> ");
                string decision2 = Console.ReadLine();

                    if (decision2 == "A")
                    {
                        Console.Clear();
                        Console.WriteLine("As you walk towards the light, you quickly find yourself outside of the cave.");
                        Console.WriteLine("Congratulations! You have escaped the cave!");
                    }

                    else if (decision2 == "B")
                    {
                        Console.Clear();
                        Choices();
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please answer with one of the following options: A or B");
                    }
            }

            else if (decision1 == "B")
            {
                Console.Clear();
                Console.WriteLine("As you approach the wooden box, you hear an odd, unfamiliar noise emanating from inside.");
                Console.WriteLine();
                Console.WriteLine("Decision: What will the player do?");
                Console.WriteLine("A) Open the Box");
                Console.WriteLine("B) Don't Open the Box");
                Console.WriteLine();

                Console.Write("> ");
                string decision3 = Console.ReadLine();

                if (decision3 == "A")
                {
                    Console.Clear();
                    Console.WriteLine("As you open the box, you see a mysterious creature held within.");
                    Console.WriteLine("Unfortunately for you, the creature is not pleased that you woke it up.");
                    Console.WriteLine("The creature screeches in a manner you have never heard.");
                    Console.WriteLine("Your consciousness quickly fades, until you pass out...");
                    Console.WriteLine(CharacterName + " was never heard from again...");
                }

                else if (decision3 == "B")
                {
                    Console.Clear();
                    Choices();
                }

                else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please answer with one of the following options: A or B");
                    }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice. Please answer with one of the following options: A or B");
            }
    }


//--------------------------------------------------------------------------------------------------------------------


    //The class that starts the game
    //Additionally, it holds the properties to start the following: NameCharacter() & Choices()
    public static void StartGame()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Sprint Project: C# Coding Language");
        Console.WriteLine();
        Console.WriteLine("Welcome to the Text Adventure Game!");
        Console.WriteLine();

        NameCharacter();
        Console.WriteLine();

        Choices();
        }
    }


//--------------------------------------------------------------------------------------------------------------------


    //Runs the class that starts the game
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}