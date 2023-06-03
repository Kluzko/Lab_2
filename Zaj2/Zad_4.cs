using System;

class Zad_4
{
    public static void ObliczUlamek()
    {
        Console.WriteLine("Podaj cztery liczby całkowite:");

        Console.Write("a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("d: ");
        int d = Convert.ToInt32(Console.ReadLine());

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            int x = a * d + b * c;
            int y = b * d;

            Console.WriteLine("Licznik (x): " + x);
            Console.WriteLine("Mianownik (y): " + y);
        }
    }
}