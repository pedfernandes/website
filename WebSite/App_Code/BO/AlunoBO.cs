using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite.App_Code.Model;
using WebSite.App_Code.DAO;

namespace WebSite.App_Code.BO
{
    public class AlunoBO
    {

        public bool Gravar(Aluno al)
        {

            if (al.Nome != "" && al.Cpf != "")
            {

                int sucesso = new AlunoDAO().Gravar(al);

                if (sucesso != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }

            else
            {
                return false;
            }



        }


        public IList<Aluno> listaAlunos()
        {

            return new AlunoDAO().ListaAlunos();



        }


        public Aluno BuscarAluno(int id)
        {

            return new AlunoDAO().BuscarAluno(id);



        }

        public void Excluir(int alunoID)
        {
            new AlunoDAO().Excluir(alunoID);


        }
    }
}