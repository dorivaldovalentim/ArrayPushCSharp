using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{

   class Pessoa
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string Nacionalidade { get; set; }
        public string Altura { get; set; }

        public Pessoa(string nome, string idade, string sexo, string nacionalidade, string altura)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Nacionalidade = nacionalidade;
            Altura = altura;
        }
    }
}
