using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_lesson6_Hero
{
    public class Paladin : Warrior
    {
        public Paladin(string name) : base(name)
        {
        }

        public override void StartFight()
        {
            Console.WriteLine($"{Environment.NewLine}Paladin {name} is ready for battle!");
        }

        public override void StopFight()
        {
            Console.WriteLine("I lost the battle!");
        }
    }
}
