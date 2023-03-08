using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCOV_DUKE
{
    public partial class FML_INICIO : Form
    {
        public FML_INICIO()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "ADMIN" && txtContraseña.Text == "2023")
            {
                MessageBox.Show("Inicio sesión exitoso","VALIDACIÓN DE DATOS");
                Form1 form_principal = new Form1(); // instancia el nuevo formulario
                form_principal.Show(); // muestra el nuevo formulario
                //this.Close(); // cierra el formulario actual (Form1)
            }
            else
            {
                MessageBox.Show("Datos incorrectos","VALIDACIÓN DE DATOS");
            }
        }
    }
}
