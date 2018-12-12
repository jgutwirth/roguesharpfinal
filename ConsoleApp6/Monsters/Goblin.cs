using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Core;
using RLNET;
using RogueSharp.DiceNotation;
using RogueSharp;

namespace ConsoleApp6.Monsters
{
    public class Goblin : Monster
    {
        public static Goblin Create(int level)
        {
            int health = Dice.Roll("2D6");
            return new Goblin
            {
                Attack = Dice.Roll("1D4") + level / 3,
                AttackChance = Dice.Roll("25D3"),
                Awareness = 10,
                Color = Colors.GoblinColor,
                Defense = Dice.Roll("1D4") + level / 3,
                DefenseChance = Dice.Roll("5D5"),
                Gold = Dice.Roll("5D6"),
                Health = health,
                MaxHealth = health,
                Name = "Goblin",
                Speed = 12,
                Symbol = 'g'
            };
        }
    }
}
