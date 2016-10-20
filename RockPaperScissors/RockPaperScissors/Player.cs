using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        public int score = 0;
        public int choice;
        public string name;

        public virtual void GetChoice()
        {
            bool choiceMade = false;
            while (!choiceMade)
            {
                Console.Clear();
                Console.WriteLine("Choices are Rock, Paper, Scissors, Lizard, and Spock");
                Console.Write("Make your choice:");
                switch (Console.ReadLine())
                {
                    case "Rock":
                        choice = 0;
                        choiceMade = true;
                        break;

                    case "Paper":
                        choice = 1;
                        choiceMade = true;
                        break;

                    case "Scissors":
                        choice = 2;
                        choiceMade = true;
                        break;

                    case "Spock":
                        choice = 3;
                        choiceMade = true;
                        break;

                    case "Lizard":
                        choice = 4;
                        choiceMade = true;
                        break;
                }
            }
        }
    }
}
