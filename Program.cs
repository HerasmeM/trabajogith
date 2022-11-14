using System;
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
            string Nombre,clase,jugador1, jugador2, Pelea, Ganador, Perdedor, Mago = "M" , Guerrero= "G", Asesino= "A";
            Random rand = new Random();
            int HP, force, stamina, inte, agi;
            HP= rand.Next(0, 100);
            force= rand.Next(0, 100);
            stamina= rand.Next(0, 100);
            inte= rand.Next(0, 100);
            agi= rand.Next(0, 100);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Elige el nombre de tu personaje");
                Nombre= Console.ReadLine();
            Console.WriteLine("Elige tu clase");
            if (Console.ReadLine("M"))
            {
                clase = Mago;
            }
            else if (Console.ReadLine("G"))
            {
                clase = Guerrero;
            }
            else
            {
                clase = Asesino;
            }

            Console.WriteLine("tu personaje es"+ Nombre + "correcto?");
            Console.WriteLine("tu clases es" + clase + "correcto?");
            Console.WriteLine("tu HP es" + HP + "correcto?");
            Console.WriteLine("tu fuerza es" + force + "correcto?");
            Console.WriteLine("tu estamina es" + stamina + "correcto?");
            Console.WriteLine("tu inteligencia es" + inte + "correcto?");
            Console.WriteLine("tu agilidad es" + agi + "correcto?");


            Console.ReadLine();
        }
    }
}
