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
    public partial class FML_CONDUCTOR : Form
    {
        public FML_CONDUCTOR()
        {
            InitializeComponent();
        }

        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta();
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtCodConductor.Text == "" && txtConductor.Text == "" && txtNumLicencia.Text == "")
            {
                MessageBox.Show("Falta datos");
            }
            else
            {
                datos.Registrarconductro(txtConductor.Text, txtNumLicencia.Text, txtCodConductor.Text,dtFVencimiento.Value);
                MessageBox.Show("Se guardo exitosamente");
                control(false);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario hijo activo
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void control(Boolean b)
        {
            txtCodConductor.Enabled = b;
            txtConductor.Enabled = b;
            txtNumLicencia.Enabled = b;
            dtFVencimiento.Enabled = b;

            txtCodConductor.Clear();
            txtConductor.Clear();
            txtNumLicencia.Clear();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            control(true);
            btnGuardar.Enabled = true;
        }

        private void FML_CONDUCTOR_Load(object sender, EventArgs e)
        {
            control(false);
        }

        private void txtCodConductor_Leave(object sender, EventArgs e)
        {
                var existe = datos.buscarConductor(txtCodConductor.Text);

            if (existe.Rows.Count > 0)
            {
                txtCodConductor.Clear();
                control(false);

                MessageBox.Show("El codigo del conductor ya se registro","VALIDACION DE DATOS");
                
            }
            else
            {
                return;
            }

        }
    }
}
