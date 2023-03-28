namespace SimpleFlexibleList.Game
{
    internal class Room
    {
        public string Name { get; }
        public List<Door> Doors { get;  }

        public Room(string name)
        {
            Doors = new List<Door>();
            Name = name;
        }

        public void Add(Door door)
        {
            Doors.Add(door);
            var otherRoom = door.GetOtherRoom(this);
            otherRoom.Add(door);
        }
    }
}
