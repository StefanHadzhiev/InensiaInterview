using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Inensia
{
    public class Program
    {
        static void Main(string[] args)
        { 
            string filePath = @"D:\Docs\Programming\Zadachi\InensiaInterview\inputfiles\input.txt";

            if (File.Exists(filePath))
            {
                var movieStars = JsonConvert.DeserializeObject<List<MovieStar>>(File.ReadAllText(filePath));

                foreach (var movieStar in movieStars)
                {
                    Console.WriteLine($"{movieStar.Name} {movieStar.Surname}");
                    Console.WriteLine($"{movieStar.Sex}");
                    Console.WriteLine($"{movieStar.Nationality.ToLower()}");
                    Console.WriteLine($"{movieStar.Age} years old");
                    Console.WriteLine();

                }
            }

        }
    }
}
