

namespace PindalakalkulaatorkirilllepmetsIKTpv25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kas teie tuba on kolmnurk, ristkülik vöi ring? Palun sisestage teie valik (kolmnurk, ristkülik või ring): ");  // Kolmnurk, ristkülik või ring
            string figure = Console.ReadLine();
            double tulemus = 0;
            if (figure == "kolmnurk")
            {
                Console.WriteLine("Sisestage kolmnurga alus (meetrid): ");
                double alus = double.Parse(Console.ReadLine());
                Console.WriteLine("Sisestage kolmnurga kõrgus (meetrid): ");
                double kõrgus = double.Parse(Console.ReadLine());
                tulemus = (alus * kõrgus) / 2;
            }
            else if (figure == "ristküli")
            {
                Console.WriteLine("Sisestage ristküliku pikkus (meetrid): ");
                double pikkus = double.Parse(Console.ReadLine());
                Console.WriteLine("Sisestage ristküliku laius (meetrid): ");
                double laius = double.Parse(Console.ReadLine());
                tulemus = pikkus * laius;
            }
            else if (figure == "ring")
            {
                Console.WriteLine("Sisesta ringi raadius (meetrid): ");
                double raadius = double.Parse(Console.ReadLine());
                tulemus = Math.PI * raadius * raadius;
            }
            else
            {
                Console.WriteLine("Te pole midagi valinud.Proovige uuesti");
            }
            Console.WriteLine("Teie tuba pindala on: " + tulemus + "m^2");
        }
    }
}

