using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLNET;
using RogueSharp;

namespace ConsoleApp6.Core
{
    public class Player : Actor
    {
        public Player()
        {
            Attack = 2;
            AttackChance = 50;
            Awareness = 15;
            Defense = 2;
            DefenseChance = 40;
            Gold = 0;
            Health = 100;
            MaxHealth = 100;
            Speed = 10;
            Name = "Rogue";
            Color = Colors.Player;
            Symbol = '@';
            X = 10;
            Y = 10;
        }
        public void DrawStats( RLConsole statConsole)
        {
            statConsole.Print(1, 1, $"Name: {Name}", Colors.Text);
            statConsole.Print(1, 3, $"Health: {Health}", Colors.Text);
            statConsole.Print(1, 5, $"Attack: {Attack}", Colors.Text);
            statConsole.Print(1, 7, $"Defense: {Defense}", Colors.Text);
            statConsole.Print(1, 9, $"Gold: {Gold}", Colors.Gold);
        }
    }
}
