using System;

namespace OOPPractice
{
    public class Warrior
    {
        private int height;
        private int weight;
        private string power;
        private string name;

        public int Height { get; set; }
        public int Weight { get; set; }
        public string Power { get; set; }
        public string Name {get; set;}

        public Warrior(int height, int weight, string name, string power)
        {
            Height = height;
            Weight = weight;
            Name = name;
            Power = power;
        }


        public void Greetings(Warrior warrior)
        {
            System.Console.WriteLine($@"Greetings, {warrior.Power}!");
        }
    }
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Warrior theGoodGuy = new Warrior(190, 80, "Sangwynn", "One For All");
            // theGoodGuy.Height = 190;
            // theGoodGuy.Weight = 80;
            // theGoodGuy.Power = "One For All";
            // theGoodGuy.Name = "Sangwynn";

            Warrior theBadGuy = new Warrior(150, 60, "Thanos" , "All For One");
            // theBadGuy.Height = 150;
            // theBadGuy.Weight = 40;
            // theBadGuy.Power = "All For One";
            // theBadGuy.Name = "Thanos";

            System.Console.WriteLine(theBadGuy.Power);
            System.Console.WriteLine(theGoodGuy.Power);

            theGoodGuy.Greetings(theBadGuy);
            theBadGuy.Greetings(theGoodGuy);
        }
    }
}
