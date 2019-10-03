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
using MiLibreria;
using System.Data;              //Para poder utilizar las variables dataset.

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
                //Crear la consulta, nombre de cuenta
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password= '{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();         //El cero en las columnas es porque devuelve un solo usuario
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                //Luego viene la comparación

                if(cuenta==txtNomAcc.Text.Trim() && contra==txtPass.Text.Trim())
                {

                    MessageBox.Show("Se ha iniciado");

                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");

            }


        }
    }
}
