using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;        //Permite utilizar las variables de conexión

namespace FactuxD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source=LAPTOP-9VN6QT9R\\SQLEXPRESS;Initial Catalog=Administracion;Integrated Security=True");
                Con.Open();
                MessageBox.Show("La conexión fue exitosa");
            }
            catch(Exception Error)
            {

                MessageBox.Show("Se ha producido un error: " + Error.Message);

            }

        }
    }
}
