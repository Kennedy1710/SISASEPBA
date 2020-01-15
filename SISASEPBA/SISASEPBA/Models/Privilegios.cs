using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SISASEPBA.Models
{
    public class Privilegios
    {
        public string Accion { get; set; } = string.Empty;

        public int IdPrivilegio { get; set; } = 0;

        public string Alias { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public string NombreConstante { get; set; } = string.Empty;

        public bool Estado { get; set; } = false;
    }
}