// Created by: Evgeny
// Created on: Mar 2022
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        //input
        float length;
        float width;
        float height;

        Console.WriteLine("This program finds the area of a pyramid.");
        Console.WriteLine("");

        Console.Write("Enter the length(cm): ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the width(cm): ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height(cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        //process
        double volume = (length * width * height) / 3;

        //output
        Console.WriteLine("");
        Console.WriteLine("The volume is: " + volume.ToString("0.00") + "cm³.");

        Console.WriteLine("\nDone.");
    }
}