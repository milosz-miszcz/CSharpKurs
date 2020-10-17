using System; // Musi byc duza litera

namespace Hello // Tytul
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string name = args[0];
            Console.WriteLine("Witaj, " + name); */

            foreach (var item in args)
            {
                Console.WriteLine("Witaj," + item);
            }

        }
    }
}
