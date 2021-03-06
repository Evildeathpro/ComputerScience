﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Flag_Program
{
    class Flags : TaskShortener
    {
        private static string spacingOne = "                           ",  spacingTwo = "\n                                               ", 
            starTwo = "\n  *   *   *    *  * ",  starOne = "\n*  *   *   *  *  *  ";
        static void Main(string[] args)
        {
            #region Threads
            Thread tid1 = new Thread(new ThreadStart(MarioSong));
            tid1.Start(); //Runs a song while you run the program.
            #endregion
            for (int i = 0; i < 1; i++)                                  //Error looping
            {
                try
                {
                    Header();
                    #region Important Code
                    // Since the description is to make a flag from google, I decided to go with the american flag.
                    for (int f = 3; f > 0; f--)
                    {
                        BlueColor(starOne);
                        RedColor(spacingOne);
                        BlueColor(starTwo);
                        WhiteColor(spacingOne);
                        if (f == 1)
                        {
                            BlueColor(starOne);
                            RedColor(spacingOne);
                            for (f = 3;  f != 0; f--)
                            {
                                WhiteColor(spacingTwo);
                                RedColor(spacingTwo);
                            }
                        }
                    }

                    
                    #endregion
                    Footer();
                }
                #region Catch
                catch (FormatException) //Trying to error it eh?
                {
                    Thread.Sleep(300);
                    Console.Clear();
                    ErrorFont(); //Red!
                    TypeLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\tTry again Knucklehead.");
                    //Try again buddy. Do not be a knucklehead.
                    Thread.Sleep(500); //Oh yes. You must wait to return you knucklehead.
                    Console.Clear();
                }
                #endregion
            }
        }

        private static void WhiteColor(string x)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(x);

        }
        private static void RedColor(string x)
        {
            darkRed();
            Console.Write(x);
        }
        private static void BlueColor(string x) {
            darkBlue();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(x);
        }


    }
}
