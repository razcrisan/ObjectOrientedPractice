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
            System.Console.WriteLine($@"Greetings, {warrior.Name}!");
        }
    }