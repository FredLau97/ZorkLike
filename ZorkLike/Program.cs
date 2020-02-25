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

            Console.WriteLine("Area 1 Directions");
            Console.WriteLine(world.area1.areaConnections.ContainsKey(Directions.North));
            Console.WriteLine(world.area1.areaConnections.ContainsKey(Directions.West));
            Console.WriteLine(world.area1.areaConnections.ContainsKey(Directions.South));
            Console.WriteLine(world.area1.areaConnections.ContainsKey(Directions.East));
            Console.WriteLine("Area 1 Rooms");
            Console.WriteLine(world.area1.areaConnections.ContainsValue(world.area1));
            Console.WriteLine(world.area1.areaConnections.ContainsValue(world.area2));
            Console.WriteLine(world.area1.areaConnections.ContainsValue(world.area3));
            Console.WriteLine(world.area1.areaConnections.ContainsValue(world.area4));
            Console.WriteLine(world.area1.areaConnections.ContainsValue(world.area5));


            Console.WriteLine("\nArea 2:");
            Console.WriteLine(world.area2.areaConnections.ContainsKey(Directions.North));
            Console.WriteLine(world.area2.areaConnections.ContainsKey(Directions.West));
            Console.WriteLine(world.area2.areaConnections.ContainsKey(Directions.South));
            Console.WriteLine(world.area2.areaConnections.ContainsKey(Directions.East));
            Console.WriteLine("Area 2 Rooms");
            Console.WriteLine(world.area2.areaConnections.ContainsValue(world.area1));
            Console.WriteLine(world.area2.areaConnections.ContainsValue(world.area2));
            Console.WriteLine(world.area2.areaConnections.ContainsValue(world.area3));
            Console.WriteLine(world.area2.areaConnections.ContainsValue(world.area4));
            Console.WriteLine(world.area2.areaConnections.ContainsValue(world.area5));

            Console.WriteLine("\nArea 3:");
            Console.WriteLine(world.area3.areaConnections.ContainsKey(Directions.North));
            Console.WriteLine(world.area3.areaConnections.ContainsKey(Directions.West));
            Console.WriteLine(world.area3.areaConnections.ContainsKey(Directions.South));
            Console.WriteLine(world.area3.areaConnections.ContainsKey(Directions.East));
            Console.WriteLine("Area 3 Rooms");
            Console.WriteLine(world.area3.areaConnections.ContainsValue(world.area1));
            Console.WriteLine(world.area3.areaConnections.ContainsValue(world.area2));
            Console.WriteLine(world.area3.areaConnections.ContainsValue(world.area3));
            Console.WriteLine(world.area3.areaConnections.ContainsValue(world.area4));
            Console.WriteLine(world.area3.areaConnections.ContainsValue(world.area5));

            Console.WriteLine("\nArea 4:");
            Console.WriteLine(world.area4.areaConnections.ContainsKey(Directions.North));
            Console.WriteLine(world.area4.areaConnections.ContainsKey(Directions.West));
            Console.WriteLine(world.area4.areaConnections.ContainsKey(Directions.South));
            Console.WriteLine(world.area4.areaConnections.ContainsKey(Directions.East));
            Console.WriteLine("Area 4 Rooms");
            Console.WriteLine(world.area4.areaConnections.ContainsValue(world.area1));
            Console.WriteLine(world.area4.areaConnections.ContainsValue(world.area2));
            Console.WriteLine(world.area4.areaConnections.ContainsValue(world.area3));
            Console.WriteLine(world.area4.areaConnections.ContainsValue(world.area4));
            Console.WriteLine(world.area4.areaConnections.ContainsValue(world.area5));

            Console.WriteLine("\nArea 5:");
            Console.WriteLine(world.area5.areaConnections.ContainsKey(Directions.North));
            Console.WriteLine(world.area5.areaConnections.ContainsKey(Directions.West));
            Console.WriteLine(world.area5.areaConnections.ContainsKey(Directions.South));
            Console.WriteLine(world.area5.areaConnections.ContainsKey(Directions.East));
            Console.WriteLine("Area 5 Rooms");
            Console.WriteLine(world.area5.areaConnections.ContainsValue(world.area1));
            Console.WriteLine(world.area5.areaConnections.ContainsValue(world.area2));
            Console.WriteLine(world.area5.areaConnections.ContainsValue(world.area3));
            Console.WriteLine(world.area5.areaConnections.ContainsValue(world.area4));
            Console.WriteLine(world.area5.areaConnections.ContainsValue(world.area5));

            Console.ReadLine();
        }
    }
}
