using System;

class Zad_10
{
    public static int OstatniaCyfra(int liczba)
    {
        return liczba % 10;
    }

    public static void WypiszWynik()
    {
        Console.Write("Podaj liczbę naturalną: ");
        int liczba = Convert.ToInt32(Console.ReadLine());

        int ostatniaCyfra = OstatniaCyfra(liczba);

        Console.WriteLine("Ostatnia cyfra liczby {0} to: {1}", liczba, ostatniaCyfra);
    }
}