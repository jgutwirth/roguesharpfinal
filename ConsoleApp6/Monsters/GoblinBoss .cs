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
    public class GoblinBoss : Monster
    {
        public static GoblinBoss Create(int level)
        {
            int health = Dice.Roll("3D5");
            return new GoblinBoss
            {
                Attack = Dice.Roll("2D3"),
                AttackChance = Dice.Roll("25D3"),
                Awareness = 10,
                Color = Colors.GoblinColor,
                Defense = Dice.Roll("2D4"),
                DefenseChance = Dice.Roll("5D5"),
                Gold = Dice.Roll("10D6"),
                Health = health,
                MaxHealth = health,
                Name = "Goblin Boss",
                Speed = 12,
                Symbol = 'G'
            };
        }
    }
}