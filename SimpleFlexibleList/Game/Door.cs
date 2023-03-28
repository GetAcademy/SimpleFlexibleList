namespace SimpleFlexibleList.Game
{
    internal class Door
    {
        public Room Room1 { get; }
        public Room Room2 { get; }
        public ConsoleColor Color { get;  }
        public bool IsLocked { get;  }

        public Door(ConsoleColor color, Room room1, Room room2)
        {
            Room2 = room2;
            Room1 = room1;
            Color = color;
            IsLocked = true;
        }

        public Room GetOtherRoom(Room room)
        {
            return Room1 == room ? Room2 : Room1;
        }
    }
}
