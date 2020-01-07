using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SISASEPBA.Models
{
    public class APCambioDeNumeroDeSeguro
    {
        public string Accion { get; set; } = string.Empty;

        public int IdAccionPersonal { get; set; } = 0;

        public int IdTipoAP { get; set; } = 0;

        public int IdEmpleado { get; set; } = 0;

        [DisplayName("Número de seguro: ")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Debe ingresar entre 3 y 15 caracteres.")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "¡Debe ingresar un número!")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string NumeroAsegurado { get; set; } = string.Empty;
        
        [DisplayName("Fecha en la que rige: ")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public DateTime FechaRige { get; set; } = DateTime.Now;

        [StringLength(150, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        [DisplayName("Observaciones de acción de personal: ")]
        public string ObservacionesAP { get; set; } = string.Empty;

        public DateTime FechaDeAprobacion { get; set; } = DateTime.Now;

        public string UsuarioDeAprobacion { set; get; } = string.Empty;

        public DateTime FechaDeAplicacion { get; set; } = DateTime.Now;

        public string UsuarioDeAplicacion { set; get; } = string.Empty;

        public DateTime FechaDeCancelacion { get; set; } = DateTime.Now;

        public string UsuarioDeCancelacion { set; get; } = string.Empty;

        public DateTime FechaDeDenegacion { get; set; } = DateTime.Now;

        public string UsuarioDeDenegacion { set; get; } = string.Empty;

        public string UsuarioCreacion { get; set; } = string.Empty;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public string UsuarioModificacion { get; set; } = string.Empty;

        public DateTime FechaModificacion { get; set; } = DateTime.Now;

    }
}