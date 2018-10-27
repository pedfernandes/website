using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.App_Code.Model
{
    public class Autor
    {

        public int AutorID { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        // autor tem uma lista de livro
        public IList<Livro> ListaLivro { get; set; }

    }

}