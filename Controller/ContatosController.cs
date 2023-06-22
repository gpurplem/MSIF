using MSIF.Model;

namespace MSIF.Controller
{
    public class ContatosController : DefaultController
    {
        public void Salvar(Contatos item)
        {
            Contatos contato1 = new Contatos();
            Contatos contato2 = new Contatos();

            contato1.Logado = item.Logado;
            contato1.Contato = item.Contato;

            contato2.Logado = item.Contato;
            contato2.Contato = item.Logado;

            Context.Add(contato1);
            Context.SaveChanges();
            Context.Add(contato2);
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

        public int GetNumeroContatos(int idLogado)
        {
            int quantidade = Context.Contatos.Where(r => r.Logado.Equals(idLogado)).Count();

            return quantidade;
        }

    }
}
