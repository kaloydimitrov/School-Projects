using System;

namespace ConsoleApp1
{
    public class hotelRoom
    {
        private int number;
        private int floor;
        private string type;
        private string view;

        public int Number
        {
            set { this.number = value; }
            get { return this.number; }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            hotelRoom newRoom = new hotelRoom();
            newRoom.Number = 12;
        }
    }
}
