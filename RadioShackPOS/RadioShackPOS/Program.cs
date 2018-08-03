﻿using System;
using POS.Library;

namespace RadioShackPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Radioshack");
            Menu.DisplayMainMenu();
            System.Console.WriteLine("put in some test input");
            var answer = Console.ReadLine();
            var validator = new Validator();
            if (validator.ValidExpDate(answer))
            {
                Console.WriteLine("valid");
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            ////////// TESTING - MIKE ///////////////////////////
            // CASH METHOD IS HERE IF YOU WANT TO TEST IT
            //var cash = new Cash();
            //var cashTransaction = cash.Transaction();
            //Console.WriteLine(cashTransaction);
            // CREDIT CARD METHOD IS HERE IF YOU WANT TO TEST IT
            //var creditCard = new CreditCard();
            //var ccTransaction = creditCard.Transaction();
            //Console.WriteLine(ccTransaction);
            // CHECK METHOD IS HERE IF YOU WANT TO TEST IT
            //var check = new Check();
            //var checkTransaction = check.Transaction();
            //Console.WriteLine(checkTransaction);
            //Console.ReadKey();
            /////////////// END TESTING //////////////////////////
        }
    }
}
