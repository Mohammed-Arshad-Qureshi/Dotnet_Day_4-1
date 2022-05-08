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
            int player1=0, player2=0, positionOfPlayer1 = 0, positionOfPlayer2 = 0, end = 100,count = 0;
            Random r = new Random();
            int ladder1 = 4, ladder2 = 10, ladder3 = 14, ladder4 = 33, ladder5 = 64, ladder6 = 74;
            int snake1 = 40, snake2 = 50, snake3 = 81, snake4 = 90, snake5 = 95;
            while (true)
            {
                
                player1 = r.Next(1,7);
                //player2 = r.Next(1,7);
                count++;
                positionOfPlayer1 = player1 + positionOfPlayer1;
                positionOfPlayer2 = player2 + positionOfPlayer2;
                //-------------------LADDERS-----------------
                //PLAYER ONE
               if(positionOfPlayer1 == ladder1)
                {
                    positionOfPlayer1 = 22;
                }
                if (positionOfPlayer1 == ladder2)
                {
                    positionOfPlayer1 = 29;
                }
                if (positionOfPlayer1 == ladder3)
                {
                    positionOfPlayer1 = 77;
                }
                if (positionOfPlayer1 == ladder4)
                {
                    positionOfPlayer1 = 51;
                }
                if (positionOfPlayer1 == ladder5)
                {
                    positionOfPlayer1 = 82;
                }
                if (positionOfPlayer1 == ladder6)
                {
                    positionOfPlayer1 = 90;
                }
                //PLAYER TWO
                //if (positionOfPlayer2 == ladder1)
                //{
                //    positionOfPlayer2 = 22;
                //}
                //if (positionOfPlayer2 == ladder2)
                //{
                //    positionOfPlayer2 = 29;
                //}
                //if (positionOfPlayer2 == ladder3)
                //{
                //    positionOfPlayer2 = 77;
                //}
                //if (positionOfPlayer2 == ladder4)
                //{
                //    positionOfPlayer2 = 51;
                //}
                //if (positionOfPlayer2 == ladder5)
                //{
                //    positionOfPlayer2 = 82;
                //}
                //if (positionOfPlayer2 == ladder6)
                //{
                //    positionOfPlayer2 = 90;
                //}

                //-------------------SNAKES-------------------------
                //player one
                if(positionOfPlayer1 == snake1)
                {
                    positionOfPlayer1 = 20;
                }
                if(positionOfPlayer1 == snake2)
                {
                    positionOfPlayer1 = 16;
                }
                if(positionOfPlayer1 == snake3)
                {
                    positionOfPlayer1 = 78;
                }
                if(positionOfPlayer1 == snake4)
                {
                    positionOfPlayer1 = 52;
                }
                if (positionOfPlayer1 == snake5)
                {
                    positionOfPlayer1 = 36;
                }
                //PLAYER TWO
                //if (positionOfPlayer2 == snake1)
                //{
                //    positionOfPlayer2 = 20;
                //}
                //if (positionOfPlayer2 == snake2)
                //{
                //    positionOfPlayer2 = 16;
                //}
                //if (positionOfPlayer2 == snake3)
                //{
                //    positionOfPlayer2 = 78;
                //}
                //if (positionOfPlayer2 == snake4)
                //{
                //    positionOfPlayer2 = 52;
                //}
                //if (positionOfPlayer2 == snake5)
                //{
                //    positionOfPlayer2 = 36;
                //}
                if (positionOfPlayer1 > 100)
                {
                    positionOfPlayer1 = positionOfPlayer1 - player1;
                }
                //if(positionOfPlayer2 > 100)
                //{
                //    positionOfPlayer2 = positionOfPlayer2 - player2;
                //}
                if (positionOfPlayer1 < 0)
                {
                    positionOfPlayer1 = 0;
                }
                //if (positionOfPlayer2 < 0)
                //{
                //    positionOfPlayer2 = 0;
                //}
                if (positionOfPlayer1 == 100)
                {
                    Console.WriteLine("Player One Won");
                    break;
                }
                //if(positionOfPlayer2 == 100)
                //{
                //    Console.WriteLine("Player Two Won");
                //    break;
                //}

            }
            Console.WriteLine($"Number of Dice rolled {count}");
            Console.ReadLine();

        }
    }
}
