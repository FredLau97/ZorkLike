using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZorkLike;

namespace ZorkLike
{
    class World
    {
        List<Area> allAreas = new List<Area>();
        public Area startingArea;
        public Area currentArea;

        public Area area1;
        public Area area2;
        public Area area3;
        public Area area4;
        public Area area5;

        public World()
        {
            area1 = new Area("Starting Area", "This is where you start");
            area2 = new Area("Silvermoon", "It's pretty huge");
            area3 = new Area("Mushroom forest", "Don't eat the mushrooms!");
            area4 = new Area("Teapot Area", "Bring your teabags");
            area5 = new Area("Teabag area", "You are doomed");

            area1.Connect(area2, Directions.North, true);
            area2.Connect(area3, Directions.West, true);
            area3.Connect(area4, Directions.South, true);
            area3.Connect(area5, Directions.North, false);
            area4.Connect(area1, Directions.East, true);

            startingArea = area1;
            currentArea = area1;
        }

        public bool Go(Directions direction)
        {
            if (currentArea.areaConnections.ContainsKey(direction))
            {
                currentArea = currentArea.areaConnections[direction];
                return true;
            }
            else
            {
                Console.WriteLine("There is nothing that way.");
                return false;
            }
        }
    }


}
