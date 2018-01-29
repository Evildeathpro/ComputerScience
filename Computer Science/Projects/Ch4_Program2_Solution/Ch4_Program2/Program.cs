﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ch4_Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            MagentaFont();                                           //Magenta coloring
            Console.WriteLine("Would you like to take this survey? (yes/no)\n");
            YellowFont();                                            //Yellow coloring
            string yesOrNo = Convert.ToString(Console.ReadLine());
            string yesOrNoFormatting = yesOrNo.ToLower();

            #region No
            if (yesOrNoFormatting == "no")  //Answer is no
            {
                AnswerIsNo();
            }
            #endregion

            #region No Shortened
            else if (yesOrNoFormatting == "n")  //Answer is no
            {
                AnswerIsNo();
            }
            #endregion

            #region Yes
            else if (yesOrNoFormatting == "yes") //Answer is yes
            {
                QuestionTwo();                                      //Second Question of the survey
                string favoriteSaying = Convert.ToString(Console.ReadLine());
                Loading();                                           //Loading Process
                EndSurveyGivenAnswer();                              //Header and responses
                Console.Write("{0}\n\n", favoriteSaying);
                EndSurvey();                                         //Ending survey message
            }
            #endregion

            #region Yes Shortened
            else if (yesOrNoFormatting == "y") //Answer is yes
            {
                QuestionTwo();                                      //Second Question of the survey
                string favoriteSaying = Convert.ToString(Console.ReadLine());
                Loading();                                           //Loading Process
                EndSurveyGivenAnswer();                              //Header and responses
                Console.Write("{0}\n\n", favoriteSaying);
                EndSurvey();                                         //Ending survey message
            }
            #endregion

            #region Invalid Answer
            else
            {
                AnswerIsInvalid();                                  //Invalid Answer Sequence
            }
            #endregion

        }
        public static void Header()
        {
            CyanFont(); //Sets the color to Cyan
            string name = "Ethan Lawrence";
            //Allows me to type my name in a shorter amount of time
            var date = "\t   " + DateTime.Now;
            //Gives the date and time of when the file was last used
            string period = "\t   Period 4,5,6";
            //Shows what periods the class is from
            string teacher = "\t    Mr. Lynch";
            //Shows my teacher's last name
            string purpose = "\nPurpose: To create a program that uses methods "
                + "variables";
            //Shows the purpose of the current project
            string endheader = "\n************************************************"
                + "********************************\n\n";
            //Ends the header
            Console.WriteLine(name); //Writes my name
            Thread.Sleep(50); //Sustains my name
            Console.Clear(); //Clears my name
            Thread.Sleep(70); //"Loading" time
            Console.WriteLine(name + date);
            //Writes my name and the date w/ the time
            Thread.Sleep(70); //Sustains my name and the date w/ the time
            Console.Clear(); //Clears my name and the date w/ the time
            Thread.Sleep(90); //"Loading" time
            Console.WriteLine(name + date + period);
            //Writes my name, the date w/ the time, and the period
            Thread.Sleep(90); //Sustains my name, the date w/ the time, and the period
            Console.Clear(); //Clears my name, the date w/ the time, and the period
            Thread.Sleep(110); //"Loading" Time
            Console.WriteLine(name + date + period + teacher);
            //Writes my name, the date w/ the time, period, and teacher name
            Thread.Sleep(110); //Sustains my name, the date w/ the time, period, and teacher name
            Console.Clear(); //Clears my name, the date w/ the time, period, and teacher name
            Thread.Sleep(130);
            Console.WriteLine(name + date + period + teacher + purpose);
            //Writes my name, the date w/ the time, period, teacher name, and purpose
            Thread.Sleep(130); //Sustains my name, the date w/ the time, period, teacher name, and purpose
            Console.Clear(); //Clears my name, the date w/ the time, period, teacher name, and purpose
            Thread.Sleep(150); //"Loading" Time
            Console.WriteLine(name + date + period + teacher + purpose + endheader);
            //Writes my name, the date w/ the time, period, teacher name, purpose, and ends the header
            Thread.Sleep(150); //"Loading" Time
            Console.ResetColor(); //Resets the color for non header lines
        }
        public static void Footer()
        {
            CyanFont(); //Color Set to Cyan
            Console.WriteLine("\n\n\nPress any key to continue..."); //Footer
            Console.ResetColor(); //Color Reset of the text
            Console.ReadLine();
        }
        public static void SecondHeader()
        {
            CyanFont(); //Sets the color to Cyan
            string name = "Ethan Lawrence";
            //Allows me to type my name in a shorter amount of time
            var date = "\t   " + DateTime.Now;
            //Gives the date and time of when the file was last used
            string period = "\t   Period 4,5,6";
            //Shows what periods the class is from
            string teacher = "\t    Mr. Lynch";
            //Shows my teacher's last name
            string purpose = "\nPurpose: To create a program that uses methods "
                + "variables";
            //Shows the purpose of the current project
            string endheader = "\n************************************************"
                + "********************************\n\n";
            //Ends the header
            Console.WriteLine(name + date + period + teacher + purpose + endheader);
            //Writes my name, the date w/ the time, period, teacher name, purpose, and ends the header
            Thread.Sleep(150); //"Loading" Time
            Console.ResetColor(); //Resets the color for non header lines
        }
        public static void Loading()
        {
            CyanFont(); //Cyan Coloring
            Console.Write("\n\nLoading Results");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Clear();
        }
        public static void CyanFont()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public static void MagentaFont()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta; 
        }
        public static void YellowFont()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void AnswerIsNo()
        {
            MagentaFont();                                       //Magenta coloring
            Console.WriteLine("\n\nThats just too bad! Have a nice day!");
            Footer();
        }
        public static void AnswerIsInvalid()
        {
            CyanFont();
            Console.WriteLine("\n\nThats an invalid answer! Restart the Program"
                + " and answer correctly to continue!");
            Footer();
        }
        public static void QuestionTwo()
        {
            MagentaFont();                                       //Magenta coloring
            Console.Write("What is your favorite saying?\n");    //Question
            YellowFont();                                        //Yellow coloring
        }
        public static void EndSurvey()
        {
            MagentaFont();                                       //Magenta coloring
            Console.Write("Thank you for taking this survey!");
            Footer();
        }
        public static void EndSurveyGivenAnswer()
        {
            SecondHeader();                                      //Header Reset
            MagentaFont();                                       //Magenta coloring
            Console.WriteLine("You entered your favorite saying as:\n");
            YellowFont();                                        //Yellow coloring
        }
    }
}