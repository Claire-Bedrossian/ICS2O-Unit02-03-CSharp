// Created by: Claire Bedrossian
// Created on: Oct 2022
//
// This program calculates the perimeter and area of a rectangle

// Created by: Mr Coxall
// Created on: Sep 2020
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        string streetName;
        int streetNumber;

        Console.WriteLine("This program gets a user's address.");
        Console.WriteLine("");

        Console.Write("Enter your street name: ");
        streetName = Console.ReadLine();
        Console.Write("Enter your house number: ");
        streetNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your info is: " + streetNumber + " " + streetName + ".");

        Console.WriteLine("\nDone.");
    }
}