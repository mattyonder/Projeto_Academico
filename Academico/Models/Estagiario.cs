using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Academico.Models
{
    public class Estagiario : Pessoa
    {

     public String? Instituicao { get; set; }
     
     public String? PeriodoAtual { get; set; }

     public String? Curso { get; set; }

    }
}