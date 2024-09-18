using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyOGame
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            // Setting the window width and height
            Console.WindowWidth = 30;
            Console.WindowHeight = 25;
            // Setting the buffer width and height to the same value.
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            // Hiding the console cursor
            Console.CursorVisible = false;

            

            Game myGame = new Game();
            myGame.RunGame();


            Console.ReadKey(true);

            
        }
    
        
    }

    class Game
    {
        bool GameOver = false;
        int LastFrameSpacePressed = 0;
        int FrameCount = 0;
        int FlappyPositionY;
        int FlappyPositionX;
       
        public void RunGame()
        {
            Console.WriteLine("Game Running");
            //Game loop
            while (GameOver == false)
            {
                HandleInput();
                if(FrameCount - LastFrameSpacePressed <2)
                {
                    FlappyPositionY = FlappyPositionY + 1;
                }
                else 
                {
                    FlappyPositionY = FlappyPositionY - 1;                
                }
                System.Threading.Thread.Sleep(100);
                FrameCount = FrameCount + 1;

            }




        }
        private void HandleInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                LastFrameSpacePressed = FrameCount;
            
           
            }
         


        }
    
    
    
    
    
    }












}
