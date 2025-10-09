using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloPrimerUsuario
    {
        public static bool VerificacionEmpresas()
        {
            bool retorno;
            string query = "SELECT * From Empresas";
            try
            {
                SqlCommand cmd = new SqlCommand(string.Format
                    (query));
                retorno = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
