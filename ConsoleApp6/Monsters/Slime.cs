using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Core;
using RLNET;
using RogueSharp;
using RogueSharp.DiceNotation;

namespace ConsoleApp6.Monsters
{
    public class Slime : Monster
    {
        public static Slime Create(int level)
        {
            int health = Dice.Roll("1D5");
            return new Slime
            {
                Attack = Dice.Roll("1D3") + level / 3,
                AttackChance = Dice.Roll("25D3"),
                Awareness = 10,
                Color = Colors.SlimeColor,
                Defense = Dice.Roll("1D3") + level / 3,
                DefenseChance = Dice.Roll("5D5"),
                Gold = Dice.Roll("5D5"),
                Health = health,
                MaxHealth = health,
                Name = "Slime",
                Speed = 6,
                Symbol = 's'
            };
        }
    }
}
