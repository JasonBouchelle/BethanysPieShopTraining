﻿using System;
namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        public static void ParsingStrings()
        {
            Console.WriteLine("Enter the wage: ");
            string wage = Console.ReadLine();

            //int wageValue = int.Parse(wage);
            int wageValue;
            if (int.TryParse(wage, out wageValue))
                Console.WriteLine("Parsing success: " + wageValue);
            else
                Console.WriteLine("Parsing failed");

            string hireDateString = "12/12/2022";
            DateTime hireDate = DateTime.Parse(hireDateString);
            Console.WriteLine("Parsed date: " + hireDate);

        }
        //public static void UsingStringEquality()
        //{
        //    string name1 = "Bethany";
        //    string name2 = "BETHANY";

        //    Console.WriteLine("Are both names equal? " + (name1 == name2));

        //}
        //public static void ManipulatingStrings()
        //{
        //    string firstName = "Bethany";
        //    string lastName = "Smith";
           
        //    string fullName = firstName + " " + lastName;

        //    if (fullName.Contains("beth") || fullName.Contains("Beth"))
        //    {
        //        Console.WriteLine("It's Bethany!");
        //    }

        //    string subString = fullName.Substring(1, 3);
        //    Console.WriteLine("Characters 2 to 4 of fullName are " + subString);

        //}

        //public static void UsingEscapeCharacters()
        //{
        //    string firstName = "Bethany";
        //    string lastName = "Smith";

        //    string displayName = $"Welcome!\n{firstName}\t{lastName}";
        //    Console.WriteLine(displayName);

        //    string FilePath = @"C:\data\employeelist.xlsx";
        //    string marketingTagLine = "Baking the \"best pies\" ever";

        //}

        //public static void UsingSimpleStrings()
        //{
        //    string firstName = "Bethany";
        //    string lastName = "Smith";
        //    string s;
        //    s = firstName;
        //    var userName = "BethanyS";
        //    userName = userName.ToLower();

        //    userName = string.Empty;
        //    userName = "";//identical to string.Empty;
        //}

        //public static void UsingExpressionBodiedSyntax()
        //{
        //    int amount = 1234;
        //    int months = 12;
        //    int bonus = 500;

        //    int yearlyWageForEmployee1 = CalculateYearlyWageExpressionBodied(monthlyWage, months, bonus);
        //    Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        //}

        //public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus;


        //public static void UsingNamedArguments()
        //{
        //    int amount = 1234;
        //    int months = 12;
        //    int bonus = 500;

        //    int yearlyWageForEmployee1 = CalculateYearlyWageWithNamed(bonus: bonus, numberOfMonthsWorked: months, monthlyWage: amount);
        //    Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        //}

        //public static int CalculateYearlyWageWithNamed(int monthlyWage, int numberOfMonthsWorked, int bonus)
        //{

        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        //    return monthlyWage * numberOfMonthsWorked + bonus;
        //}

        //public static void UsingOptionalParameters()
        //{
        //    int monthlyWage1 = 1234;
        //    int months1 = 12;

        //    int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1);
        //    Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        //}

        //public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        //{

        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        //    return monthlyWage * numberOfMonthsWorked + bonus;
        //}

        //public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        //{
        //    int local = 100;
        //    //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
        //    //return monthlyWage * numberOfMonthsWorked;

        //    if (numberOfMonthsWorked == 12)//let's add a bonus month
        //        return monthlyWage * (numberOfMonthsWorked + 1);

        //    return monthlyWage * numberOfMonthsWorked;
        //}

        //public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        //{
        //    int local = 150;
        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        //    return monthlyWage * numberOfMonthsWorked + bonus;
        //}

        //public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        //{
        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        //    return monthlyWage * numberOfMonthsWorked + bonus;
        //}
    }
}

