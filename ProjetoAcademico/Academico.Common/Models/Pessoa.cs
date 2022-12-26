using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academico.Common.Models
{
    public class Pessoa
    {
        
        public string? Nome { get; set; }
        public char Sexo { get; set; }
        public string? LocalNascimento { get; set; }
        public string? DataNascimento { get; set; }
    }
}