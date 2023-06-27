
using HomeWork_lesson6_Hero;

class PlayerVersusPlayer
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input your Name!");

        string name = Console.ReadLine();

        Console.WriteLine($"{Environment.NewLine}Choose your Hero class");

        Console.WriteLine("Input \"1\" to choose Mage!");

        Console.WriteLine("Input \"2\" to choose Warrior!");

        Console.WriteLine("Input \"3\" to choose Paladin!");


        var input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Mage mage = new Mage(name);
                mage.StartFight();
                mage.ShowStats();
                mage.StopFight();
                break;
            case "2":
                Warrior warrior = new Warrior(name);
                warrior.StartFight();
                warrior.ShowStats();
                warrior.StopFight();
                break;
            case "3":
                Paladin paladin = new Paladin(name);
                paladin.StartFight();
                paladin.ShowStats();
                paladin.StopFight();
                break;
            default:
                Console.WriteLine("I don't know this command!");
                break;
        }

        Console.ReadKey();
    }
}