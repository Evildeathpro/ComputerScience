﻿using System;

namespace Ch4_Program8 
{
    class Ch4_Program8 : Colors
    {
        internal const int BARS_PER_CASE = 12;                                   
        //Bars per case
        internal const double STUDENT_ASSOCIATION_TAX = 0.10, CASE_COST = 5.00;  
        //Gov tax % and case cost

        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)                                        //Error looping
            {
                try
                {

                    TaskShortener.Header();
                    
                    int casesSold = TaskShortener.AskUserForInt("number of cases sold");
                    //How many cases were sold?
                    double barCost = TaskShortener.AskUserForDouble("how much each bar costed");
                    //What does a bar cost?

                    GrossCost(casesSold, barCost); //Displays the gross cost
                    ProceedStats(casesSold, barCost); //Displays the proceeds

                    TaskShortener.Footer();
                    break;
                }
                catch (FormatException) //Trying to error it eh?
                {
                    TaskShortener.ErrorCatch();
                }
            }
        }

        public static void GrossCost(int x, double y)
        {
            #region Calculations                                      
            int barsSold = x * BARS_PER_CASE;                                   //Bars sold
            double grossPay = y * barsSold;                                     //Gross pay
            #endregion

            #region Console Display
            MagentaFont();
            //Bar amount
            Console.Write("If each case has ");                                 YellowFont();
            Console.Write("{0} bars", BARS_PER_CASE);                           MagentaFont();

            //Cases amount
            Console.Write(" and there were ");                                  YellowFont();
            Console.Write("{0} cases", x);                                      MagentaFont();

            //Bar cost
            Console.Write(" sold,\nAnd the cost of each bar is ");              YellowFont();
            Console.Write("${0:N2}", y);                                        MagentaFont();

            //Amount of bars
            Console.Write("...\nThen there were ");                             YellowFont();
            Console.Write("{0} bars", barsSold);                                MagentaFont();
            Console.Write(" sold and the\t");                                   LimeFont();

            //Gross proceeds
            Console.Write("GROSS PROCEEDS");                                    MagentaFont();
            Console.Write(" are\t");                                            YellowFont();
            Console.Write("${0:N2}.", grossPay); //Shows the gross cost
            //Color changes to help the user find the value they want!
            #endregion
            
        }

        public static void ProceedStats(int x, double y)
        {
            #region Calculations
            int barsSold = x * BARS_PER_CASE;                                    //Bars sold
            double grossPay = y * barsSold;                                      //Gross pay

            double totalMoneySpentOnCases = x * CASE_COST,                       //Money to buy cases
                governmentCut = grossPay * STUDENT_ASSOCIATION_TAX,              //Governing tax
                grossDeduction = totalMoneySpentOnCases + governmentCut,         //Deductions
                netPay = grossPay - grossDeduction;                              //Final earnings
            #endregion 

            #region Console Display
            //What the club gets
            LimeFont();
            Console.Write("\n\n\t\t\t\t\tCLUB PROCEEDS:\t\t");                  YellowFont();
            Console.Write("${0:N2}", netPay);                                   LimeFont();

            //What the student government gets
            Console.Write("\n\t\t\t\t\tGOVERNMENT CUT:\t\t");                   YellowFont();
            Console.Write("${0:N2}", governmentCut);                            LimeFont();

            //The cost to buy the cases
            Console.Write("\n\t\t\t\t\tINITIAL COST OF CASES:\t");              YellowFont();
            Console.Write("${0:N2}", totalMoneySpentOnCases);
            //Color changes to help the user find the value they want!
            #endregion
        }
    }
}