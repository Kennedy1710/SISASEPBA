using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SISASEPBA.Models
{
    public class Capacitacion
    {

        public string Accion { get; set; } = string.Empty;

        public int IdCapacitacion { get; set; } = 0;

        [DisplayName("Tipo de Capacitación")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string IdTipoCapacitacion { get; set; } = string.Empty;

        [DisplayName("Fecha de registro:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [DisplayName("Fecha de inicio:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime FechaInicio { get; set; } = DateTime.Now;

        [DisplayName("Fecha de finalización:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public DateTime FechaFinalizacion { get; set; } = DateTime.Now;

        [DisplayName("Cantidad de horas:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "¡Debe ingresar un número!")]
        public int CantidadHoras { get; set; } = 0;

        [DisplayName("Nombre de la Capacitación:")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string NombreCapacitacion { get; set; } = string.Empty;

        [DisplayName("Descripción:")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string Descripcion { get; set; } = string.Empty;

        [DisplayName("Primer nombre:")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string PrimerNombreDelCapacitador { get; set; } = string.Empty;

        [DisplayName("Segundo nombre:")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        public string SegundoNombreDelCapacitador { get; set; } = string.Empty;

        [DisplayName("Primer apellido:")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string PrimerApellidoDelCapacitador { get; set; } = string.Empty;

        [DisplayName("Segundo apellido:")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string SegundoApellidoDelCapacitador { get; set; } = string.Empty;

        [DisplayName("Empresa Capacitadora")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string EmpresaCapacitadora { get; set; } = string.Empty;

        [DisplayName("Origen de la capacitación:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string Origen { get; set; } = string.Empty;

        [DisplayName("Encargado de pago:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string CargoPagoCapacitacion { get; set; } = string.Empty;

        [DisplayName("Estado")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string Estado { get; set; } = string.Empty;

        [DisplayName("Documento adjunto:")]
        public byte[] DocumentoAdjunto { get; set; } = null;

        public string UsuarioCreacion { get; set; } = string.Empty;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public string UsuarioModificacion { get; set; } = string.Empty;
 
        public DateTime FechaModificacion { get; set; } = DateTime.Now;

    }
}