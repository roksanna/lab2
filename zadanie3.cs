using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj rozmiar macierzy (n x n): ");
        int n = int.Parse(Console.ReadLine());
        
        int[,] macierz1 = WygenerujMacierz(n);
        int[,] macierz2 = WygenerujMacierz(n);
        
        Console.WriteLine("\nMacierz 1:");
        WyswietlMacierz(macierz1);
        Console.WriteLine("\nMacierz 2:");
        WyswietlMacierz(macierz2);

        // Dodawanie macierzy
        int[,] suma = DodajMacierze(macierz1, macierz2, n);
        Console.WriteLine("\nSuma macierzy:");
        WyswietlMacierz(suma);

        // Odejmowanie macierzy
        int[,] roznica = OdejmijMacierze(macierz1, macierz2, n);
        Console.WriteLine("\nRóżnica macierzy:");
        WyswietlMacierz(roznica);

        // Mnożenie macierzy
        int[,] iloczyn = MnozMacierze(macierz1, macierz2, n);
        Console.WriteLine("\nIloczyn macierzy:");
        WyswietlMacierz(iloczyn);
    }

    // Funkcja do generowania macierzy wypełnionej losowymi wartościami z zakresu -10 do 10
    static int[,] WygenerujMacierz(int n)
    {
        Random random = new Random();
        int[,] macierz = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                macierz[i, j] = random.Next(-10, 11); 
            }
        }
        return macierz;
    }
    
    static void WyswietlMacierz(int[,] macierz)
    {
        int n = macierz.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(macierz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Funkcja do dodawania macierzy
    static int[,] DodajMacierze(int[,] macierz1, int[,] macierz2, int n)
    {
        int[,] wynik = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                wynik[i, j] = macierz1[i, j] + macierz2[i, j];
            }
        }
        return wynik;
    }

    // Funkcja do odejmowania macierzy
    static int[,] OdejmijMacierze(int[,] macierz1, int[,] macierz2, int n)
    {
        int[,] wynik = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                wynik[i, j] = macierz1[i, j] - macierz2[i, j];
            }
        }
        return wynik;
    }

    // Funkcja do mnożenia macierzy
    static int[,] MnozMacierze(int[,] macierz1, int[,] macierz2, int n)
    {
        int[,] wynik = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    wynik[i, j] += macierz1[i, k] * macierz2[k, j];
                }
            }
        }
        return wynik;
    }
}
