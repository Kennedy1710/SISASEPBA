using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SISASEPBA.Models
{
    public class APCambioDeSalario
    {
        public string Accion { get; set; } = string.Empty;
        
        public int IdAccionPersonal { get; set; } = 0;
        
        public int IdTipoAP { get; set; } = 0;

        public int IdEmpleado { get; set; } = 0;

        [DisplayName("Forma de pago: ")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string IdFormaPago { get; set; } = string.Empty;


        [DisplayName("Salario de referencia: ")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public decimal SalarioReferencia { set; get; } = 0;

        [DisplayName("Fecha en la que rige: ")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public DateTime FechaRige { get; set; } = DateTime.Now;

        [DisplayName("Observaciones de acción de personal: ")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
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