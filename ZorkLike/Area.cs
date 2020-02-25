using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkLike
{
    class Area
    {
        string name;
        string description;
        List<Item> items = new List<Item>();

        public Directions north = Directions.North;
        public Directions south = Directions.South;
        public Directions east = Directions.East;
        public Directions west = Directions.West;

        public Dictionary<Directions, Area> areaConnections = new Dictionary<Directions, Area>();

        public Area(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Connect(Area area, Directions dir, bool connectBack = true)
        {
            if (connectBack == true)
            {
                connectBack = false;
                Connect(area, dir, connectBack);
                area.Connect(this, ConnectBack(dir), connectBack);
            }
            else
                areaConnections.Add(dir, area);
        }

        Directions ConnectBack(Directions dir)
        {
            switch (dir)
            {
                case Directions.North:
                    return south;
                case Directions.South:
                    return north;
                case Directions.East:
                    return west;
                case Directions.West:
                    return east;
                default:
                    return north;
            }
        }
    }

    public enum Directions
    {
        North, South, East, West
    }
}
