using System;

class Zad_5
{
    public static void WypiszWiekszaLiczbe()
    {
        Console.WriteLine("Podaj dwie liczby:");

        Console.Write("Liczba 1: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Liczba 2: ");
        int y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Większa liczba to: " + (x > y ? x : y));
    }
}