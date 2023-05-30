using MSIF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIF.Controller
{
    public class RecadoController : DefaultController
    {
        public static void Salvar(Recado item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }
    }
}
