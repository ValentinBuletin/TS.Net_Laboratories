using System;
using System.Threading;
/*
1. Sa se construiasca un tip (clasa) ce expune un eveniment. Scrieti codul ce exemplifca folosirea
acestui tip.
2. Determinati cel mai mare numar prim mai mic decat un numar natural dat. Identificati cel putin
doua metode (doi algoritmi). Fiecare metoda va fi apelata pe fire distincte. Fiecare fir va folosi o
resursa comuna – lista in cazul nostru sau orice altceva ce considerati Dv – in care vor insera
urmatoarele informatii:
a. “Start fir: “ + nume fir + Timestamp + “ Numar natural dat = “ + numarNaturalDat.
Timestamp sub forma hh:mm:s:ms
b. “Iesire temporara fir: “ + nume fir + Timestamp. Se intampla cand firul este intrerupt de
catre SO si se lanseaza alt fir de executie.
c. “End fir: “ + nume fir + Timestamp + “Numar prim = “ + numarPrimDeterminat. . Firul sia terminat executia si afiseaza rezultatul final.
3. Aceeasi problema ca la punctul doi dar veti folosi componenta BackgroundWorker.
4. Aceeasi problema ca la punctul 2 dar veti folosi patternul TAP (Task Asyncronous Pattern).
*/
namespace Lab1
{
    public class Program
    {
        public int _nr;

        bool IsPrime(int nr)
        {
            if (nr == 2 || nr == 3 || nr == 5)
                return true;

            for (int i = 2; i <= nr / 2; i++)
            {
                if (nr % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void Metoda1()
        {
            int nr = 0;
            for (int i = _nr - 1; i >= 2; i--)
            {
                if (IsPrime(i) == true)
                {
                    nr = i;
                    break;
                }
            }
            if (nr == 0)
                Console.WriteLine("There doesn't exist one!");
            else
                Console.WriteLine(nr.ToString());
        }
        public void Metoda2()
        {
            int maxim = 0;
            if (2 < _nr)
            {
                maxim = 2;
            }

            for (int i = 3; i <= _nr - 1; i += 2)
            {
                if (IsPrime(i) == true)
                {
                    if (i > maxim)
                    {
                        maxim = i;
                    }

                }

            }
            if (maxim == 0)
                Console.WriteLine("There doesn't exist one!");
            else
                Console.WriteLine(maxim.ToString());
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            int numarNaturalDat = 12;
            obj._nr = numarNaturalDat;

            Thread thread1 = new Thread(new ThreadStart(obj.Metoda1));
            Thread thread2 = new Thread(new ThreadStart(obj.Metoda2));

            thread1.Name = "Thread One";
            thread2.Name = "Thread Two";

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }
    }
}
