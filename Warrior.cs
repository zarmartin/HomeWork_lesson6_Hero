using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_lesson6_Hero
{
    public class Warrior : Hero
    {
        readonly int hitPoints = 70;

        readonly int damage = 30;

        readonly int armor = 20;
        public Warrior(string name) : base(name)
        {
        }

        public void ShowStats()
        {
            Console.WriteLine("My stats is: " + "\r\nHit point - " + hitPoints + "\r\nDamage - " + damage + "\r\nArmor - " + armor);
        }

        public override void StartFight()
        {
            Console.WriteLine($"{Environment.NewLine}Warrior {name} is ready for battle!");
        }
        public override void StopFight()
        {
            Console.WriteLine("I won the fight!");
        }
    }
}
