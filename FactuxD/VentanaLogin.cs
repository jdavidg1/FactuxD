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
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
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

                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"])==true)       //verificar si el usuario es administrador
                    {
                        //Llamar una instancia de la ventana de administrador y ocultar la ventana actual.

                        VentanaAdmin VenAd = new VentanaAdmin();
                        this.Hide();
                        VenAd.Show();

                    }

                    else
                    {
                        VentanaUser VenUs = new VentanaUser();
                        this.Hide();
                        VenUs.Show();

                    }

                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");

            }


        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();         //Para que la aplicación se cierre cuando se cierre el formulario.
        }
    }
}
