using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academico.Common.Models
{
    public class Psicologo : Pessoa
    {
        
        public int NumeroConselho { get; set; }

        public int CargaHoraria { get; set; }
    }
}