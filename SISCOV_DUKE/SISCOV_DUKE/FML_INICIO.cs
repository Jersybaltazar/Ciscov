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
                MDIParent1 FRM = new MDIParent1();
                
                //FRM.Show();
                //this.Hide(); // instancia el nuevo formulario
                             // muestra el nuevo formulario
                             //this.Close(); // cierra el formulario actual (Form1)

                var mdiParent = new MDIParent1();
                mdiParent.FormClosed += MdiParent_FormClosed; // Agregar un controlador de eventos para el cierre del formulario del padre MDI
                mdiParent.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Datos incorrectos","VALIDACIÓN DE DATOS");
            }
        }

        private void MdiParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cerrar el formulario de inicio de sesión antes de cerrar el formulario del padre MDI
            this.Close();
        }
    }
}
