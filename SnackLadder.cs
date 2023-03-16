using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackandLadderDay2
{
    public class SnakeLadder

    {

        public static void StartGame()
        {

            int num;
            int select_option;
            int START_POSITION = 0;
            int END_POSITION = 100;
            int NO_PLAY_OPTION = 0;
            int LADDER_OPTION = 1;
            int SNAKE_OPTION = 2;

            //Variables
            int playerPosition = 0;
            int previousPlayerPosition = 0;
            int updatedPlayerPosition = 0;
            int countDiceRoll = 0;
            int playerOnePosition = 0;
            int playerTwoPosition = 0;


            void rollDice()
            {
                countDiceRoll = (countDiceRoll + 1);
                Random random = new Random();
                num = random.Next(6);
                option();
            }


            void option()
            {
                Random R = new Random();
                select_option = R.Next(3);

                if (select_option == NO_PLAY_OPTION)
                {
                    noPlay();
                }
                else if (select_option == LADDER_OPTION)
                {
                    ladder();
                }
                else
                {
                    snake();
                }
            }

            void noPlay()
            {
                playerPosition = previousPlayerPosition;
            }

            void ladder()
            {
                updatedPlayerPosition = (previousPlayerPosition + num);
                if (updatedPlayerPosition > END_POSITION)
                {
                    playerPosition = previousPlayerPosition;
                }
                else if (updatedPlayerPosition == END_POSITION)
                {
                    playerPosition = END_POSITION;
                }
                else
                {
                    playerPosition = updatedPlayerPosition;
                }

                previousPlayerPosition = playerPosition;
            }

            void snake()
            {
                updatedPlayerPosition = (previousPlayerPosition - num);
                if (updatedPlayerPosition < START_POSITION)
                {
                    playerPosition = START_POSITION;
                }
                else
                {
                    playerPosition = updatedPlayerPosition;
                }

                previousPlayerPosition = playerPosition;
            }

            void playerOne()
            {
                rollDice();
            }

            void playerTwo()
            {
                rollDice();
            }

            while (playerPosition >= START_POSITION && playerPosition < END_POSITION)
            {
                playerOne();
                if (select_option == LADDER_OPTION)
                {
                    playerOne();
                }
                playerOnePosition = playerPosition;
                playerPosition = playerTwoPosition;
                Console.WriteLine("Player One,Position After Every Roll Dice :-  " + playerOnePosition);
                if (playerOnePosition == END_POSITION)
                {
                    Console.WriteLine(".........*** Player One Win ***........");
                    break;
                }
                playerTwo();
                playerTwoPosition = playerPosition;
                playerPosition = playerOnePosition;
                Console.WriteLine("Player Two,Position After Every Roll Dice :-  " + playerTwoPosition);
                if (playerTwoPosition == END_POSITION)
                {
                    Console.WriteLine(".........*** Player Two Win ***........");
                    break;
                }
            }
            Console.WriteLine("Total Number Of Dice Roll :- " + countDiceRoll);
        }
    }
}



