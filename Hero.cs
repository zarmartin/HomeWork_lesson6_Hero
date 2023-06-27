using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_lesson6_Hero
{
    public abstract class Hero
    {
        protected string name;

        protected int hitPoints;

        protected int damage;

        protected int armor;

        public Hero(string name)
        {
            this.name = name;
        }

        public virtual void StartFight() 
        {
            Console.WriteLine($"{Environment.NewLine}Hero {name} is ready for battle!");
        }

        public abstract void StopFight();

        public void ShowStats()
        {
            Console.WriteLine("My stats is: " + "\r\nHit point - " + hitPoints + "\r\nDamage - " + damage + "\r\nArmor - " + armor);
        }
    }
}
