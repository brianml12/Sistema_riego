using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAORegistro
    {
        public bool agregar(DatosRiego objDatosRiego)
        {
            try
            {
                if (Conexion.conectar())
                {
                    string query = "INSERT INTO Prueba VALUES (@HoraActual, @PorcentajeHumedad, @Descripcion);";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@HoraActual", objDatosRiego.fechaActual);
                    comando.Parameters.AddWithValue("@PorcentajeHumedad", objDatosRiego.porcentajeHumedad);
                    comando.Parameters.AddWithValue("@Descripcion", objDatosRiego.descripcion);
                    comando.Connection = Conexion.conexion;
                    comando.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
