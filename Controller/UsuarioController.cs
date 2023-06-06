using Microsoft.VisualBasic.Devices;
using MSIF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public void CreateTeste()
        {
            Usuario usuario = new Usuario();
            usuario.Status = 1;
            usuario.Url = "foto3.jpg";
            usuario.Senha = "333";
            usuario.Email = "c@c.com";
            usuario.Apelido = "Te3";
            usuario.Nome = "Testa3";

            Context.Add(usuario);
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

        public void DeleteTeste()
        {
            Usuario usuario = Context.Usuario.Where(r => r.UsuarioId.Equals(2)).FirstOrDefault();
            Context.Remove(usuario);
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

    }
}
