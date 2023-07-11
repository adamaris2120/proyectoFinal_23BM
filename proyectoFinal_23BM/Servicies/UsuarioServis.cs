using Microsoft.EntityFrameworkCore;
using proyectoFinal_23BM.Constex;
using proyectoFinal_23BM.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace proyectoFinal_23BM.Servicies
{
    public class UsuarioServis
    {
        public void AddUser(Usuario resquest)
        {
            try
            {
                if (resquest != null)
                {
                    using (var _context = new AplicationDBContext())
                    {
                        Usuario res = new Usuario();
                        res.Nombre = resquest.Nombre;
                        res.UserName = resquest.UserName;
                        res.Password = resquest.Password;
                        _context.Usuario.Add(res);
                        _context.SaveChanges();
                    }


                }

            }
            catch (Exception ex)
            {
                throw new Exception("sucedio un error " + ex.Message);
            }
        }
        public List<Usuario> GetUsuario()
        {
            try
            {
                using (var _context = new AplicationDBContext())

                {
                    List<Usuario> usuario = _context.Usuario.ToList();
                    if (usuario.Count > 0)
                    {
                        return usuario;

                    }
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("sucedio un error " + ex.Message);
            }
        }

        public void UpdateUser ( Usuario request)
        {
            try
            {
                using(var _context = new AplicationDBContext())
                {
                    Usuario usuario = new Usuario();
                    usuario = _context.Usuario.Find(request.PkUsuario);
                    usuario.Nombre = request.Nombre;
                    usuario.UserName = request.UserName;
                    usuario.Password = request.Password;

                    _context.Entry(usuario).State = EntityState.Modified;
                    _context.SaveChanges();


                }
            }
        }

    }
   
}
