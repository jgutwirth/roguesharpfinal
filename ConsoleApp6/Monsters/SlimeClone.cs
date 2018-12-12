using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Core;
using RogueSharp.DiceNotation;

namespace ConsoleApp6.Monsters
{
    public class SlimeClone : Monster
    {
        public static SlimeClone Create(int level)
        {
            int health = Dice.Roll("1D5")/2;
            return new SlimeClone
            {
                Attack = (Dice.Roll("1D3") + level / 3) / 2,
                AttackChance = Dice.Roll("25D3")/2,
                Awareness = 10,
                Color = Colors.SlimeColor,
                Defense = (Dice.Roll("1D3") + level / 3)/2,
                DefenseChance = Dice.Roll("5D5")/2,
                Gold = Dice.Roll("5D5")/2,
                Health = health,
                MaxHealth = health,
                Name = "Slime",
                Speed = 6,
                Symbol = 's'
            };
        }
    }
}
