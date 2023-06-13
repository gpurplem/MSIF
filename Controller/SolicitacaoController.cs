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
        public void Salvar(Solicitacao item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }

        public List<Solicitacao> GetSolicitacoesObjs(int idLogado)
        {
            List<Solicitacao> ls = Context.Solicitacao.Where(r => r.Destinatario.Equals(idLogado)).ToList();

            if (ls.Count != 0)
            {
                return ls;
            }
            else
            {              
                return null;
            }
        }

    }
}
