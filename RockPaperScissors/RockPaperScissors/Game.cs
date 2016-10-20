using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        MyMath math;
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
                        playerOne = new Human("Player One");
                        playerTwo = new AI("Player Two");
                        StartGame();
                        break;

                    case "2":
                        playerOne = new Human("Player One");
                        playerTwo = new Human("Player Two");
                        StartGame();
                        break;
                }
            }
        }

        public void StartGame()
        {
            while(CheckIfWinnerExists())
            {
                playerOne.GetChoice();
                playerTwo.GetChoice();
                if (CheckTie())
                {
                    ShowTieMessage();
                }
                else if (!CheckPlayerOneWins())
                {
                    playerTwo.score++;
                    ShowRoundWinner(playerTwo);
                }
                else
                {
                    playerOne.score++;
                    ShowRoundWinner(playerOne);
                }
            }
            ShowWinningMessage();
        }

        public void ShowTieMessage()
        {
            string choiceOne = GetChoiceString(playerOne.choice);
            string choiceTwo = GetChoiceString(playerTwo.choice);
            Console.WriteLine("Player One chose {0} Player Two also chose {1}", choiceOne, choiceTwo);
            Console.WriteLine("There is no winner.");
            Console.ReadLine();
        }

        public void ShowRoundWinner(Player winner)
        {
            Console.Clear();
            string choiceOne = GetChoiceString(playerOne.choice);
            string choiceTwo = GetChoiceString(playerTwo.choice);
            Console.WriteLine("Player One chose {0}. Player Two chose {1}", choiceOne, choiceTwo);
            Console.WriteLine("{0} wins this round! {0}'s score is now {1}",winner.name, winner.score);
            Console.ReadLine();
        }

        public void ShowWinningMessage()
        {
            if (playerOne.score < 2)
            {
                Console.WriteLine("Player Two Wins!");
            }
            else
            {
                Console.WriteLine("Player One Wins!");
            }
            Console.ReadLine();
        }

        public bool CheckIfWinnerExists()
        {
                return (playerOne.score < 2 && playerTwo.score < 2);
        }

        public bool CheckTie()
        {
            return (playerOne.choice == playerTwo.choice);
        }

        public bool CheckPlayerOneWins()
        {
            int winner = ((5 + playerOne.choice - playerTwo.choice) % 5);
            if (winner % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
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
                    return "Spock";

                case 4:
                    return "Lizard";
            }
            return "Null";
        }
    }
}
