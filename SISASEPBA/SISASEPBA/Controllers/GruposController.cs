using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SISASEPBA.ServicioAsepba;

namespace SISASEPBA.Controllers
{
    public class GruposController : Controller
    {
        private readonly ServicioAsepba.ServiceAsepbaClient _servicio = new ServiceAsepbaClient();
        // GET: Grupos
        [Authorize]
        public ActionResult Index()
        {
            var dt = _servicio.ConsultarGrupo(new Grupo
            {
                Accion = "CONSULTAR"
            });

            var usr = dt.Tables[0].AsEnumerable().Select(dataRow => new Models.Grupos
            {
                IdGrupo = dataRow.Field<int>("IDGRUPO"),
                //IdPrivilegio = dataRow.Field<string>("IDPRIVILEGIO"),
                Alias = dataRow.Field<string>("ALIAS"),
                Descripcion = dataRow.Field<string>("DESCRIPCION"),
                Estado = dataRow.Field<bool>("ESTADO"),

            }).ToList();

            return View(usr);
        }

        //public List<Models.Privilegios> Privilegios()
        //{
        //    var dt = _servicio.ConsultarPrivilegio(new Privilegio
        //    {
        //        Accion = "CONSULTAR"
        //    });

        //    var list = dt.Tables[0].AsEnumerable().Select(dataRow => new Models.Privilegios
        //    {
        //        IdPrivilegio = dataRow.Field<int>("IDPRIVILEGIO"),
        //        Alias = dataRow.Field<string>("ALIAS"),
        //        Descripcion = dataRow.Field<string>("DESCRIPCION"),
        //        NombreConstante = dataRow.Field<string>("NOMBRECONSTANTE"),
        //        Estado = dataRow.Field<bool>("ESTADO"),

        //    }).ToList();

        //    return list;
        //}

        // GET: Grupos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grupos/Create
        public ActionResult Create()
        {
            //ViewBag.Privilegios = Privilegios();
            return View();
        }

