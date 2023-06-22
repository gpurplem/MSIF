using MSIF.Model;

namespace MSIF.Controller
{
    public class ImagemController : DefaultController
    {
        public void Create(Imagem item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }

        public Imagem GetImagemObj(int id)
        {
            List<Imagem> il = Context.Imagem.Where(r => r.ImagemId.Equals(id)).ToList();

            if (il.Count != 0)
            {
                return il.First();
            }
            else
            {
                //Nunca é nulo, pois ocorre verificação em Login.
                return null;
            }
        }

        public void UpdateImagem(int idImagemOriginal, byte[] imagemNova, Usuario usuario)
        {
            if(idImagemOriginal != 6)
            {
                Imagem imagem = Context.Imagem.Where(r => r.ImagemId.Equals(idImagemOriginal)).FirstOrDefault();

                imagem.ImageData = imagemNova;

                Context.Update(imagem);
                Context.SaveChanges();
            }
            else
            {
                Imagem img = new Imagem();
                img.ImageData = imagemNova;
                Create(img);
                String nomeArquivo = img.ImagemId.ToString();

                //Atualizar campo URL de usuário
                usuario.Url = nomeArquivo;
            }
        }
    }
}
