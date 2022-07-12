using System;
using System.Collections.Generic;

namespace cse210_DiceRoller
{
    public class Dice
    {   //Size, rolled value, and modifier
        public int size = 0;
        public int value = 0;


        public void getSize(int size){
            this.size = size;
        }

        

        public void Roll(int size, int modifier){
            var rand = new Random();
            this.value = rand.Next(size + 1) + modifier;
        }
    }
}