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
        public void Salvar(Recado item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }

        public List<Recado> Listar()
        {
            return Context.Recado.ToList();
        }

        public List<Recado> GetRecadosObjs(int idLogado, int idDestinatario)
        {
            List<Recado> ls = Context.Recado.Where(r => r.Remetente.Equals(idLogado) && r.Destinatario.Equals(idDestinatario)).OrderBy(p => p.Dataenvio).ToList();

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
