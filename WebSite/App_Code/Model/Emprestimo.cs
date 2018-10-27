using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.App_Code.Model
{
    public class Emprestimo
    {

        public int EmprestimoID { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataPublicacao { get; set; }
        // este emprestimo é de um aluno
        public Aluno ObjAluno { get; set; }
        //emprestimo tem uma lista de itens
        public IList<Item> ListaItem { get; set; }




    }
}