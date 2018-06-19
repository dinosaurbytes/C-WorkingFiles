using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craps
{
    public class Dice
    {
        private Random random;

        public Dice()
        {
            random = new Random();
        }
        
        public int Dice1 { get; set; }
        public int Dice2 { get; set; }

        public int RollDice()
        {
            Dice1 = random.Next(1, 7);
            Dice2 = random.Next(1, 7);
            return Dice1 + Dice2;
        }




    }
}
