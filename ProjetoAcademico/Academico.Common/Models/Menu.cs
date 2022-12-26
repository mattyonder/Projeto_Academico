using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academico.Common.Models
{
    public class Menu 
    {
        public string GetMenu()
        {
            String menu = "****Sistema Acadêmico****"
            + "\n 	Menu"
            + "\n ======================="
            + "\n Digite uma opção"
            + "\n 1.Cadastrar Aluno"
            + "\n 2.Listar Aluno"
            + "\n 3.Cadastrar Professor"
            + "\n 4.Listar Professor"
            + "\n 5.Cadastrar Coordenador"
            + "\n 6.Listar Coordenador"
            + "\n 7.Cadastrar Estagiario"
            + "\n 8.Listar Estagiario"
            + "\n 9.Cadastrar Pesquisador"
            + "\n 10.Listar Pesquisador"
            + "\n 11.Cadastrar Psicologo"
            + "\n 12.Listar Psicologo"
            + "\n 13.Cadastrar Tecnico"
            + "\n 14.Listar Tecnico"
            + "\n 15.Cadastrar Bolsista"
            + "\n 16.Listar Bolsista"
            + "\n 17.Cadastrar Fornecedor"
            + "\n 18.Listar Fornecedor"
            + "\n 0.Sair";
            
            return menu;
        }
    }
}