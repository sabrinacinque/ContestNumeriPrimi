using System.Diagnostics;

namespace ContestNumeriPrimi
{
    internal class Program
    {
        private static void Primes(int upperBound)
        {
            for (int i = 2; i <= upperBound; i++)
            {

                bool isPrime = true; //assumiamo che il numero è primo , fino a prva contraria

                int radiceQuadra = (int)Math.Sqrt(i);// Calcola la radice quadrata del numero corrente : Se un numero ha un divisore maggiore della sua radice quadrata
                                                     // deve avere anche un divisore minore della radice quadrata.Per questo è sufficiente controllare i divisori fino alla radice quadrata.

                for (int j = 2; j <= radiceQuadra; j++)
                {
                    if (i % j == 0) // Se il numero in questione (i)su modulo j è zero, allora vuol dire che i è divisibile per j
                    {
                        // Se troviamo un divisore, i non è primo,quindi isPrime viene impostato a false e usciamo dal ciclo,perchè è inutile che continuiamo oltre per questo numero
                        isPrime = false;
                        break;
                    }
                }

                // Se num è primo, allora lo stampa
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            // Un cronometro per misurare il tempo di esecuzione
            Stopwatch sw = new Stopwatch();
            // Attiva il cronometro
            sw.Start();
            // Esegue il metodo da misurare
            Primes(10000);
            // Ferma il cronometro
            sw.Stop();
            // Stampa il tempo trascorso
            Console.WriteLine($"Execution time: {sw.ElapsedMilliseconds} ms");
        }
    }
}