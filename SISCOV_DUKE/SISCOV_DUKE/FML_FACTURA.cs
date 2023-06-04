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
    public partial class FML_FACTURA : Form
    {
        public FML_FACTURA()
        {
            InitializeComponent();
        }

        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta();
        private double valor = 0; 

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            valor = datos.Registrarfactura(txtNumFactura.Text, dtpFechaEmision.Value.ToString("yyyy-MM-dd"), double.Parse(txtImporte.Text), txtRuc.Text, txtProveedor.Text);
            if (valor > 0)
            { 
  
                MessageBox.Show("Se guardo exitosamente","REGISTRO DE DATOS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El número de factura ya existe en el sistema, ingrese otra factura","REGISTRO DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            control(false);

            
        }

        
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FML_FACTURA_Load(object sender, EventArgs e)
        {
            control(false);
        }


        private void control(Boolean b)
        {
            txtNumFactura.Enabled = b;
            txtImporte.Enabled = b;
            txtRuc.Enabled = b;
            txtProveedor.Enabled = b;
            dtpFechaEmision.Enabled = b;

            txtProveedor.Clear();
            txtImporte.Clear();
            txtRuc.Clear();
            txtNumFactura.Clear();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            control(true);
            btnGuardar.Enabled = true;
        }

        private void txtNumFactura_Leave(object sender, EventArgs e)
        {
            var existe = datos.buscarFactura(txtNumFactura.Text);

            if (existe.Rows.Count > 0)
            {
                MessageBox.Show("El número de factura ya se encuentra en el sistema, registro otro","VALIDACION DE DATOS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNumFactura.Clear();
            }

        }
    }
}
