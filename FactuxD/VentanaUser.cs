using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace FactuxD
{
    public partial class VentanaUser : Form
    {
        public VentanaUser()
        {
            InitializeComponent();
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();             //Para que la aplicación se cierre cuando se cierre el formulario.
        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {

            string cmd = "SELECT * FROM Usuarios WHERE id_usuario=" + VentanaLogin.Codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNomUs.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();

            lblUs.Text = DS.Tables[0].Rows[0]["account"].ToString();

            lblCodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();


            string url = DS.Tables[0].Rows[0]["Foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);

        }
    }
}
