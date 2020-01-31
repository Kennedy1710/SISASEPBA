using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SISASEPBAWs.CapaObjetos
{
    public class ObjGrupos
    {

        public string Accion { get; set; } = string.Empty;

        public int IdGrupo { get; set; } = 0;

        public string Alias { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public bool Estado { get; set; } = false;

        public int IdPrivilegio { get; set; } = 0;

        public string usuario { get; set; } = string.Empty;

    }
}