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
    public partial class FML_ORDEN : Form
    {
        public FML_ORDEN()
        {
            InitializeComponent();
        }

        //VARIABLES
        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta();
        private string precioGalon;
        //private double id_lblfactura = 0;
        biblioteca_conexion.Class1 dat = new biblioteca_conexion.Class1();


        private void button1_Click(object sender, EventArgs e)
        {
            txtOrCredito.Clear();
            txtKM.Clear();
            txtGalones.Clear();
            
            txtImporte.Clear();
            btnGuardar.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargarcombos();
            precioGalon = dat.detalleConfigurable("precio por galon");

            txtPreGalon.Text = precioGalon;
            
        }

        private void Calculo()
        {
            double suma = double.Parse(txtGalones.Text) * double.Parse(txtPreGalon.Text);
            txtImporte.Text = suma.ToString();
              

        }

        #region codigo que no sirve
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtGalones_TextChanged(object sender, EventArgs e)
        {
            if (txtGalones.Text == "") return;
            if (txtPreGalon.Text == "") return;

            Calculo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //variables de los combo box
            int id_placa = int.Parse(cbPlaca.SelectedValue.ToString()); //id placa
            int id_producto = int.Parse(cbProducto.SelectedValue.ToString()); //id producto
            int id_conductor = int.Parse(cbConductor.SelectedValue.ToString()); //id conductor
            int id_factura = int.Parse(cbNumfactura.SelectedValue.ToString());//ID_FACTURA                                                                  

            if (txtOrCredito.Text == "" && txtKM.Text == "" && txtGalones.Text == "" && txtPreGalon.Text == "")
            {
                MessageBox.Show("Datos vacios");

            }
            else
            {
                datos.RegistrarOrden(id_factura, txtOrCredito.Text, id_placa, id_producto, txtKM.Text, id_conductor, dtpFechaOrden.Value.ToString("yyyy-MM-dd"),double.Parse(txtGalones.Text),double.Parse(txtPreGalon.Text),double.Parse(txtImporte.Text), txtUnidad.Text);
                MessageBox.Show("Datos guardados correctamente");

            }
            //if (lblFactura.Text == "0")
            //{
            //    //txtNumFactura.Tag = datos.Registrarfactura(txtNumFactura.Text, dtpFechaEmision.Value);
            //    //id_factura = int.Parse(txtNumFactura.Tag.ToString());

            //}
            //else
            //{
            //    //id_factura = int.Parse(lblFactura.Text);

            //}

            //datos.RegistrarOrden(id_factura, txtOrCredito.Text, id_placa, id_producto, txtKM.Text, id_conductor, dtpFechaOrden.Value, double.Parse(txtGalones.Text), double.Parse(txtPreGalon.Text), double.Parse(txtImporte.Text));
            MessageBox.Show("Se guardo exitosamente");
            limpiarcampos();

            //id_lblfactura = datos.Devolveridfactura(txtNumFactura.Text);
            //lblFactura.Text = id_lblfactura.ToString();
        }

        private void txtNumFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumFactura_Leave(object sender, EventArgs e)
        {
            //id_lblfactura = datos.Devolveridfactura(txtNumFactura.Text);
            //lblFactura.Text = id_lblfactura.ToString();
        }

        DataTable listaconductor;
        DataTable listaplaca;
        DataTable listaproducto;
        DataTable listafactura;

        private void Cargarcombos()
        {
            listaconductor = datos.tablaconductor();

            cbConductor.DataSource = listaconductor;
            cbConductor.DisplayMember = "nombre";
            cbConductor.ValueMember = "id_conductor";

            listaplaca = datos.tablaplaca();

            cbPlaca.DataSource = listaplaca;
            cbPlaca.DisplayMember = "placa";
            cbPlaca.ValueMember = "id_vehiculo";

            listaproducto = datos.tablaproducto();

            cbProducto.DataSource = listaproducto;
            cbProducto.DisplayMember = "descripcion";
            cbProducto.ValueMember = "id_producto";

            listafactura = datos.factura();

            cbNumfactura.DataSource = listafactura;
            cbNumfactura.DisplayMember = "numFactura";
            cbNumfactura.ValueMember = "id_factura";


        }

       

        private void cbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id_placa = int.Parse(cbPlaca.SelectedValue.ToString()); //id placa
            if (cbPlaca.Text == "OTROS")
            {
                txtUnidad.Visible = true;
                lblUnidad.Visible = true;
                
            }
            else
            {
                txtUnidad.Visible = false;
                lblUnidad.Visible = false;
            }
        }

        private void limpiarcampos()
        {
            txtOrCredito.Clear();
            txtKM.Clear();
            txtGalones.Clear();
            
            txtUnidad.Clear();
            txtImporte.Clear();
        }

        private void txtPreGalon_TextChanged(object sender, EventArgs e)
        {
            
            if (txtGalones.Text == "") return;
            if (txtPreGalon.Text == "") return;

            Calculo();
        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpFechaOrden_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
