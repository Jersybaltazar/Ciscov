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
    public partial class FMLRe_ORDEN : Form
    {
        public FMLRe_ORDEN()
        {
            InitializeComponent();
        }

        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta();

        DataTable listaordenfactura;

        private void FMLRe_ORDEN_Load(object sender, EventArgs e)
        {
            llenartabla();
            

        }

        private void dgvOrdenFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            buscarfecha();
        }

        private void llenartabla()
        {
            listaordenfactura = datos.reporteOrdenfactura();

            dgvOrdenFactura.DataSource = listaordenfactura;
        }

        private void buscarfecha()
        {
            listaordenfactura = datos.reporteOrdenfacturafecha(dtpInicio.Value.ToString("yyyy-MM-dd"), dtpFinal.Value.ToString("yyyy-MM-dd"));
            dgvOrdenFactura.DataSource = listaordenfactura;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
