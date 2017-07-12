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

            //Contains method
            //List<string> faveFoods = new List<string>() { "Steak", "fish", "katsudon", "Ice cream", "nachos" };
            //if(faveFoods.Contains("Steak"))
            //{
            //    Console.WriteLine("I like steak");
            //}

            //Create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5 
            //use the contains method with the following values: 23 77 15
            //remove these elements: 22 77 32 and 6
            //use Contains() again on these values: 23 77 15
            //List<int> numbers = new List<int>() { 1, 23, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //if (numbers.Contains(23))
            //{
            //    Console.WriteLine("The list contains 23");
            //}
            //else
            //{
            //    Console.WriteLine("The list does not contain 23");
            //}
            //if (numbers.Contains(77))
            //{
            //    Console.WriteLine("The list contains 77");
            //}
            //else
            //{
            //    Console.WriteLine("The list does not contain 77");
            //}
            //if (numbers.Contains(15))
            //{
            //    Console.WriteLine("The list contains 15");
            //}
            //else
            //{
            //    Console.WriteLine("The list does not contain 15");
            //}
            ////only removes the first one
            //numbers.Remove(23);
            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);
            //if (numbers.Contains(23))
            //{
            //    Console.WriteLine("The list contains 23");
            //}
            //else
            //{
            //    Console.WriteLine("The list does not contain 23");
            //}
            //if (numbers.Contains(77))
            //{
            //    Console.WriteLine("The list contains 77");
            //}
            //else
            //{
            //    Console.WriteLine("The list does not contain 77");
            //}
            //if (numbers.Contains(15))
            //{
            //    Console.WriteLine("The list contains 15");
            //}
            //else
            //{
            //    Console.WriteLine("The list does not contain 15");

            //}

            //Ask the user for a movie 
            //if the movie is not in the list add it 
            //inform the user that the movie has been added 
            //if the movie is in the list inform the movie that the movie is on the list
            //if the user enters quit the program should exit
            //the user should be able to add as many movies as they want

            List<string> movies = new List<string>();
            string newMovie;
            do
            {
                Console.WriteLine("Enter the movie you would like to order");
                newMovie = Console.ReadLine();
                if(newMovie.ToLower() == "quit")
                {
                    continue;
                }
                else if (movies.Contains(newMovie))
                {
                    Console.WriteLine(newMovie + " is on the list");
                }
                else
                {
                    movies.Add(newMovie);
                    Console.WriteLine(newMovie + " has been added to the list.");
                }
            }
            while (newMovie.ToLower() != "quit");
            Console.WriteLine("Thank you for ordering. Below is the current list of movies:");
            foreach (string currentMovie in movies)
            {
                Console.WriteLine(currentMovie);
            }
        }
    }
}
