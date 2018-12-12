using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Core;
using RogueSharp.DiceNotation;
using RLNET;
using RogueSharp;

namespace ConsoleApp6.Monsters
{
    public class KoboldBoss : Monster
    {
        public static KoboldBoss Create(int level)
        {
            int health = Dice.Roll("3D5");
            return new KoboldBoss
            {
                Attack = Dice.Roll("2D3"),
                AttackChance = Dice.Roll("25D3"),
                Awareness = 10,
                Color = Colors.KoboldColor,
                Defense = Dice.Roll("1D3") + level/3 + 2,
                DefenseChance = Dice.Roll("5D5"),
                Gold = Dice.Roll("10D5"),
                Health = health,
                MaxHealth = health,
                Name = "Kobold Boss",
                Speed = 9,
                Symbol = 'K'
            };
        }
    }
}
