using System;
using System.Collections.Generic;

namespace cse210_DiceRoller
{
    public class Skill
    {  
        //The name, modifier, and dice to be rolled.
        public string traitName ="";
        public int modifier = 0;
        public Dice mainDice = new Dice();
        
        

        //Gets the mainDiceSize
        public virtual void ObtainDiceSize(){
            mainDice.getSize(20);
        }

        //Sets the values of the Skill class.
        public virtual void setValues(string traitName, int modifier){
            this.traitName = traitName;
            this.modifier = modifier;
        }

    }
}