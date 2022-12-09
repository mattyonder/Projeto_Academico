using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Academico.Models
{
    public class Aluno : Pessoa
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public void Apresentacao(){
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Local de Nascimento: {LocalNascimento}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento}");
            Console.WriteLine($"Nota 1: {Nota1}");
            Console.WriteLine($"Nota 2: {Nota2}");
            Console.WriteLine($"Nota 3: {Nota3}");

        }
    }
}