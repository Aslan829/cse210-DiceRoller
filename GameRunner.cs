using System;
using System.Collections.Generic;

namespace cse210_DiceRoller
{
    public class GameRunner
    {   
        private string option = "BLANK";
        public void RunGame(Character player){
            Console.WriteLine("What kind of roll do you want?");
            Console.WriteLine("s for skill");
            Console.WriteLine("a for attack");
            Console.WriteLine("c for a custom roll");
            Console.WriteLine("q to quit");
            Console.WriteLine("Option: ");

            option = Console.ReadLine();

            switch(option)
            {
                case "s":
                    player.getSkillsList();
                    this.skillRoll(player.SkillsList);
                    break;
                case "a":
                    player.setAttackList();
                    this.attackRoll(player.AttackList);
                    break;
                case "c":
                    this.customRoll();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }


        }

        public void skillRoll(List<Skill> list){
            string skillChoice = "";
            Console.WriteLine("What skill are you rolling?");
            skillChoice = Console.ReadLine();

            foreach (Skill option in list)
            {
                if (option.traitName == skillChoice){
                    option.ObtainDiceSize();
                    option.mainDice.Roll(option.mainDice.size, option.modifier);
                    Console.WriteLine("Result is: " + option.mainDice.value);
                    
                }
            }
           
        }

        public void attackRoll(List<Attack> attackList){
            string attackChoice = "";
            Console.WriteLine("Which attack are you rolling?");
            attackChoice = Console.ReadLine();

            foreach (Attack option in attackList)
            {
                
                if (option.traitName == attackChoice){
                    option.ObtainDiceSize();

                    //Roll to hit.
                    option.mainDice.Roll(option.mainDice.size, option.modifier);
                    Console.WriteLine("Result is: " + option.mainDice.value);
                    //If roll is over 15 (AC), roll to hit. 
                    if (option.mainDice.value >= 15){
                        option.damageDice.Roll(option.damageDiceSize, option.damageModifier);
                        Console.WriteLine("Damage done is: " + option.damageDice.value);

                    //Reset the values of the main dice and damage dice.
                    
                    //If they miss, display it to the player.
                    }else{
                        Console.WriteLine("You miss.");
                    }
                    
                } 
            }
        }

        //Roll all the dice that the user wants.
        public void customRoll(){
            Console.WriteLine("Dice to roll:");
            Roll rollList = new Roll();

            //How many d4?
            Console.WriteLine("D4? ");
            int d4 = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < d4; i++){
                Dice dice = new Dice();
                dice.getSize(8);
                rollList.ListOfDice.Add(dice);
            }

            //How many d6?
            Console.WriteLine("D6? ");
            int d6 = Int32.Parse(Console.ReadLine());
            //Add to list
            for(int i = 0; i < d6; i++){
                Dice dice = new Dice();
                dice.getSize(8);
                rollList.ListOfDice.Add(dice);
            }


            //How many d8?
            Console.WriteLine("D8? ");
            int d8 = Int32.Parse(Console.ReadLine());
            //Add to list.
            for(int i = 0; i < d8; i++){
                Dice dice = new Dice();
                dice.getSize(8);
                rollList.ListOfDice.Add(dice);
            }

            //How many d10?
            Console.WriteLine("D10? ");
            int d10 = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < d10; i++){
                Dice dice = new Dice();
                dice.getSize(10);
                rollList.ListOfDice.Add(dice);
            }


            //How many d12?
            Console.WriteLine("D12? ");
            int d12 = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < d12; i++){
                Dice dice = new Dice();
                dice.getSize(12);
                rollList.ListOfDice.Add(dice);
            }

            //How many d20?
            Console.WriteLine("D20? ");
            int d20 = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < d20; i++){
                Dice dice = new Dice();
                dice.getSize(20);
                rollList.ListOfDice.Add(dice);
            }

            //How many d4?
            Console.WriteLine("D100? ");
            int d100 = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < d100; i++){
                Dice dice = new Dice();
                dice.getSize(100);
                rollList.ListOfDice.Add(dice);
            }
            
            //Total amount of roll.
            int totalRolled = 0;
            foreach(Dice dice in rollList.ListOfDice){
                dice.Roll(dice.size, 0);
                totalRolled += dice.value;

            }
            Console.Write("Total Sum of Dice: " + totalRolled);
        }

        

    }
}