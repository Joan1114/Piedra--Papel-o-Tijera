using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiPaTi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int result = 1, jugada1;
            string jugador, jugadorM;
            string [] jugadas = {"Piedra", "Papel", "Tijeras"};

            while (result == 1)
            {
                Console.Write("Jugador escoga su jugada: (1: Piedra; 2:Papel; 3:Tijeras):  ");
                jugada1 = int.Parse(Console.ReadLine());
                jugador = jugadas[jugada1 - 1];
                jugadorM = jugadas[rnd.Next(0, 2)];

                if ((jugador == "Piedra") && (jugadorM == "Tijeras"))
                {
                    Console.Write("Ganaste, la maquina jugo: " + jugadorM + "\n");
                }else if ((jugador == "Papel") && (jugadorM == "Piedra"))
                {
                    Console.Write("Ganaste, la maquina jugo: " + jugadorM + "\n");
                }else if ((jugador == "Tijeras") && (jugadorM == "Papel"))
                {
                    Console.Write("Ganaste, la maquina jugo: " + jugadorM + "\n");
                }

                if ((jugadorM == "Piedra") && (jugador == "Tijeras"))
                {
                    Console.Write("Gano la maquina porque jugo: " + jugadorM + "\n");
                }else if ((jugadorM == "Tijeras") && (jugador == "Papel"))
                {
                    Console.Write("Gano la maquina porque jugo: " + jugadorM + "\n");
                }else if ((jugadorM == "Papel") && (jugador == "Piedra"))
                {
                    Console.Write("Gano la maquina porque jugo: " + jugadorM + "\n");
                }

                if ((jugadorM == "Piedra") && (jugador == "Piedra") || (jugadorM == "Papel") && (jugador == "Papel")
                    || (jugadorM == "Tijeras") && (jugador == "Tijeras"))
                {
                    Console.Write("Empate, la maquina y el jugador seleccionaron la misma jugada " + jugadorM +  jugador + "\n");
                }

                Console.WriteLine("Desea continuar 1 = Si; 0 = No");
                result = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
