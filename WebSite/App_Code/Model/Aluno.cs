using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite.App_Code.BO;
namespace WebSite.App_Code.Model
{
    public class Aluno
    {

        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        //aluno faz varios emprestimo e um emprestimo pertence a um aluno
        public IList<Emprestimo> ListaEmprestimo { get; set; }

        public void Gravar()
        {
            AlunoBO albo = new AlunoBO();
            albo.Gravar(this);
        }


    }


    
}