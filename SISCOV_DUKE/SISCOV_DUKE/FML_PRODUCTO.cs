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
    public partial class FML_PRODUCTO : Form
    {
        public FML_PRODUCTO()
        {
            InitializeComponent();
        }

        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta();

        private void FML_PRODUCTO_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtCodProducto.Text == "" && txtProducto.Text == "" && txtStock.Text == "")
            {
                MessageBox.Show("Falta datos");
            }
            else
            {
                datos.Registrarproducto(txtProducto.Text, txtStock.Text, txtCodProducto.Text);
                MessageBox.Show("Se guardo exitosamente");
            }
            
        }

        private void cbNumfactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
