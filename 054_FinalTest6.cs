using System;

namespace _054_FinalTest6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = new string[5] { "", "", "", "", "" };
            Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
            Console.WriteLine("[0] Show all recent files");
            Console.WriteLine("[1] Open new file");
            Console.WriteLine("[2] Open recent file");
            Console.WriteLine("[3] Exit");
            int order = int.Parse(Console.ReadLine());
            while (order < 0 || order > 3)
            {
                Console.WriteLine("Invalid menu number.");
                Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
                Console.WriteLine("[0] Show all recent files");
                Console.WriteLine("[1] Open new file");
                Console.WriteLine("[2] Open recent file");
                Console.WriteLine("[3] Exit");
                order = int.Parse(Console.ReadLine());
            }
            while (order != 3)
            {
                if (order == 0)
                {
                    Console.WriteLine("[0] " + files[0]);
                    Console.WriteLine("[1] " + files[1]);
                    Console.WriteLine("[2] " + files[2]);
                    Console.WriteLine("[3] " + files[3]);
                    Console.WriteLine("[4] " + files[4]);
                }
                else if (order == 1)
                {
                    string name = Console.ReadLine();
                    files[4] = files[3];
                    files[3] = files[2];
                    files[2] = files[1];
                    files[1] = files[0];
                    files[0] = name;
                }
                else if (order == 2)
                {
                    int newOrder = int.Parse(Console.ReadLine());
                    if (files[newOrder] == "")
                    {
                        Console.WriteLine("No recent file.");
                    }
                    else
                    {
                        string recent = files[newOrder];
                        files[4] = files[3];
                        files[3] = files[2];
                        files[2] = files[1];
                        files[1] = files[0];
                        files[0] = recent;
                    }
                }

                Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
                Console.WriteLine("[0] Show all recent files");
                Console.WriteLine("[1] Open new file");
                Console.WriteLine("[2] Open recent file");
                Console.WriteLine("[3] Exit");
                order = int.Parse(Console.ReadLine());
                while (order < 0 || order > 3)
                {
                    Console.WriteLine("Invalid menu number.");
                    Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
                    Console.WriteLine("[0] Show all recent files");
                    Console.WriteLine("[1] Open new file");
                    Console.WriteLine("[2] Open recent file");
                    Console.WriteLine("[3] Exit");
                    order = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
