using System;
using System.Collections.Generic;

namespace cse210_DiceRoller
{
    public class Attack : Skill
    {  
        public int damageDiceSize = 0;
        public int damageModifier= 0;
        public Dice damageDice = new Dice();


        //Change dice to regular dice.
        public override void ObtainDiceSize(){
            mainDice.getSize(20);
            damageDice.getSize(this.damageDiceSize);

        }

        //Set the values for Attack object.
        public void setAttackValues(string traitName, int modifier, int damageDiceSize, int damageModifier){
            this.traitName = traitName;
            this.modifier = modifier;
            this.damageDiceSize = damageDiceSize;
            this.damageModifier = damageModifier;
            
        }

    }
}