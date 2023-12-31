using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearFireworks
{
    class Firework
    {
        private readonly int startPosX;
        private readonly int startPosY;
        public int ColorNum { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int DenoteY { get; set; }
        public int[,] Board { get; }
        public Firework(int[,] board, int StartPosX, int StartPosY, int color)
        {
            Board = board;
            startPosX = StartPosX;
            startPosY = StartPosY;
            ColorNum = color;
            PositionX = StartPosX;
            PositionY = StartPosY;
            Random random = new Random();
            DenoteY = random.Next(5, 15);
        }
        public void Explode()
        {
            //Exploding
            /*
               ↖ ↑ ↗
             ← ← O → →
               ↙ ↓ ↘
            3 -> Center
            4 - > UpArrow
            5-> LeftUpArrow
            6 -> RightUpArrow
            7 -> LeftArrow
            8 -> RightArrow
            9 -> DownArrow
            10 -> LeftDownArrow
            11 -> RightDownArrow
            */
            //First layer
            Board[PositionY, PositionX] = 3 + ColorNum; //Center

            Board[PositionY - 2, PositionX] = 4 + ColorNum; //UpArrow
            Board[PositionY - 2, PositionX - 2] = 5 + ColorNum; //UpLeftArrow
            Board[PositionY - 2, PositionX + 2] = 6 + ColorNum; //UpRightArrow

            Board[PositionY, PositionX - 2] = 7 + ColorNum; //LeftArrow 
            Board[PositionY, PositionX + 2] = 8 + ColorNum; //Rightrrow

            Board[PositionY + 2, PositionX] = 9 + ColorNum; //DownArrow
            Board[PositionY + 2, PositionX - 2] = 10 + ColorNum; //DownLeftArrow
            Board[PositionY + 2, PositionX + 2] = 11 + ColorNum; //DownRightArrow
            Thread.Sleep(500);
            //Second layer
            Board[PositionY - 4, PositionX] = 4 + ColorNum; //UpArrow
            Board[PositionY - 4, PositionX - 4] = 5 + ColorNum; //UpLeftArrow
            Board[PositionY - 4, PositionX + 4] = 6 + ColorNum; //UpRightArrow

            Board[PositionY, PositionX - 4] = 7 + ColorNum; //LeftArrow
            Board[PositionY, PositionX + 4] = 8 + ColorNum; //RightArrow

            Board[PositionY + 4, PositionX] = 9 + ColorNum; //DownArrow
            Board[PositionY + 4, PositionX - 4] = 10 + ColorNum; //DownLeftArrow
            Board[PositionY + 4, PositionX + 4] = 11 + ColorNum; //DownRightArrow
            Thread.Sleep(500);
            //Final
            Board[PositionY, PositionX] = 0; //Center

            Board[PositionY - 2, PositionX] = 0; //UpArrow
            Board[PositionY - 2, PositionX - 2] = 0; //UpLeftArrow
            Board[PositionY - 2, PositionX + 2] = 0; //UpRightArrow

            Board[PositionY - 4, PositionX] = 0; //UpArrow2
            Board[PositionY - 4, PositionX - 4] = 0; //UpLeftArrow2
            Board[PositionY - 4, PositionX + 4] = 0; //UpRightArrow2

            Board[PositionY, PositionX - 2] = 0; //LeftArrow 
            Board[PositionY, PositionX - 4] = 0; //LeftArrow
            Board[PositionY, PositionX + 2] = 0; //Rightrrow
            Board[PositionY, PositionX + 4] = 0; //RightArrow

            Board[PositionY + 2, PositionX] = 0; //DownArrow
            Board[PositionY + 2, PositionX - 2] = 0; //DownLeftArrow
            Board[PositionY + 2, PositionX + 2] = 0; //DownRightArrow

            Board[PositionY + 4, PositionX] = 0; //DownArrow2
            Board[PositionY + 4, PositionX - 4] = 0; //DownLeftArrow2
            Board[PositionY + 4, PositionX + 4] = 0; //DownRightArrow2
        }
        public void Fire()
        {
            Board[PositionY, PositionX] = 2 + ColorNum;
            Board[PositionY--, PositionX] = 1 + ColorNum;
            while (PositionY >= DenoteY)
            {
                //Board[PositionY-=2, PositionX] = 0;
                Board[PositionY + 1, PositionX] = 0;
                Board[PositionY, PositionX] = 0;
                PositionY--;
                Board[PositionY, PositionX] = 2 + ColorNum;
                Board[PositionY + 1, PositionX] = 1 + ColorNum;
                Thread.Sleep(500);
            }
            Board[PositionY, PositionX] = 3 + ColorNum;
            Board[PositionY + 1, PositionX] = 0;
            Thread explode = new Thread(() => {
                Explode();
            });
            explode.Start();
        }
        public void BeginFiring()
        {
            Thread firing = new Thread(() => {
                Fire();
            });
            firing.Start();
        }
    }
}

