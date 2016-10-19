using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        MyMath math = new MyMath();
        public void On()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.Write("Number of players:");
                switch(Console.ReadLine())
                {
                    case "1":
                        RunSinglePlayer();
                        break;

                    case "2":
                        RunTwoPlayer();
                        break;
                }
            }
        }

        public void RunSinglePlayer()
        {
            int playerScore = 0;
            int AIScore = 0;
            while (AIScore < 3 && playerScore < 3)
            {
                int player= GetPlayerChoice();
                int AI= GetAIChoice();
                int winner = CheckWinner(player, AI);
                if (winner == 0)
                {
                    playerScore++;
                    Console.Clear();
                    string choiceOne = GetChoiceString(player);
                    string choiceTwo = GetChoiceString(AI);
                    Console.WriteLine("Player One chose {0}. The AI chose {1}", choiceOne, choiceTwo);
                    Console.WriteLine("You won this round! Your score is now {0}", playerScore);
                    Console.ReadLine();
                }
                else if (winner == 1)
                {
                    AIScore++;
                    Console.Clear();
                    string choiceOne = GetChoiceString(player);
                    string choiceTwo = GetChoiceString(AI);
                    Console.WriteLine("Player One chose {0}. The AI chose {1}", choiceOne, choiceTwo);
                    Console.WriteLine("You LOSE this round! The AI's score is now {0}", AIScore);
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    string choiceOne = GetChoiceString(player);
                    string choiceTwo = GetChoiceString(AI);
                    Console.WriteLine("Player One chose {0} the AI also chose {1}", choiceOne, choiceTwo);
                    Console.WriteLine("There is no winner.");
                    Console.ReadLine();
                }
            }
            if (playerScore == 3)
            {
                Console.Clear();
                Console.WriteLine("You are the ULTIMATE winner!");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You lose. Maybe try easy mode..");
                Console.ReadLine();
            }

        }

        public void RunTwoPlayer()
        {
            int playerOneScore = 0;
            int playerTwoScore = 0;
            while (playerOneScore < 3 && playerTwoScore < 3)
            {
                int playerOne = GetPlayerChoice();
                int playerTwo = GetPlayerChoice();
                int winner = CheckWinner(playerOne, playerTwo);
                if (winner == 0)
                {
                    playerOneScore++;
                    Console.Clear();
                    string choiceOne = GetChoiceString(playerOne);
                    string choiceTwo = GetChoiceString(playerTwo);
                    Console.WriteLine("Player One chose {0}. Player Two chose {1}", choiceOne, choiceTwo);
                    Console.WriteLine("Player One wins this round! Player One's score is now {0}", playerOneScore);
                    Console.ReadLine();
                }
                else if (winner == 1)
                {
                    playerTwoScore++;
                    Console.Clear();
                    string choiceOne = GetChoiceString(playerOne);
                    string choiceTwo = GetChoiceString(playerTwo);
                    Console.WriteLine("Player One chose {0}. Player Two chose {1}", choiceOne, choiceTwo);
                    Console.WriteLine("Player Two wins this round! The Player Two's score is now {0}", playerTwoScore);
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    string choiceOne = GetChoiceString(playerOne);
                    string choiceTwo = GetChoiceString(playerTwo);
                    Console.WriteLine("Player One chose {0}. Player Two also chose {1}", choiceOne, choiceTwo);
                    Console.WriteLine("There is no winner.");
                    Console.ReadLine();
                }
            }
            if (playerOneScore == 3)
            {
                Console.Clear();
                Console.WriteLine("Player One is the ULTIMATE winner! Player Two Loses.");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Player Two is the ULTIMATE winner! Player One Loses.");
                Console.ReadLine();
            }
        }

        public int CheckWinner(int player, int AI)
        {
            if ((player == 0 && AI == 3) || (player == 0 && AI == 2))
            {
                return 0;
            }
            else if ((player == 1 && AI == 0) || (player == 1 && AI == 4))
            {
                return 0;
            }
            else if ((player == 2 && AI == 3) || (player == 2 && AI == 1))
            {
                return 0;
            }
            else if ((player == 3 && AI == 1) || (player == 3 && AI == 4))
            {
                return 0;
            }
            else if ((player == 4 && AI == 0) || (player == 4 && AI == 2))
            {
                return 0;
            }
            else if ((player == 0 && AI == 0) || (player == 1 && AI == 1) || (player == 2 && AI == 2) || (player == 3 && AI == 3) || (player == 4 && AI == 4))
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public string GetChoiceString(int choice)
        {
            switch(choice)
            {
                case 0:
                    return "Rock";

                case 1:
                    return "Paper";

                case 2:
                    return "Scissors";

                case 3:
                    return "Lizard";

                case 4:
                    return "Spock";
            }
            return "Null";
        }

        public int GetPlayerChoice()
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
                        return 0;

                    case "Paper":
                        return 1;

                    case "Scissors":
                        return 2;

                    case "Lizard":
                        return 3;

                    case "Spock":
                        return 4;
                }
            }
            return 5;
        }

        public int GetAIChoice()
        {
            return math.GetRandomInt(0, 4);
        }
    }
}
