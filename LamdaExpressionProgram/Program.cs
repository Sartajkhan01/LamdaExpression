﻿using System;
namespace LambdaExpressionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lambda Expression Program\n========================================");

            List<Person> personlist = new List<Person>();
            personlist.Add(new Person("123654", "Sartaj", "Nagpur", 22));
            personlist.Add(new Person("123656", "Vivek", "Mumbai", 15));
            personlist.Add(new Person("123657", "Siddhant", "Pune", 62));
            personlist.Add(new Person("123659", "Shobhit", "Indore", 20));
            personlist.Add(new Person("123658", "Avinash", "Bhopal", 60));
            personlist.Add(new Person("123678", "Sagar", "Patna", 78));
            personlist.Add(new Person("129668", "Priyanshu", "Noida", 58));
            personlist.Add(new Person("126662", "Ankit", "Bhoma", 48));

        }
    }
}