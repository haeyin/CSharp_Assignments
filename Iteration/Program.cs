using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 65, 88, 39, 72, 100, 85, 83 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] >= 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //


        //string[] name = { "Jesse", "Clare", "Erik", "Dan" };

        //for (int j = 0; j < name.Length; j++)
        //{
        //    Console.WriteLine(name[j]);
        //    //if (name[j] == "Clare")
        //    //{
        //    //    Console.WriteLine(name[j]);
        //    //}
        //}

        //
        //List<int> testScores = new List<int>();

        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(72);
        //testScores.Add(75);
        //testScores.Add(85);

        //foreach (int score in testScores)
        //{
        //    if (score >= 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}


        //

        List<string> names = new List<string>() { "Jesse", "Clare", "Erik", "Dan" };

        foreach (string name in names)
        {
            Console.WriteLine(name);

        }

        Console.ReadLine();


        //List<int> testScores = new List<int>() { 98, 99, 25, 75, 90 };
        //List<int> passingScores = new List<int>();

        //foreach (int score in testScores)
        //{
        //    if (score >= 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}

        //Console.WriteLine(passingScores.Count);
        Console.ReadLine();

    }
}