        // POST: Grupos/Create
        [HttpPost]
        public ActionResult Create(Grupo grupo)
        {
            try
            {
                var objeto = new Grupo
                {
                    Accion = "INSERTAR",
                    //IdPrivilegio = grupo.IdPrivilegio,
                    Alias = grupo.Alias,
                    Descripcion = grupo.Descripcion,
                    Estado = true
                };

                var dt = _servicio.ProcesarGrupo(objeto);

                if (dt.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Create");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Grupos/Edit/5
        public ActionResult Edit(int id)
        {
            //ViewBag.Privilegios = Privilegios();

            var dt = _servicio.ConsultarGrupo(new Grupo
            {
                Accion = "CONSULTAR_GRUPO",
                IdGrupo = id
            });

            var usr = dt.Tables[0].AsEnumerable().Select(dataRow => new Models.Grupos
            {
                IdGrupo = dataRow.Field<int>("IDGRUPO"),
                //IdPrivilegio = dataRow.Field<string>("IDPRIVILEGIO"),
                Alias = dataRow.Field<string>("ALIAS"),
                Descripcion = dataRow.Field<string>("DESCRIPCION"),
                Estado = dataRow.Field<bool>("ESTADO")
            }).FirstOrDefault();
            usr.Usuarios = GetUsuarios();
            usr.Privilegios = GetPrivilegios();
            usr.GrupoPrivilegios = GrupoPrivilegios(Convert.ToString(id));
            usr.GrupoUsuarios = GrupoUsuario(Convert.ToString(id));

            return View(usr);
        }
        //[HttpPost]
        public PartialViewResult GrupoPrivilegio(string privilegio, string grupo)
        {

            var objeto = new Grupo
            {
                Accion = "IGP",
                IdGrupo = Convert.ToInt32(grupo),
                IdPrivilegio = Convert.ToInt32(privilegio)
            };

            var dt = _servicio.ProcesarGrupo(objeto);            

            return PartialView("_TablaGrupoPrivilegio",GrupoPrivilegios(grupo));
        }
        public PartialViewResult GrupoUsuarioInsert(int usuario, int grupo)
        {

            var objeto = new Grupo
            {
                Accion = "IGU",
                IdGrupo = Convert.ToInt32(grupo),
                usuario =usuario.ToString()
            };

            var dt = _servicio.ProcesarGrupo(objeto);

            return PartialView("_TablaGrupoUsuario", GrupoUsuario(grupo.ToString()));
        }

        public PartialViewResult EliminarGrupoPrivilegio(string privilegio, string grupo)
        {

            var objeto = new Grupo
            {
                Accion = "EGP",
                IdGrupo = Convert.ToInt32(grupo),
                IdPrivilegio = Convert.ToInt32(privilegio)
            };

            var dt = _servicio.ProcesarGrupo(objeto);

            return PartialView("_TablaGrupoPrivilegio", GrupoPrivilegios(grupo));
        }
        public PartialViewResult EliminarGrupoUsuarioInsert(int usuario, int grupo)
        {

            var objeto = new Grupo
            {
                Accion = "EGU",
                IdGrupo = Convert.ToInt32(grupo),
                usuario = usuario.ToString()
            };

            var dt = _servicio.ProcesarGrupo(objeto);

            return PartialView("_TablaGrupoUsuario", GrupoUsuario(grupo.ToString()));
        }

        // POST: Grupos/Edit/5
        [HttpPost]
        public ActionResult Edit(Grupo grupo)
        {
            try
            {
                var objeto = new Grupo
                {
                    Accion = "ACTUALIZAR",
                    IdGrupo = grupo.IdGrupo,
                    //IdPrivilegio = grupo.IdPrivilegio,
                    Alias = grupo.Alias,
                    Descripcion = grupo.Descripcion,
                    Estado = grupo.Estado
                };

                var dt = _servicio.ProcesarGrupo(objeto);
                if (dt.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Edit");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Grupos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Grupos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //FH
        public List<Models.Usuario> GetUsuarios()
        {
            var dt = _servicio.ConsultarUsuarios(new Usuario { Accion = "C", UsuarioSesion = User.Identity.Name });

            var usr = dt.Tables[0].AsEnumerable().Select(dataRow => new Models.Usuario
            {
                IdUsuario = dataRow.Field<int>("IDUSUARIO"),
                CodUsuario = dataRow.Field<string>("USUARIO"),
                Nombre = dataRow.Field<string>("NOMBRE"),
                Correo = dataRow.Field<string>("CORREOELECTRONICO"),
                Empresa = dataRow.Field<string>("EMPRESA"),
                Estado = dataRow.Field<string>("ESTADO")
            }).ToList();
            return usr;
        }
        public List<Models.Privilegios> GetPrivilegios() {
            var dt = _servicio.ConsultarPrivilegio(new Privilegio
            {
                Accion = "CONSULTAR"
            });

            var usr = dt.Tables[0].AsEnumerable().Select(dataRow => new Models.Privilegios
            {
                IdPrivilegio = dataRow.Field<int>("IDPRIVILEGIO"),
                Alias = dataRow.Field<string>("ALIAS"),
                Descripcion = dataRow.Field<string>("DESCRIPCION"),
                NombreConstante = dataRow.Field<string>("NOMBRECONSTANTE"),
                Estado = dataRow.Field<bool>("ESTADO"),

            }).ToList();
            return usr;
        }
        public List<Models.Grupos> GrupoPrivilegios(string grupo) {
            var d = _servicio.ConsultarGrupo(new Grupo
            {
                Accion = "CGP",
                IdGrupo = Convert.ToInt32(grupo),
            });

            var usr = d.Tables[0].AsEnumerable().Select(dataRow => new Models.Grupos
            {
                IdGrupo = dataRow.Field<int>("IDGRUPO"),
                IdPrivilegio = dataRow.Field<int>("IDPRIVILEGIO"),
                Alias = dataRow.Field<string>("grupo"),
                Descripcion = dataRow.Field<string>("privilegio"),
                //Estado = dataRow.Field<bool>("ESTADO")
            }).ToList();
            return usr;
        }
        public List<Models.Grupos> GrupoUsuario(string grupo)
        {
            var d = _servicio.ConsultarGrupo(new Grupo
            {
                Accion = "CGU",
                IdGrupo = Convert.ToInt32(grupo),
            });

            var usr = d.Tables[0].AsEnumerable().Select(dataRow => new Models.Grupos
            {
                IdGrupo = dataRow.Field<int>("IDGRUPO"),
                IdUsuario = dataRow.Field<int>("IDUSUARIO"),
                Alias = dataRow.Field<string>("grupo"),
                Descripcion = dataRow.Field<string>("usuario"),
                //Estado = dataRow.Field<bool>("ESTADO")
            }).ToList();
            return usr;
        }
    }
}
