using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUISEI.MODELO;

namespace SUISEI.CONTROLADOR
{
    public static class ClsLogin
    {
        public static List<string> retornarCredenciales(String nomUsuario, String clave)
        {
            using (SUISEIEntities bd = new SUISEIEntities())
            {
                var roles = bd.OBTENER_CREDENCIALES(null, nomUsuario,clave).ToList();
                return roles;
            }
        }
    }
}
