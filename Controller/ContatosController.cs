using MSIF.Data;
using MSIF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIF.Controller
{
    public class ContatosController : DefaultController
    {
        public void Salvar(Contatos item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }

        public void Pesquisar(Contatos item)
        {
            Context.Contatos.Where(x => x.Logado == item.Logado).ToList();
        }

        public Boolean HaContatoRepetido(Contatos item)
        {
            int quantidade = Context.Contatos.Where(r => r.Logado.Equals(item.Logado) && r.Contato.Equals(item.Contato)).Count();

            return quantidade != 0;
        }

        public List<Contatos> GetContatosObjs(int idLogado)
        {
            List<Contatos> ls = Context.Contatos.Where(r => r.Logado.Equals(idLogado)).ToList();

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
