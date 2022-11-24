using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PRUEBA_ENGEL
{
    class CONEXION
    {

        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=LAPTOP-4U77R2PV;DATABASE=master;integrated security=true");
            cn.Open();
            return cn;
        }
    }
}
