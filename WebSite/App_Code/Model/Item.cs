using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.App_Code.Model
{
    public class Item
    {

        public int ItemID { get; set; }
        // item tem um emprestimo
        public Emprestimo ObjEmprestimo { get; set; }
        // emprestimo do livro
        public Livro ObjLivro { get; set; }


    }
}