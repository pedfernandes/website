using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.App_Code.Model
{
    public class Editora
    {

        public int EditoraID { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public IList<Livro> ListaLivro { get; set; }



    }
}