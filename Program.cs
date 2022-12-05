using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace trabajogith
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Random rand = new Random();
            ArrayList clases = new ArrayList();
            {
                string guerrero;
                string mago;
                string ninja;
                string luchador;
            };
            Console.WriteLine("escribe el nombre de tu luchador");
            string tipo = Console.ReadLine();
            if (tipo = clases[i]) ;
            {

            }
            string nombre;
            string nombre1;
            int HP, force, stamina, inte, agi, poder, bot;
            Console.WriteLine("escribe el nombre de tu luchador");
            Console.WriteLine("escribe el nombre de tu luchador");
            nombre1 = Console.ReadLine();

            nombre = Console.ReadLine();
            HP = rand.Next(0, 100);
            bot = rand.Next(150, 300);
            force = rand.Next(0, 100);
            stamina = rand.Next(0, 100);
            inte = rand.Next(0, 100);
            agi = rand.Next(0, 100);
            poder = HP + force + stamina + inte + agi;
            Console.WriteLine(HP);
            Console.WriteLine(force);
            Console.WriteLine(stamina);
            Console.WriteLine(inte);
            Console.WriteLine(agi);
            Console.WriteLine(poder);
            Console.WriteLine(bot);
            {
                if (poder > bot)
                {
                    Console.WriteLine(nombre + " gana!!!");
                }
                else
                {
                    Console.WriteLine(nombre + " pierde");
                }
                Console.ReadLine();
                {
                    Random rand1 = new Random();
                    int HP1, force1, stamina1, inte1, agi1, poder1, luchador1;

                    HP1 = rand1.Next(0, 100);
                    luchador1 = rand1.Next(150, 300);
                    force1 = rand1.Next(0, 100);
                    stamina1 = rand1.Next(0, 100);
                    inte1 = rand1.Next(0, 100);
                    agi1 = rand1.Next(0, 100);
                    poder1 = HP1 + force1 + stamina1 + inte1 + agi1;
                    Console.WriteLine(HP1);
                    Console.WriteLine(force1);
                    Console.WriteLine(stamina1);
                    Console.WriteLine(inte1);
                    Console.WriteLine(agi1);
                    Console.WriteLine(poder1);
                    Console.WriteLine(luchador1);
                    {
                        if (poder1 > luchador1)
                        {
                            Console.WriteLine(nombre1 + " gana!!!");
                        }
                        else
                        {
                            Console.WriteLine(nombre1 + " pierde");
                        }
                    }
                }

            }
        }
    }
}
