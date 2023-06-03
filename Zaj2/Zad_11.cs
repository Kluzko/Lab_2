using System;

class Zad_11
{
    public static double ObliczFunkcje(double x)
    {
        if (x <= -2)
        {
            return -1;
        }
        else if (x > -2 && x <= -1)
        {
            return x + 1;
        }
        else if (x > -1 && x <= 1)
        {
            return 0;
        }
        else if (x > 1 && x <= 2)
        {
            return x - 1;
        }
        else
        {
            return 1;
        }
    }

    public static void WypiszWartosc()
    {
        Console.Write("Podaj wartość x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double wynik = ObliczFunkcje(x);

        Console.WriteLine("f({0}) = {1}", x, wynik);
    }
}