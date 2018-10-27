using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite.App_Code.Model;
using System.Data;
using System.Data.SqlClient;
using WebMatrix.Data;

namespace WebSite.App_Code.DAO
{
    public class AlunoDAO
    {

        Database banco = Database.Open("conexaoBanco");
        int sucesso;
        public int Gravar(Aluno al)
        {
            if (al.AlunoID == 0)
            {

                var sql = "insert into Alunos(nome,matricula,cpf,email) values (@0,@1,@2,@3)";
                sucesso = banco.Execute(sql, al.Nome, al.Matricula, al.Cpf, al.Email);
              

            }
            else
            {
                var sql = "update Alunos set nome=@0 ,matricula=@1,cpf=@2,email=@3 where alunoID = @4 ";
                 sucesso = banco.Execute(sql, al.Nome, al.Matricula, al.Cpf, al.Email,al.AlunoID);
            }

            banco.Close();


            return sucesso;
           
              
           
        }


        public IList<Aluno> ListaAlunos()
        {

            IList<Aluno> lista = new List<Aluno>();

            var sql = "select * from Alunos";
            var resultado = banco.Query(sql);

            if (resultado.Count() > 0 )
            {
                Aluno objal;
                foreach (var item in resultado)
                {

                    objal = new Aluno
                    {
                        AlunoID = item.alunoID,
                        Nome = item.nome,
                        Matricula = item.matricula,
                        Cpf = item.cpf,
                        Email = item.email
                        

                    };

                    lista.Add(objal);

                }

                banco.Close();

            }
            else
            {
                banco.Close();
                return null;
            }
         


            return lista;

        }


        public Aluno BuscarAluno(int id)
        {
            var sql = "select * from Alunos where alunoID = @0";
            var resultado = banco.QuerySingle(sql,id);

            Aluno objal = new Aluno
            {
                AlunoID = resultado.alunoID,
                Nome = resultado.nome,
                Matricula = resultado.matricula,
                Email = resultado.email,
                Cpf = resultado.cpf



            };

            banco.Close();

            return objal;


        }

        public void Excluir(int alunoID)
        {
            var sql = "Delete from Alunos where alunoID=@0";
            banco.Execute(sql, alunoID);
            banco.Close();
        }

    }
}