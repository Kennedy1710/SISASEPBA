using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SISASEPBA.ServicioAsepba;

namespace SISASEPBA.Controllers
{
    public class PrivilegiosController : Controller
    {
        private readonly ServicioAsepba.ServiceAsepbaClient _servicio = new ServiceAsepbaClient();
        // GET: Privilegios
        [Authorize]
        public ActionResult Index()
        {
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

            return View(usr);
        }

        // GET: Privilegios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Privilegios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Privilegios/Create
        [HttpPost]
        public ActionResult Create(Privilegio privilegio)
        {
            try
            {
                var objeto = new Privilegio
                {
                    Accion = "INSERTAR",
                    Alias = privilegio.Alias,
                    Descripcion = privilegio.Descripcion,
                    NombreConstante = privilegio.NombreConstante,
                    Estado = true,
                };

                var dt = _servicio.ProcesarPrivilegio(objeto);

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

        // GET: Privilegios/Edit/5
        public ActionResult Edit(int id)
        {
            var dt = _servicio.ConsultarPrivilegio(new Privilegio
            {
                Accion = "CONSULTAR_PRIVILEGIO",
                IdPrivilegio = id
            });

            var usr = dt.Tables[0].AsEnumerable().Select(dataRow => new Models.Privilegios
            {
                IdPrivilegio = dataRow.Field<int>("IDPRIVILEGIO"),
                Alias = dataRow.Field<string>("ALIAS"),
                Descripcion = dataRow.Field<string>("DESCRIPCION"),
                NombreConstante = dataRow.Field<string>("NOMBRECONSTANTE"),
                Estado = dataRow.Field<bool>("ESTADO")
            }).FirstOrDefault();

            return View(usr);
        }

        // POST: Privilegios/Edit/5
        [HttpPost]
        public ActionResult Edit(Privilegio privilegio)
        {
            try
            {
                var objeto = new Privilegio
                {
                    Accion = "ACTUALIZAR",
                    IdPrivilegio = privilegio.IdPrivilegio,
                    Alias = privilegio.Alias,
                    Descripcion = privilegio.Descripcion,
                    NombreConstante = privilegio.NombreConstante,
                    Estado = privilegio.Estado
                };

                var dt = _servicio.ProcesarPrivilegio(objeto);
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

        // GET: Privilegios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Privilegios/Delete/5
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
    }
}
