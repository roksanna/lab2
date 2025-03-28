using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę wierszy macierzy: ");
        int wiersze = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę kolumn macierzy: ");
        int kolumny = int.Parse(Console.ReadLine());
        int[,] macierz1 = WygenerujMacierz(wiersze, kolumny);
        int[,] macierz2 = WygenerujMacierz(wiersze, kolumny);

        // Wyświetlanie macierzy
        Console.WriteLine("\nMacierz 1:");
        WyswietlMacierz(macierz1);
        Console.WriteLine("\nMacierz 2:");
        WyswietlMacierz(macierz2);

        // Dodawanie macierzy
        int[,] suma = DodajMacierze(macierz1, macierz2, wiersze, kolumny);
        Console.WriteLine("\nSuma macierzy:");
        WyswietlMacierz(suma);
    }

    // Funkcja do generowania macierzy wypełnionej losowymi wartościami z zakresu -10 do 10
    static int[,] WygenerujMacierz(int wiersze, int kolumny)
    {
        Random random = new Random();
        int[,] macierz = new int[wiersze, kolumny];
        for (int i = 0; i < wiersze; i++)
        {
            for (int j = 0; j < kolumny; j++)
            {
                macierz[i, j] = random.Next(-10, 11); 
            }
        }
        return macierz;
    }
    
    static void WyswietlMacierz(int[,] macierz)
    {
        int wiersze = macierz.GetLength(0);
        int kolumny = macierz.GetLength(1);
        for (int i = 0; i < wiersze; i++)
        {
            for (int j = 0; j < kolumny; j++)
            {
                Console.Write(macierz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Funkcja do dodawania dwóch macierzy
    static int[,] DodajMacierze(int[,] macierz1, int[,] macierz2, int wiersze, int kolumny)
    {
        int[,] wynik = new int[wiersze, kolumny];
        for (int i = 0; i < wiersze; i++)
        {
            for (int j = 0; j < kolumny; j++)
            {
                wynik[i, j] = macierz1[i, j] + macierz2[i, j];
            }
        }
        return wynik;
    }
}
