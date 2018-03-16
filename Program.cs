using System;

namespace OOPPractice
{
    public class Warrior
    {
        private int height;
        private int weight;
        private string power;
        
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Power { get; set; }
    }
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Warrior sangwynn = new Warrior();
            sangwynn.Height = 190;
            sangwynn.Weight = 80;
            sangwynn.Power = "One For All";

            Warrior theBadGuy = new Warrior();
            theBadGuy.Height = 150;
            theBadGuy.Weight = 40;
            theBadGuy.Power = "All For One";
            System.Console.WriteLine(theBadGuy.Power);
            System.Console.WriteLine(sangwynn.Power);
        }
    }
}
