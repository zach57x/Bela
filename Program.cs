//Author: Bravo Team
//Date: 2/24/22
//Assignment: Team Bela Problem
//Description: Belote Card Game
using System;

namespace TEAM_BELA_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input values
            // Readline for top input with split between values
            // Long variable for number of hands
            // Char variable for dominant suit
            // Int variable to store points in game
            // For loop to calculate entered values
            //Console.WriteLine("Please enter the number of hands with the value of the suit with a space in between, followed by the values of each hand, with one value per line");
            string[] input = Console.ReadLine().ToUpper().Split(" ");
            long hands = Int64.Parse(input[0]);
            char dominant = input[1][0];
            int points = 0;
            for (int i = 0; i < (hands * 4); i++)
            {
                // Readline to read input in an array
                // Char variable for card value
                // Char variable for suit value
                // Switch expression to calculate points
                char[] card = Console.ReadLine().ToUpper().ToCharArray();
                char number = card[0];
                char suit = card[1];
                switch (number)
                {
                    case 'A':
                    points += 11;
                    break;
                    case 'K':
                    points += 4;
                    break;
                    case 'Q':
                    points += 3;
                    break;
                    case 'J':
                        if (suit == dominant)
                        {
                        points += 20;
                        }
                        else
                        {
                        points += 2;
                        }
                    break;
                    case 'T':
                    points += 10;
                    break;
                    case '9':
                        if (suit == dominant)
                        {
                        points += 14;
                        }
                    break;
                }
            }
            // Writeline to return calculated value
            Console.WriteLine(points);
        }
    }
}