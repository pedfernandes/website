using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;
using WebSite.App_Code.Model;

namespace WebSite.App_Code.DAO
{
    public class EditoraDAO
    {
        Database banco = Database.Open("conexaoBanco");

        public int Gravar(Editora ed)
        {
            var sql = "insert into Editoras values(@0, @1)";
            int sucesso = banco.Execute(sql, ed.Nome, ed.Local);
            banco.Close();

            return sucesso;

        }


        
    }
}