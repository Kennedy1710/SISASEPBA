using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SISASEPBA.Capa_Datos;

namespace SISASEPBAWs.CapaLogica
{
    public class ClsPrivilegio
    {

        #region
        private const string SpConexion = "SP_Privilegios";
        private static string _mensaje;
        #endregion

        #region Variables
        private static SqlConnection _conexion;
        #endregion

        public static Response Procesar(Privilegio obj)
        {
            try
            {
                var comando = new SqlCommand();
                _conexion = AccesoDatos.Validar_Conexion("SisAsepba", ref _mensaje);
                if (_conexion == null)
                {
                    // mensaje = "Error al encontrar la conexion proporcionada";
                    return new Response
                    {
                        IsSuccess = false,
                        Message = "Error al encontrar la conexion proporcionada"
                    };
                }
                else
                {
                    AccesoDatos.Conectar(_conexion, ref _mensaje);

                    comando.Connection = _conexion;
                    comando.CommandText = SpConexion;

                    comando.Parameters.AddWithValue("@@Accion", obj.Accion);
                    comando.Parameters.AddWithValue("@@IdPrivilegio", obj.IdPrivilegio);
                    comando.Parameters.AddWithValue("@@Alias", obj.Alias);
                    comando.Parameters.AddWithValue("@@Descripcion", obj.Descripcion);
                    comando.Parameters.AddWithValue("@@NombreConstante", obj.NombreConstante);
                    comando.Parameters.AddWithValue("@@Estado", obj.Estado);



                    var resultado = AccesoDatos.LlenarDataTable(comando, ref _mensaje);

                    //return string.IsNullOrEmpty(mensaje) ? Convert.ToBoolean(resultado.Rows[0][0] ) : false;
                    if (resultado == null || resultado.Rows.Count < 0)
                    {
                        return new Response
                        {
                            IsSuccess = false,
                            Message = "Error a la hora de realizar la consulta"
                        };
                    }

                    return new Response
                    {
                        IsSuccess = true,
                        Result = resultado.Rows[0][0]
                    };
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                return new Response
                {
                    IsSuccess = false,
                    Message = "Error a la hora de realizar la consulta, detalle del error: " + ex.Message
                };
            }
            finally
            {
                AccesoDatos.Desconectar(_conexion, ref _mensaje);
            }
        }

        public static DataSet Consultar(Privilegio obj)
        {
            try
            {
                var comando = new SqlCommand();
                _conexion = AccesoDatos.Validar_Conexion("SisAsepba", ref _mensaje);
                if (_conexion == null)
                {
                    _mensaje = "Error al encontrar la conexion proporcionada";
                    return null;
                }
                else
                {
                    AccesoDatos.Conectar(_conexion, ref _mensaje);

                    comando.Connection = _conexion;
                    comando.CommandText = SpConexion;

                    comando.Parameters.AddWithValue("@@Accion", obj.Accion);
                    comando.Parameters.AddWithValue("@@IdPrivilegio", obj.IdPrivilegio);
                    comando.Parameters.AddWithValue("@@Alias", obj.Alias);
                    comando.Parameters.AddWithValue("@@Descripcion", obj.Descripcion);
                    comando.Parameters.AddWithValue("@@NombreConstante", obj.NombreConstante);
                    comando.Parameters.AddWithValue("@@Estado", obj.Estado);


                    var resultado = AccesoDatos.LlenarDataTable(comando, ref _mensaje);
                    var ds = new DataSet();
                    ds.Tables.Add(resultado.Copy());
                    return ds;
                }

            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                return null;
            }
            finally
            {
                AccesoDatos.Desconectar(_conexion, ref _mensaje);
            }
        }


    }

}
