using System;
using System.Collections.Generic;

namespace cse210_DiceRoller
{
    public class Dice
    {   //Size, and rolled value
        public int size = 0;
        public int value = 0;

        //Get the size
        public void getSize(int size){
            this.size = size;
        }

        
        //Roll the dice for the value
        public void Roll(int size, int modifier){
            var rand = new Random();
            this.value = rand.Next(size + 1) + modifier;
        }
    }
}