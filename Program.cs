using System;

namespace Esagono
{
    class Program
    {
        static void Main(string[] args)
        {
            int lato = 0;
            double Area = 0;
            double apotema = 0.866 * lato;
            double cost = 2.598;
            double baricentro = 0;
            char scelta = ' ';
            Console.Write("Inserisci lunghezza lato(cm): ");
            lato = Convert.ToInt32(Console.ReadLine());
            do
            {
                //Console.Clear();
                Console.Write("A - CALCOLA PERIMETRO\nB - CALCOLA AREA\nC - CALCOLA BARICENTRO\nD - CAMBIA VALORE\n| - ESCI\nQUALE OPZIONE VUOI FARE?: ");
                scelta = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (scelta)
                {
                    case 'A':
                        Console.WriteLine("Il perimetro dell'esagono regolare è: " + (6 * lato)+"cm");
                        break;
                    case 'B':
                        //Area = ((6 * lato) * apotema) / 2;
                        Area = Math.Pow(lato, 2)*cost;
                        Area = Math.Round(Area, 2);
                        Console.WriteLine("L'area dell'esagono regolare è: " + Area+"cm²");
                        break;
                    case 'C':
                        baricentro = (Math.Sqrt(3) / 2) * lato;
                        baricentro = Math.Round(baricentro, 2);
                        Console.WriteLine("Il baricentro dell'esagono regolare è: " + baricentro);
                        break;
                    case 'D':
                        Console.Write("Inserisci nuova lunghezza lato(cm): ");
;                       break;
                    case '|':
                        Console.WriteLine("ciao");
                        break;
                    default:
                        Console.WriteLine("Valore errato");
                        break;
                }
            } while (scelta != '|');
        }
    }
}
