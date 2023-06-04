using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca_conexion
{
    public partial class FML_SOAT : Form
    {

        //variables

        biblioteca_conexion.Class1 data = new biblioteca_conexion.Class1();
        public OpenFileDialog examinar = new OpenFileDialog();

        FML_VEHICULO vf = new FML_VEHICULO();
        
        DataTable listaVehiculo;



        public FML_SOAT()
        {
            InitializeComponent();
        }

  
        public void cargarVehiculo()
        {
            listaVehiculo = data.cargarVehiculo();
            cbVehiculo.DataSource = listaVehiculo;
            cbVehiculo.DisplayMember = "placa";
            cbVehiculo.ValueMember = "id_vehiculo";
        }

        private void FML_SOAT_Load(object sender, EventArgs e)
        {
            cargarVehiculo();
            control(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            traerdatsoat();
        }


        private void traerdatsoat()
        {
            var lis = data.filtrarSOAT(txtCerti.Text);
            if (lis.Rows.Count > 0)
            {
                
                MessageBox.Show("El número de certificado ya esta registrado", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control(false);
            }
            else
            {
                
                MessageBox.Show("El certificado no existe, registre los nuevos datos");
                limpiar();
                control(true);
            }
        }
        private void limpiar()
        {

            cbSeguro.Text = "";
            cbVehiculo.Text = "";
            dtinicio.Value = DateTime.Now;
            dtvencimiento.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idVehiculo = int.Parse(cbVehiculo.SelectedValue.ToString()); //idVehiculo

            if (txtCerti.Text == "" || cbVehiculo.Text == "OTROS")
            {
                MessageBox.Show("No se puede guardar datos vacios y el vehiculo OTROS","VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data.guardarSOAT(txtCerti.Text, dtinicio.Value, dtvencimiento.Value, cbSeguro.Text, idVehiculo);
                MessageBox.Show("se guardo los datos del SOAT", "REGISTRO DE DATOS DEL SOAT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
                control(false);
            }

            
            
        }

        private void control(Boolean bandera)
        {
            cbSeguro.Enabled = bandera;
            dtinicio.Enabled = bandera;
            dtvencimiento.Enabled = bandera;
            cbVehiculo.Enabled = bandera;
            
            dtinicio.Enabled = bandera;
            dtvencimiento.Enabled = bandera;
            cbSeguro.Enabled = bandera;
            cbVehiculo.Enabled = bandera;

        }

    }
    
    
}
