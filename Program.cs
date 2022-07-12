// See https://aka.ms/new-console-template for more information
using System;
using System.Text.Json;

namespace cse210_DiceRoller
{
    public class Program
    {
        //Create player class and set up the character sheet.
        
        static public void Main(String[] args)
        {

            Character player = new Character();
            GameRunner roller = new GameRunner();

        
            roller.RunGame(player);
            

            
           
        }
        

    }
}