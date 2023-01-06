using delegatesExemplos.Models;
using System;


namespace delegatesExemplos
{

    class Program
    {
        public delegate float operacao(float n1, float n2);
        static void Main(string[] args)
        {
            operacao op = Calculadora.Somar;
            var resultado = op.Invoke(2, 3);
            Console.WriteLine(resultado);
        }
    }
}


