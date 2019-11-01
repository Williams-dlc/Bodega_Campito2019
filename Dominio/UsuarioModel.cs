using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Common.Cache;

namespace Dominio
{
    public class UsuarioModel
    {
        DatosUsuario datosUser = new DatosUsuario();
        public bool LoginUser(string user, string pass)
        {
            return datosUser.login(user, pass);
        }

        public bool AñadirProduc(string id, string nombre)
        {
            return datosUser.productoMas(id, nombre);
        }

        //PERMISOS DE USUARIO
        public void AnyMethod()
        {
            if (UserLoginCache.Perfil == Cargos.Administrador)
            {

            }
            if (UserLoginCache.Perfil == Cargos.Trabajador)
            {

            }//prueba
        }

    }
}
