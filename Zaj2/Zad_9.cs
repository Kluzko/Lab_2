using System;

class Zad_9
{
    public static void ZamienMiejscami(ref int a, ref int b, ref int c)
    {
        (a, b, c) = (b, c, a);
    }

    public static void WypiszZamianeMiejscami()
    {
        Console.WriteLine("Podaj trzy liczby:");
        Console.Write("a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Przed zamianą:");
        Console.WriteLine("a: {0}, b: {1}, c: {2}", a, b, c);

        ZamienMiejscami(ref a, ref b, ref c);

        Console.WriteLine("Po zamianie:");
        Console.WriteLine("a: {0}, b: {1}, c: {2}", a, b, c);
    }
}