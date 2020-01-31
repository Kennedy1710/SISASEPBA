﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SISASEPBA.Models
{
    public class APCambioDeIdentificacion
    {

        public string Accion { get; set; } = string.Empty;
        
        public int IdAccionPersonal { get; set; } = 0;
        
        public int IdTipoAP { get; set; } = 0;
        
        public int IdEmpleado { get; set; } = 0;

        [DisplayName("Nacionalidad: ")]
        public string IdNacionalidad { get; set; } = string.Empty;

        //[StringLength(150, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        [DisplayName("Tipo de identificación: ")]
        public string TipoIdentificacion { get; set; } = string.Empty;

        [DisplayName("Número de identificación: ")]
        //[RegularExpression(@"([0-9]+)", ErrorMessage = "¡Debe ingresar un número!")]
        public int NumeroIdentificacion { get; set; } = 0;

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