using System;
using System.Collections;
using System.Collections.Generic;
using static Console_App.Pessoa;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            ArrayList Users = new ArrayList();

            Console.WriteLine("Hello World!");

            for(i = 1; i <= 2; i++)
            {
                Console.WriteLine("Insira seu nome");
                var nome = Console.ReadLine();

                Console.WriteLine("Insira a sua idade");
                var idade = Console.ReadLine();

                Console.WriteLine("Insira o seu sexo");
                var sexo = Console.ReadLine();
                
                Console.WriteLine("Insira a sua nacionalidade");
                var nacionalidade = Console.ReadLine();

                Console.WriteLine("Insira a sua altura");
                var altura = Console.ReadLine();

                Pessoa pessoa = new Pessoa(nome, idade, sexo, nacionalidade, altura);
                Users.Add(pessoa);
            }

            Console.WriteLine("Final!");
        }
    }
}
