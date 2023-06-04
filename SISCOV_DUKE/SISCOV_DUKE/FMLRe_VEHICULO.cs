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
    public partial class FMLRe_VEHICULO : Form
    {
        public FMLRe_VEHICULO()
        {
            InitializeComponent();
        }
        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta();
        private void FMLRe_VEHICULO_Load(object sender, EventArgs e)
        {
            mostrarTabla();
        }
        //variables globales
        DataTable tablafactura;
        public void mostrarTabla()
        {
            tablafactura = datos.reporteVehiculoSOAT();

            dataGridView1.DataSource = tablafactura;
        }

        private void buscarfecha()
        {
            tablafactura = datos.reporteVehiculoSOATF(dtpInicio.Value.ToString("yyyy-MM-dd"), dtpFinal.Value.ToString("yyyy-MM-dd"));
            dataGridView1.DataSource = tablafactura;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarfecha();
        }
    }
}
