﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            LinqQueryOverInts();
            WhileLoopExample();
            DoWhileLoopExample();
            IfElseExample();
            ExecuteIfElseUsingConditionalOperator();
            SwitchExample();
            SwitchOnStringExample();

        }

        static void ForLoopExample()
        {
            //Note! "i" is only visible within the scope of the for lop.
            for(int i = 0;i<4;i++)
            {
                Console.WriteLine("Number is {0}", i);
            }
            //i is not visible here.
        }

        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            {
                Console.WriteLine(c);
            }
            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            //LINQ query!
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in subset: ");
            foreach(var i in subset)
            {
                Console.Write("{0}", i);
            }
        }

        static void WhileLoopExample()
        {
            string userIsDone = "";

            //Test on a lower-class copy of the string.
            while(userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }

        static void DoWhileLoopExample()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes");//not the semicolon!
        }

        static void IfElseExample()
        {
            //This is legal, as this resolves to either true or false.
            string stringData = "My textual data";
            if (stringData.Length > 0)
            {
                Console.WriteLine("string is greater that 0 characters");
            }
            else
            {
                Console.WriteLine("string is not greater than 0 characters");
            }
        }

        static void ExecuteIfElseUsingConditionalOperator()
        {
            string stringData = "My textual data";
            Console.WriteLine(stringData.Length > 0 ? "string is greater than 0 characters" : "string is not greater than 0 characters");
            Console.WriteLine();
        }

        static void SwitchExample()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.WriteLine("Please pick your language preference: ");

            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, Multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
        }

        static void SwitchOnStringExample()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice");
                    break;
                case "VB":
                    Console.WriteLine("Iffy choice:");
                    break;
                default:
                    Console.WriteLine("Well... good luck!");
                    break;

            }
        }

        static void SwitchOnEnumExample()
        {
            Console.Write("Enter your favorite day of the week: ");
            DayOfWeek favDay;

            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }

            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Boo");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("hump day");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("pizza day");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("weekend is coming");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("day off");
                    break;
            }
        }

        static void SwitchWithGoto()
        {

        }
    }
}
