using System.Globalization;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            while (b >= a) {
                if (b % 3 == 0) { 
                Console.Write(b + " ");
                }
                b--;
            }
            // tutaj rozwiązanie zadania 1

            Console.WriteLine("Kończę zadanie 1");
        }
        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            // zadanie numer 2
            // zaimplementuj poniższą procedurę
            static void PrintTriangle(int w)
            {
                for (int i = 1; i <= w; i++) { 
                Console.Write(new string(' ',w -i));
                Console.Write(new String('$', 2*i-1 ));
                Console.WriteLine('\n');
                }


            }
            PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }
        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;
            int godzina = today.Hour;
            string day = today.DayOfWeek.ToString();
            int dayn = (int)today.DayOfWeek;
            if (godzina < 12)
            {
               string text =($"Dzień dobry, dzisiaj {day}, czyli {dayn} dzień tygodn");
            }
            else
            {
                string text = ($"Dobry wieczór, dzisiaj {day}, czyli {dayn} dzień tygodn");
            }

            // tutaj rozwiązanie zadania 3
           
            Console.WriteLine(text);

            Console.WriteLine("Kończę zadanie 3");
        }
        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };

            // zadanie numer 4
            // zaimplementuj poniższą funkcję
            static void FindMaxAbsoluteValue(double[] array)
            {
                double max = array[0];
                foreach (double number in array) {
                    if (Math.Abs(number) > Math.Abs(max))
                    {
                        max = number;
                    }
                     Console.WriteLine(max);
                    
                    
            }
            Console.WriteLine("The Min value");
                Console.WriteLine(FindMaxAbsoluteValue(numbers));
                Console.WriteLine("Kończę zadanie 4");
        }
        static void Zadanie_5_6()
        {
            // tutaj rozwiązanie zadań 5 oraz 6
            // można modyfikować, zmieniać kolejność itp.
            Console.WriteLine("Rozpoczynam pętlę.");

            Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");
                try
                {string b= Console.ReadLine();
                    int c = int.Parse(b);
                }
                catch
                {

                }
            Zadanie_1();
            Zadanie_2();
            Zadanie_3();
            Zadanie_4();

            Console.WriteLine("Kończę pętlę.");
        }

    }
}