using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite.App_Code.Model;
using WebSite.App_Code.DAO;



namespace WebSite.App_Code.BO
{
    public class AutorBO
    {

        public void Gravar(Autor at)
        {

            if (at.Nome != "" && at.Sexo != 0 )
            {
                new AutorDAO().Gravar(at);
            }



        }
        
    


    }
}