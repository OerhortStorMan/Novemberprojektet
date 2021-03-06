﻿using System;
using Raylib_cs;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {

int x = 0;
            while (true)
            {
                Console.Clear();
                System.Console.WriteLine(@"
  ____        _ _   ____                                  
 |  _ \      | | | |  _ \                                 
 | |_) | __ _| | | | |_) | ___  _   _ _ __   ___ ___ _ __ 
 |  _ < / _` | | | |  _ < / _ \| | | | '_ \ / __/ _ \ '__|
 | |_) | (_| | | | | |_) | (_) | |_| | | | | (_|  __/ |   
 |____/ \__,_|_|_| |____/ \___/ \__,_|_| |_|\___\___|_|   
                                                          
                                                          
");
                string[] array = new string[]{"Play", "Quit"};
                for (int i = 0; i < x; i++)
                {
                    System.Console.WriteLine(array[i]);
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("--> " + array[x]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = x +1; i < array.Length; i++)
                {
                    System.Console.WriteLine(array[i]);
                }
                ConsoleKeyInfo Ui = Console.ReadKey();

                if (Ui.Key == ConsoleKey.DownArrow && x != array.Length-1|| Ui.Key == ConsoleKey.S && x != array.Length-1)
                {
                    x++;
                }
                else if (Ui.Key == ConsoleKey.UpArrow && x != 0|| Ui.Key == ConsoleKey.W && x != 0)
                {
                    x--;
                }
                else if (Ui.Key == ConsoleKey.Enter)
                {
                    if (x == 0)
                    {
                        Game();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }

        

        }

        public static void Game()
        {
            //WINDOW PROPERTIES
                //Window width
                int windowW = 1280;

                //Window height
                int windowH = 720;

                //Window creation
                Raylib.InitWindow(windowW, windowH, "Ball Bouncer");

                //Background color
                Color backgroundColor = new Color(0, 0, 0, 0);

                //Target FPS
                Raylib.SetTargetFPS(60);

                GameObject rightPaddle = new BouncerBlock((windowW/2), windowH-50, KeyboardKey.KEY_LEFT, KeyboardKey.KEY_RIGHT);

        
            while (!Raylib.WindowShouldClose())
            {
                // if all balls are out then 
                //                 Raylib.WindowShouldClose();

                Raylib.WindowShouldClose();

                Raylib.BeginDrawing();
                
                GameObject.DrawAll();

                Raylib.ClearBackground(backgroundColor);

                Raylib.EndDrawing();


            }

            // if (balls = 0)
            // {
            //     gameover()
            // }
            // else if (bricks left = 0)
            // {
            //     YouWin()
            // }
        
        }

        

        static void GameOver()
        {
System.Console.WriteLine(@"
   _____                                            
  / ____|                                           
 | |  __  __ _ _ __ ___   ___    _____   _____ _ __ 
 | | |_ |/ _` | '_ ` _ \ / _ \  / _ \ \ / / _ \ '__|
 | |__| | (_| | | | | | |  __/ | (_) \ V /  __/ |_  
  \_____|\__,_|_| |_| |_|\___|  \___/ \_/ \___|_(_) 
                                                    
                                                    

");

Console.ReadLine();
Environment.Exit(0);
        }

        static void YouWin()
        {
System.Console.WriteLine(@"
 __     __                    _       _ 
 \ \   / /                   (_)     | |
  \ \_/ /__  _   _  __      ___ _ __ | |
   \   / _ \| | | | \ \ /\ / / | '_ \| |
    | | (_) | |_| |  \ V  V /| | | | |_|
    |_|\___/ \__,_|   \_/\_/ |_|_| |_(_)
                                        
                                        

");

Console.ReadLine();
Environment.Exit(0);

        }
    }
}
