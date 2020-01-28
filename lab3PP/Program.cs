using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using static lab3PP.FindElem;

namespace lab3PP
{
    class Program
    {
        public const string filePath1 = @"C:\Users\Fandorin\Desktop\lab2\lab3PP\lab3PP\testData\file1.txt";
        public const string filePath2 = @"C:\Users\Fandorin\Desktop\lab2\lab3PP\lab3PP\testData\file2.txt";
        public const string resTask1 = @"C:\Users\Fandorin\Desktop\lab2\lab3PP\lab3PP\res\task1.txt";
        public const string resTask2 = @"C:\Users\Fandorin\Desktop\lab2\lab3PP\lab3PP\res\task2.txt";
        public const string resTask3 = @"C:\Users\Fandorin\Desktop\lab2\lab3PP\lab3PP\res\task3.txt";

        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();



            //#1
            timer.Start();
            Task1 task1 = new Task1();
            timer.Stop();
            Console.WriteLine($"Time of {nameof(Task1)}: " + timer.ElapsedMilliseconds);

            //#2
            timer.Restart();
            Task2 task2 = new Task2();
            timer.Stop();
            Console.WriteLine($"Time of {nameof(Task2)}: " + timer.ElapsedMilliseconds);








            Console.ReadKey();
        }
    }
}
