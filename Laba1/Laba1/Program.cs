using System;
using System.Collections.Generic;
using labaLibrary1;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            LanguageLibrary language = new LanguageLibrary();
            Queue<string> patient = new Queue<string>();
            Console.WriteLine("Выберите язык/Select language: 1 - Русский, 2 - English");
            int selectln = int.Parse(Console.ReadLine());
            while(true)
            {
                Console,WriteLine(language.Language(selectln, 1));
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(language.Language(selectln, 2));
                        patient.Enqueue(Console.ReadLine());
                        break;
                    case 2:
                        if
                }
            }
        }
    }
}
