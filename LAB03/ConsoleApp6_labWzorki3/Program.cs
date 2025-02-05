﻿using System;

namespace ConsoleApp6_labWzorki3
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();

        public static void wyswietlZOdbicie(int n)
        {
            if (n < 4) throw new ArgumentException("Zbyt mały rozmiar");

            // PIERWSZA LINIA
            for (int i = 0; i < n; i++)
                Star();
            NewLine();

            // ŚRODEK
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < i; j++)
                    Space();
                StarLn();
            }

            // OSTATNIA LINIA
            for (int i = 0; i < n; i++)
                Star();
        }

        static void Main(string[] args)
        {
            wyswietlZOdbicie(10);
        }
    }
}
