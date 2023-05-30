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
        public static void Salvar(Contatos item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }

        public static void Pesquisar(Contatos item)
        {
            Context.Contatos.Where(x => x.Logado == item.Logado).ToList();
        }

    }
}
