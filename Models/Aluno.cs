using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public Aluno(string nome, string sobrenome, int idade, double nota) : base(nome, sobrenome, idade)
        {
            Nota = nota;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá! Me chamo {Nome}, e tenho {Idade} anos. Também sou um aluno nota {Nota}!");
        }
    }
}