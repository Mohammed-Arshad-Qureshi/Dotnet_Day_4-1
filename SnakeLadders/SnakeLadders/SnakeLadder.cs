using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadders
{
    class SnakeLadder
    {
        public void Play()
        {
            int player1=0, player2=0, positionOfPlayer1 = 0, positionOfPlayer2 = 0, end = 101;
            Random r = new Random();
           
            while (true)
            {
                positionOfPlayer1 = r.Next(1,7);
                positionOfPlayer2 = r.Next(1,7);

            }

        }
    }
}
