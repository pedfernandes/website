using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.App_Code.Model
{
    public class Livro
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public DateTime DataPublicacao { get; set; }
        
        public Autor ObjAutor { get; set; }
        public Editora ObjEditora { get; set; }



    }
}