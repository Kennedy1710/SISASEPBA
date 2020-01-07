using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SISASEPBA.Models
{
    public class APContratacion
    {

        public string Accion { get; set; } = string.Empty;

        public int IdAccionPersonal { get; set; } = 0;

        public string IdTipoAP { get; set; } = "0";

        [DisplayName("Departamento: ")]
        public string IdDepartamento { get; set; } = "0";

        [DisplayName("Puesto: ")]
        public string IdPuesto { get; set; } = "0";

        [DisplayName("Nómina: ")]
        public string IdNomina { get; set; } = "0";

        [DisplayName("Forma de pago: ")]
        public string IdFormaPago { get; set; } = "0";

        [DisplayName("Régimen vacacional: ")]
        public string IdRegimenVacacional { get; set; } = "0";

        [DisplayName("Nacionalidad: ")]
        public string IdNacionalidad { get; set; } = "0";

        public string IdEmpleado { get; set; } = "0";

        [DisplayName("Fecha de ingreso: ")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public DateTime FechaRige { get; set; } = DateTime.Now;

        [DisplayName("Fecha de salida: ")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public DateTime FechaVence { get; set; } = DateTime.Now;

        [DisplayName("Ahorro en la asociación: ")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "¡Debe ingresar un número!")]
        public decimal AhorroAsociacion { set; get; } = 0;

        [DisplayName("Código del empleado:")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Debe ingresar entre 3 y 10 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string CodigoEmpleado { set; get; } = String.Empty;

        [DisplayName("Primer nombre del empleado:")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Excede el máximo de caracteres permitidos")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string EmpleadoPrimerNombre { set; get; } = string.Empty;

        [DisplayName("Segundo nombre del empleado:")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Excede el máximo de caracteres permitidos")]
        public string EmpleadoSegundoNombre { set; get; } = string.Empty;

        [DisplayName("Primer apellido del empleado:")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Excede el máximo de caracteres permitidos")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string EmpleadoPrimerApellido { set; get; } = string.Empty;

        [DisplayName("Segundo apellido del empleado:")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Excede el máximo de caracteres permitidos")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string EmpleadoSegundoApellido { set; get; } = string.Empty;

        [DisplayName("Tipo de identificación:")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string TipoIdentificacion { set; get; } = string.Empty;

        [DisplayName("Número de identificación:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "¡Debe ingresar un número!")]
        public int NumeroIdentificacion { set; get; } = 0;

        [DisplayName("Teléfono principal:")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Número de dígitos incorrecto.")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Número de teléfono inválido.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string TelefonoPrincipal { set; get; } = string.Empty;

        [DisplayName("Teléfono secundario:")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Número de dígitos incorrecto.")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Número de teléfono inválido.")]
        public string TelefonoSecundario { set; get; } = string.Empty;

        [DisplayName("Teléfono de emergencia:")]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "Excede el máximo de caracteres permitidos")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Número de teléfono inválido.")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string TelefonoEmergencia { set; get; } = string.Empty;

        [DisplayName("Contacto de emergencia:")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Excede el máximo de caracteres permitidos")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string ContactoEmergencia { set; get; } = string.Empty;

        [DisplayName("Tipo de sangre:")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Excede el máximo de caracteres permitidos")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string TipoSangre { set; get; } = string.Empty;

        [DisplayName("Fecha de nacimiento:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public DateTime FechaNacimiento { set; get; } = DateTime.Now;

        [StringLength(150, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [DisplayName("Dirección de domicilio:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string DireccionDomicilio { set; get; } = string.Empty;

        [StringLength(2, MinimumLength = 1, ErrorMessage = "Ejemplo de formato: M/F o MA/FE ")]
        [DisplayName("Sexo:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string Sexo { set; get; } = string.Empty;

        [StringLength(20, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [DisplayName("Estado civil:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string EstadoCivil { get; set; } = string.Empty;

        [DisplayName("Estado:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string Estado { get; set; } = string.Empty;

        public string SubEstado { set; get; } = string.Empty;

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Excede el máximo de caracteres permitidos")]
        [DisplayName("Correo electrónico:")]
        [EmailAddress(ErrorMessage = "¡Dirección de correo inválida!")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string CorreoElectronico { set; get; } = string.Empty;

        [DisplayName("Conyugue dependiente:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public bool ConyugeDependiente { set; get; } = false;

        [DisplayName("Hijos dependientes:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "¡Debe ingresar un número!")]
        public int HijosDependientes { set; get; } = 0;

        [DisplayName("Número de asegurado:")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "Excede el máximo de caracteres permitidos")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string NumeroAsegurado { set; get; } = string.Empty;

        [DisplayName("Salario referencia:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "¡Debe ingresar un número!")]
        public int SalarioReferencia { set; get; } = 0;

        public byte[] Foto { set; get; } = null;

        [StringLength(150, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [DisplayName("Observaciones generales:")]
        [Required(ErrorMessage = "¡Campo requerido!")]
        public string ObservacionesGenerales { set; get; } = string.Empty;

        [StringLength(150, MinimumLength = 3, ErrorMessage = "Debe ingresar al menos 3 caracteres.")]
        [DisplayName("Observaciones de acción de personal:")]
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