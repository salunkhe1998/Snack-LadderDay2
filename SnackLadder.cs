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
            int Player_Position = 0;
            int Previous_Player_Position = 0;
            int Next_Player_Position = 0;
            int Start_Position = 0;
            int End_Position = 100;
            int RanNum;

            void RollDie()
            {
                Random random = new Random();
                RanNum = random.Next(6);

                Choose_Option();
            }

            void Choose_Option()
            {
                int Option_One_NoPlay = 0;
                int Option_Two_Ladder = 1;
                int Option_Three_Snake = 2;

                Random ran = new Random();
                int Choose_Option = ran.Next(3);

                if (Choose_Option == Option_One_NoPlay)
                {
                    Player_Position = Previous_Player_Position;

                    RollDie();
                }

                else if (Choose_Option == Option_Two_Ladder)
                {
                    Next_Player_Position = (Previous_Player_Position + RanNum);
                }
                else
                {
                    Next_Player_Position = (Previous_Player_Position - RanNum);
                }
            }

            while (Player_Position >= Start_Position && Player_Position <= End_Position)
            {
                RollDie();
            }

        }



    }


}




