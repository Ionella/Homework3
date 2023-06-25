using System;
using System.Threading.Tasks.Dataflow;

namespace homework3
{
    public class myClasa
    {
        public void afiseazaNumar(int Numar)
        {
            Console.WriteLine("Numarul este " + Numar);
            if (Numar > 0)
                Console.WriteLine("Numarul este pozitiv.");
            else
                Console.WriteLine("Numarul este negativ.");
        }
        /// ============================================================
        public void CalculeazaSuma(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine("Suma numerelor este:" + suma);
        }
        /// ============================================================
        public static void CalculeazaProdus(int a, int b)
        {
            int produs = a * b;
            Console.WriteLine("Produsul numerelor este:" + produs);
        }
        /// ============================================================
        }
    class Program
    {
        static void Main(string[] args)
        {
            myClasa obj = new myClasa();
            obj.afiseazaNumar(-10);
            obj.CalculeazaSuma(-5, 3);
            myClasa.CalculeazaProdus(2, -4);
         
        }
    }
}