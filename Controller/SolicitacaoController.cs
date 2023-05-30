using MSIF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIF.Controller
{
    public class SolicitacaoController : DefaultController
    {
        public static void Salvar(Solicitacao item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }
    }
}
