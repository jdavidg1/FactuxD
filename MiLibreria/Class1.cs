using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public class Utilidades
    {

        public static DataSet Ejecutar(string cmd) //Desde este método se van a hacer las consultas, incersiones y demás. Como parámetro va a recibir la instrucción SQL
        {
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-9VN6QT9R\\SQLEXPRESS;Initial Catalog=Administracion;Integrated Security=True");
            Con.Open();

            DataSet DS = new DataSet();         // Creación del data set para almanacenar lo que necesito.
                                                // Se crea un data adapter para ajusta los datos 
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);                      //Se pasan por parámetro la consulta y la conexión

            DP.Fill(DS);                         //para que rellene la petición que he creado


            Con.Close();
            return DS;

        }


    }
}
