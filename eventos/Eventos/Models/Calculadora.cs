using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class Calculadora
    {
        public delegate void delegateCalculadora();
        public static event delegateCalculadora eventoCalculadora = null!;
        public static void Somar(int num1, int num2)
        {
            if (eventoCalculadora != null)
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                eventoCalculadora();
            }
            else
            {
                Console.WriteLine("Nenhum inscrito");
            }
        }
        public static void Subtrait(int num1, int num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
    }
}