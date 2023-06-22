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
            List<Recado> ls = Context.Recado
                .Where
                (r => 
                    (
                        r.Remetente.Equals(idLogado) && r.Destinatario.Equals(idDestinatario)
                    )
                    || 
                    (
                        r.Remetente.Equals(idDestinatario) && r.Destinatario.Equals(idLogado)
                    )
                )
                .OrderBy(p => p.Dataenvio)
                .ToList();

            if (ls.Count != 0)
            {
                return ls;
            }
            else
            {
                return null;
            }
        }

        public List<Recado> GetRecadosObjsParaLogado(int idLogado)
        {
            List<Recado> ls = Context.Recado.Where(r =>(r.Destinatario.Equals(idLogado))).ToList();

            if (ls.Count != 0)
            {
                return ls;
            }
            else
            {
                return null;
            }
        }

        public void MarcarRecadosLidos(int idRemetente, int idDestinatario)
        {
            List<Recado> ls = Context.Recado.Where(r =>(r.Remetente.Equals(idDestinatario) && r.Destinatario.Equals(idRemetente))).ToList();

            foreach (Recado r in ls)
            {
                r.Status = 1;
                Context.SaveChanges();
            }
        }

        public int GetNumeroMensagens(int idLogado)
        {
            List<Recado> ls = Context.Recado.Where(r => (r.Destinatario.Equals(idLogado))).ToList();

            return ls.Count;
        }
    }
}
