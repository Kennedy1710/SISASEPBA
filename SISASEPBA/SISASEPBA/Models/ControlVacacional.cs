using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISASEPBA.Models
{
    public class ControlVacacional
    {
        public string Accion { get; set; } = string.Empty;

        public int IdRegimenVacacional { get; set; } = 0;

        [DisplayName("Alias:")]
        [StringLength(6, MinimumLength = 3, ErrorMessage = "Debe ingresar entre 3 y 6 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string Alias { get; set; } = string.Empty;

        [DisplayName("Descripción:")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string Descripcion { get; set; } = string.Empty;


        [DisplayName("Tipo de acción de personal")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string IdTipoAP { get; set; } = string.Empty;

        public bool Estado { get; set; } = false;

        [DisplayName("Días acumulados:")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "¡Debe ingresar un número!")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public int DiasAcuMes { get; set; } = 0;

        [DisplayName("Días restados:")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "¡Debe ingresar un número!")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public int DiasRestados { get; set; } = 0;

        [DisplayName("¿Incluir sábados?")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public bool IncluirSabados { get; set; } = false;

        [DisplayName("¿Incluir domingos?")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public bool IncluirDomingos { get; set; } = false;

        public string UsuarioCreacion { get; set; } = string.Empty;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public string UsuarioModificacion { get; set; } = string.Empty;

        public DateTime FechaModificacion { get; set; } = DateTime.Now;
    }
}