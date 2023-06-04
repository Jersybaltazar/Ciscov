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
    public partial class REPORT_G : Form
    {
        public REPORT_G()
        {
            InitializeComponent();
        }
        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta();
        public RECORRIDO_G CR = new RECORRIDO_G();
        private void REPORT_G_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }
        DataTable tabla;
        public void buscar()
        {
            if (dtpinicio.Text != "" && dtpfin.Text != "")
            {
                tabla = datos.reporteOrdenfacturaCR(dtpinicio.Value.ToString("yyyy-MM-dd"), dtpfin.Value.ToString("yyyy-MM-dd"));
                CR.SetDataSource(tabla);
                VistaRECORRIDO_GALON.ReportSource = CR;
                VistaRECORRIDO_GALON.Refresh();
            }
            else
            {
                var Dat = datos.reporteOrdenfacturaCRy();
                CR.SetDataSource(Dat);
                VistaRECORRIDO_GALON.ReportSource = CR;
                VistaRECORRIDO_GALON.Refresh();
            }
            
        }
    }
}
