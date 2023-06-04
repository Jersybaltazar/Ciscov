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
    public partial class FRMLRe_OrdenVehiculoConductor : Form
    {
        public FRMLRe_OrdenVehiculoConductor()
        {
            InitializeComponent();
        }

        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta();
        private DataTable tablafactura;
        private void FRMLRe_OrdenVehiculoConductor_Load(object sender, EventArgs e)
        {
            mostrarTabla();
        }

        public void mostrarTabla()
        {
            tablafactura = datos.reporteORDENDATOS();

            dataGridView1.DataSource = tablafactura;
        }


    }
}
