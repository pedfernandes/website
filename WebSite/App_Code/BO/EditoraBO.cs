using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSite.App_Code.Model;
using WebSite.App_Code.DAO;

namespace WebSite.App_Code.BO
{
    public class EditoraBO
    {
        public bool Gravar(Editora ed)
        {
            if (ed.Local != "" && ed.Nome != "")
            {
               
              int sucesso =   new EditoraDAO().Gravar(ed);

                if (sucesso != 0 )
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
    }
}