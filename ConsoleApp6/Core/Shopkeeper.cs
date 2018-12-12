using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Core
{
    public class Shopkeeper : Actor
    {
        public Shopkeeper()
        {
            Attack = 0;
            AttackChance = 0;
            Awareness = 15;
            Defense = 10;
            DefenseChance = 100;
            Gold = 0;
            Health = 100000;
            MaxHealth = 100000;
            Speed = 0;
            Name = "Shopkeeper";
            Color = Colors.Player;
            Symbol = '$';
            //List<item> ItemInventory = new List<item>();
        }
    }
}
