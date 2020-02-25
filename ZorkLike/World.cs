using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            area1.Connect(area2, area1.north, false);
            area2.Connect(area3, area2.west, true);
            area3.Connect(area4, area3.south, true);
            area3.Connect(area5, area3.north, false);
            area4.Connect(area1, area4.east, true);

            startingArea = area1;
            currentArea = area1;
        }
    }
}
