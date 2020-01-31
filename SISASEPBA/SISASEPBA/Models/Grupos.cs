using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SISASEPBA.Models
{
    public class Grupos
    {
        public string Accion { get; set; } = string.Empty;

        public int IdGrupo { get; set; } = 0;

        public int IdPrivilegio { get; set; } = 0;

        public string Alias { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public bool Estado { get; set; } = false;

        public int IdUsuario { get; set; } = 0;

        public List<Models.Usuario> Usuarios { get; set; }
        public List<Models.Privilegios> Privilegios { get; set; }
        public List<Models.Grupos> GrupoUsuarios { get; set; }
        public List<Models.Grupos> GrupoPrivilegios { get; set; }
    }
}