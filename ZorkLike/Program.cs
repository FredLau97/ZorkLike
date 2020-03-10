using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkLike
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();

            Console.WriteLine("Welcome to Zorkish!");
            Console.WriteLine($"You are standing in {world.currentArea.name}");
            while (true)
            {
                Console.WriteLine("Enter a command: ");
                string command = Console.ReadLine();
                string[] commands = command.Split(' ');

                switch (commands[0])
                {
                    case "go":
                        string dir;
                        if (commands.Length < 2)
                        {
                            //WriteLine for directione
                            dir = Console.ReadLine();
                        }
                        else
                            dir = commands[1];

                        bool success = false;
                        switch(dir)
                        {
                            case "north":
                            case "n":
                                success = world.Go(Directions.North);
                                break;
                            case "west":
                            case "w":
                                success = world.Go(Directions.West);
                                break;
                            case "south":
                            case "s":
                                success = world.Go(Directions.South);
                                break;
                            case "east":
                            case "e":
                                success = world.Go(Directions.North);
                                break;
                        }
                        if (success)
                            Console.WriteLine($"You have entered {world.currentArea.name}");
                        else
                            Console.WriteLine("There is nothing that way.");
                        break;

                    case "examine":
                        switch(commands[1])
                        {
                            case "area":
                                // Method in World to print currentArea description
                                break;
                            default:
                                Console.WriteLine("What the fuck do you wanna exanine?");
                                break;
                        }
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("The fuck you saying boy..");
                        break;
                }
            }
        }
    }
}
