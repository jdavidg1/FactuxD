using MiLibreria;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FactuxD
{
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();             //Para que la aplicación se cierre cuando se cierre el formulario.
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE id_usuario=" + VentanaLogin.Codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNomAdmin.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();

            lblUsAdmin.Text = DS.Tables[0].Rows[0]["account"].ToString();

            lblCodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();


            string url = DS.Tables[0].Rows[0]["Foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);


        }
    }
}
