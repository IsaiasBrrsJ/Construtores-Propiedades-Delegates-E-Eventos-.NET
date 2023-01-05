using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        //Caso eu não tenha nenhum um construtor criado ele cria um padrão.
        // public Pessoa() //Construtor vazio
        // {
        //     nome = String.Empty;
        //     sobrenome = String.Empty;
        // }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor classe PESSOA");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é: {nome} {sobrenome}");
        }
    }
}