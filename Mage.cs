using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_lesson6_Hero
{
    public class Mage : Hero
    {
        private int hitPoints = 100;

        private int damage = 20;

        private int armor = 10;
        public Mage(string name) : base(name)
        {
        }

        public void ShowStats()
        {
            Console.WriteLine("My stats is: " + "\r\nHit point - " + hitPoints + "\r\nDamage - " + damage + "\r\nArmor - " + armor);
        }

        public override void StartFight()
        {
            Console.WriteLine($"{Environment.NewLine}Mage {name} is ready for battle!");
        }
        public override void StopFight()
        {
            Console.WriteLine("I took damage!");
        }
    }
}
