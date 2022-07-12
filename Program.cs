// See https://aka.ms/new-console-template for more information
using System;
using System.Text.Json;

namespace cse210_DiceRoller
{
    public class Program
    {
        
        static public void Main(String[] args)
        {

            //Create the character and game runner object.
            Character player = new Character();
            GameRunner roller = new GameRunner();

            //Run the game.
            roller.RunGame(player);
            

            
           
        }
        

    }
}