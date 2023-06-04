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
    public partial class REPORT : Form
    {
        public REPORT()
        {
            InitializeComponent();
        }
        public CrystalReport1 Reporte = new CrystalReport1();


        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta();
        private void button1_Click(object sender, EventArgs e)
        {
            var tabla = datos.cristalOrdenfactura(dtInicio.Value.ToString("yyyy-MM-dd"), dtFinal.Value.ToString("yyyy-MM-dd"));
            //string QY = "select * from formato_equipo where equi_codigo='" + comb_codigo.Text + "' ";
            Reporte.SetDataSource(tabla);
            crystalReportViewer1.ReportSource = Reporte;
            crystalReportViewer1.Refresh();
        }

        private void REPORT_Load(object sender, EventArgs e)
        {

        }
    }
}
