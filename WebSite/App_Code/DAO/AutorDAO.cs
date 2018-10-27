using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;
using WebSite.App_Code.Model;
namespace WebSite.App_Code.DAO
{
    public class AutorDAO
    {

        Database banco = Database.Open("conexaoBanco");

        public int Gravar(Autor at)
        {
            int sucesso;

            if (at.AutorID == 0 )
            {
                var sql = "insert into Autores values(@0, @1)";
              sucesso =   banco.Execute(sql, at.Nome, at.Sexo);

            }
            else
            {
                var sql = "update Autores set nome = @0 , sexo = @1 where autorID = @2 ";
               sucesso =  banco.Execute(sql, at.Nome, at.Sexo, at.AutorID);
              
            }


            banco.Close();
            return sucesso;
               


        }

        public IList<Autor> listaAutor()
        {
            IList<Autor> lista = new List<Autor>();
            var sql = "select * from Alunos";
            var resultado = banco.Query(sql);

            if (resultado.Count() > 0)
            {
                Autor objat;

                foreach (var item in resultado)
                {
                    objat = new Autor
                    {
                        Nome = item.nome, 
                       Sexo = item.sexo
                    };
                    lista.Add(objat);
                    
                }
               
            }

            else
            {
                banco.Close();
                return null;
            }

            banco.Close();
            return lista;

        }


        public Autor buscaAutor (int id)
        {
            var sql = "select * from Autores whrere autorID = @0";
            var resultado = banco.QuerySingle(sql, id);

            Autor objat =  new Autor
                {
                    AutorID = resultado.autorID,
                    Nome = resultado.nome,
                    Sexo = resultado.sexo

                };
           


            banco.Close();
            return objat;

        }
        

        public void Excluir(int id)
        {
            var sql = "delete from Autores where autorID = @0";
            banco.Execute(sql, id);
            banco.Close();

        }
         
       
    }
}