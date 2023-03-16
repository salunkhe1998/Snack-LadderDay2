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
            int position = 0;
            int Player1;

            Player1 = position;
            Console.WriteLine($"Player 1 Position is {Player1}");

            Random random = new Random();
            int dice = random.Next(6);
            Console.WriteLine($"player One rolls die and get position : {dice} ");

        }
    }
}
