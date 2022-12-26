using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academico.Common.Models
{
    public class Pesquisador
    {
        
        public int CodigoPesquisa { get; set; }

        public String? GrupoPesquisa { get; set; }

        public String? InstituicaoVinculada { get; set; }
    }
}