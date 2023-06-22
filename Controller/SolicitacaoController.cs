using MSIF.Model;

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

        public void DeleteSolicitacao(int idUsuarioAdd, int idLogado)
        {
            Solicitacao solicitacao = Context.Solicitacao.Where(r => r.Destinatario.Equals(idLogado) && r.Remetente.Equals(idUsuarioAdd)).FirstOrDefault();
            Context.Solicitacao.Remove(solicitacao);
            Context.SaveChanges();
        }

        public Boolean HaSolicitacaoRepetida(Solicitacao item)
        {
            int quantidade = Context.Solicitacao.Where(r => r.Remetente.Equals(item.Remetente) && r.Destinatario.Equals(item.Destinatario)).Count();

            return quantidade != 0;
        }

        public int GetNumeroSolicitacoes(int idLogado)
        {
            List<Solicitacao> ls = Context.Solicitacao.Where(r => (r.Destinatario.Equals(idLogado))).ToList();

            return ls.Count;
        }

    }
}
