using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca_conexion
{
    public partial class Form1 : Form
    {
        biblioteca_conexion.Class1 datos = new biblioteca_conexion.Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }
        private void traerimg()
        {
            var list = datos.cargarGrid();
            dbgvehiculo.DataSource = list;
            dbgvehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void filtrar()
        {
            if (txtplaca.Text!="")
            {
                dbgvehiculo.DataSource= datos.filtrar(txtplaca.Text);
            }
            else
            {
                var list = datos.cargarGrid();
                dbgvehiculo.DataSource = list;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            traerimg();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FML_VEHICULO frm = new FML_VEHICULO();
            frm.Show();
        }


        private void btnfilter_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void txtplaca_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }
    }
}
