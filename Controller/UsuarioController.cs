using MSIF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIF.Controller
{
    public class UsuarioController : DefaultController
    {
        public static void Salvar(Usuario item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }
    }
}
