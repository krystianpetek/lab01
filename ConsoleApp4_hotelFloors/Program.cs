﻿using System;

namespace ConsoleApp4_hotelFloors
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = int.Parse(Console.ReadLine());
            for (int i = 0; i < ilosc; i++)
            {
                string[] linia = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                int M = Convert.ToInt32(linia[0]);
                int N = Convert.ToInt32(linia[1]);

                char[,] rzutGora = new char[M,N];

                // PRZYPISZ
                for (int x = 0; x < rzutGora.GetLength(0);x++)
                {
                    string wejscie = Console.ReadLine();
                    for(int y = 0;y<rzutGora.GetLength(1);y++)
                    {
                        if (wejscie[y] != '#' && wejscie[y] != '-' && wejscie[y] != '*')
                            throw new ArgumentException("Błędne dane");

                        rzutGora[x, y] = wejscie[y];
                        
                    }
                }

                int liczbaOsob = 0;

                for (int a = 1; a < rzutGora.GetLength(0) - 1; a++)
                    for (int b = 1; b < rzutGora.GetLength(1) - 1; b++)
                    {
                        if (rzutGora[a, b] == '*')
                            liczbaOsob++;
                    }


                int pomieszczenie = 0;
                for (int a = 1; a < rzutGora.GetLength(0) - 1; a++)
                {
                    for (int b = 1; b < rzutGora.GetLength(1)-1; b++)
                    {
                        char znakAktualny = rzutGora[a, b];
                        char znakDol = rzutGora[a + 1, b];
                        Console.WriteLine(a + " " + b);
                        if (znakAktualny == '*' || znakAktualny == '-')
                        {
                            if (znakDol == '*' || znakDol == '-')
                            {

                                a++;
                                break;
                            }
                            else {
                                
                            }
                        }
                        else if(znakAktualny == '#' && znakAktualny-1 == '#')
                        {
                            continue;
                        }
                        else
                        {
                            pomieszczenie++;
                        }

                    }
                    Console.WriteLine("pomieszczeń" + pomieszczenie);
                }

                Console.WriteLine("liczbaOsob" + liczbaOsob);
                double oblicz = (double)liczbaOsob / (double)pomieszczenie;
                Console.WriteLine(oblicz);
                //// WYPISZ
                //for(int iter = 0;iter<M;iter++)
                //    for(int iter2 = 0;iter2<N;iter2++)
                //    {
                //        Console.Write(rzutGora[iter,iter2]);
                //        if(iter2 == N-1)
                //            Console.WriteLine();
                //    }
            }
        }
    }
}
