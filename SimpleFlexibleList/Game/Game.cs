namespace SimpleFlexibleList.Game
{
    internal class Game
    {
        private Room _current;

        public Game()
        {
            var roomA = new Room("A");
            var roomB = new Room("B");
            var roomC = new Room("C");
            var roomD = new Room("D");
            var roomE = new Room("E");
            var roomF = new Room("F");

            var doorAB = new Door(ConsoleColor.Red, roomA, roomB);
            var doorAD = new Door(ConsoleColor.Green, roomA, roomD);
            var doorBE = new Door(ConsoleColor.Blue, roomB, roomE);
            var doorBC = new Door(ConsoleColor.Gray, roomB, roomC);
            var doorEF = new Door(ConsoleColor.White, roomE, roomF);

            roomA.Add(doorAB);
            roomA.Add(doorAD);
            roomB.Add(doorBC);
            roomB.Add(doorBE);
            roomE.Add(doorEF);

            _current = roomA;
        }

        public void Run()
        {

        }
    }
}
