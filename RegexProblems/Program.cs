﻿using System;
namespace RegexProblems
{
    class program
    {
        public static void Main(string[] args)
        {


            RegExpression regex = new RegExpression();
            Console.WriteLine("Enter Name to check:");
            Console.Write("First Name:");
            string Name = Console.ReadLine();
           // Console.Write("Last Name:");
           // string lastName = Console.ReadLine();
            Console.Write("EMAIL:");
            string email = Console.ReadLine();
            Console.Write("CONTACT:");
            string mobileNumber = Console.ReadLine();
            Console.Write("PASSWORD:");
            string password = Console.ReadLine();
            regex.RegexNameChecker();
           // regex.RegexLastNameChecker();
            regex.RegexEmail();
            regex.RegexMobileNumber();
            regex.RegexPassword();
           /* Console.WriteLine("\nSample emails validation:\n");
            string[] sample = File.ReadAllLines(@"C:\prasanna\prasanna bridgelabzs\RegularPrograms\RegexProblems\SampleMails.txt");
            for (int i = 0; i < sample.Length; i++)
            {
                string ret = regex.RegexSampleMail(sample[i]);
                Console.WriteLine(sample[i] + "  --  " + ret);
            }*/
        }
    }
}