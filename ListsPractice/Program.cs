using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////example list
            //List<int> favNumbers = new List<int>();
            ////can add to list with built Add method
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach(int number in favNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            ////Use the count property to get the length of the list
            //Console.WriteLine(favNumbers.Count());

            ////string list
            ////when you know contents use curly brackets instead of parenthesis
            //List<string> books = new List<string> { "Cat in the Hat", "Toad and Frog", "Green Eggs and Ham" };
            ////insert method inserts new element at index indicated moving the previous element down one
            //Console.WriteLine(books[0]);
            //books.Insert(0, "Horton Hears a Who");
            //Console.WriteLine(books[0]);

            ////Create a List and add 5 animals using the .Add() 
            ////Print each animal in the list
            //List<string> animals = new List<string>();
            //animals.Add("dog");
            //animals.Add("frog");
            //animals.Add("zebra");
            //animals.Add("lion");
            //animals.Add("fox");
            //foreach(string animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}

            ////Create the following List: 
            ////a bool list {true, false, false, true, false}
            ////loop through each value
            ////if the value is true print "Better bring an umbrella"
            ////if the value is false print "No rain today enjoy the sun"
            //List<bool> rain = new List<bool> { true, false, false, true, false };
            //foreach (bool thing in rain)
            //{
            //    if(thing == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today enjoy the sun");
            //    }
            //}

            //Contains
            List<string> faveFoods = new List<string>() { "Steak", "fish", "katsudon", "Ice cream", "nachos" };
            if(faveFoods.Contains("Steak"))
            {
                Console.WriteLine("I like steak");
            }
          
        }
    }
}
