using MSIF.Model;

namespace MSIF.Controller
{
    public class UsuarioController : DefaultController
    {
        public void Salvar(Usuario item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }

        public void Create(Usuario item)
        {
            Context.Add(item);
            Context.SaveChanges();
        }

        public void UpdateUsuarioUrl(int idUsuario, String url)
        {
            Usuario usuario = Context.Usuario.Where(r => r.UsuarioId.Equals(idUsuario)).FirstOrDefault();
            usuario.Url = url;
            Context.Update(usuario);
            Context.SaveChanges();
        }

        public void UpdateUsuarioApelido(int idUsuario, String apelido)
        {
            Usuario usuario = Context.Usuario.Where(r => r.UsuarioId.Equals(idUsuario)).FirstOrDefault();
            usuario.Apelido = apelido;
            Context.Update(usuario);
            Context.SaveChanges();
        }

        public void UpdateUsuarioSenha(int idUsuario, String senha)
        {
            Usuario usuario = Context.Usuario.Where(r => r.UsuarioId.Equals(idUsuario)).FirstOrDefault();
            usuario.Senha = senha;
            Context.Update(usuario);
            Context.SaveChanges();
        }

        public int GetIdUsuario(String email, String senha)
        {
            List<Usuario> ul = Context.Usuario.Where(r => r.Email.Equals(email)).ToList();

            if(ul.Count != 0 && ul.First().Senha.Equals(senha))
            {
                return ul.First().UsuarioId;
            } else
            {
                return -1;
            }
        }

        public Usuario GetUsuarioObj(int id)
        {
            List<Usuario> ul = Context.Usuario.Where(r => r.UsuarioId.Equals(id)).ToList();

            if (ul.Count != 0)
            {
                return ul.First();
            }
            else
            {
                //Nunca é nulo, pois ocorre verificação em Login.
                return null;
            }
        }

        public Usuario GetUsuarioObj(String apelido)
        {
            if (apelido != null)
            {
                List<Usuario> ul = Context.Usuario.Where(r => r.Apelido.Equals(apelido)).ToList();

                if (ul.Count != 0)
                {
                    return ul.First();
                }
                else
                {
                    //Nunca é nulo, pois ocorre verificação em Login.
                    return null;
                }
            }
            else return null;
        }

        public Boolean HaEmailRepetido(Usuario item)
        {
            int quantidade = Context.Usuario.Where(r => r.Email.Equals(item.Email)).Count();

            return quantidade != 0;
        }

        public Boolean HaApelidoRepetido(String apelido)
        {
            int quantidade = Context.Usuario.Where(r => r.Apelido.Equals(apelido)).Count();

            return quantidade != 0;
        }

    }
}
