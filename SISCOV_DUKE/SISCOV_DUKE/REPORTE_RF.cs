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
    public partial class REPORTE_RF : Form
    {
        public REPORTE_RF()
        {
            InitializeComponent();
        }
        public CrystalReport2 Reporte = new CrystalReport2();
        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta();
        private void button1_Click(object sender, EventArgs e)
        {
            reporteFechas();
        }

        public void reporteFechas()
        {
            var tabla = datos.cristalFechaRecorriod(dtInicio.Value.ToString("yyyy-MM-dd"), dtFinal.Value.ToString("yyyy-MM-dd"));
            //string QY = "select * from formato_equipo where equi_codigo='" + comb_codigo.Text + "' ";
            Reporte.SetDataSource(tabla);
            crystalReportViewer1.ReportSource = Reporte;
            crystalReportViewer1.Refresh();
        }

        private void REPORTE_RF_Load(object sender, EventArgs e)
        {
            var tabla = datos.cristalFechaRecorriod();
            //string QY = "select * from formato_equipo where equi_codigo='" + comb_codigo.Text + "' ";
            Reporte.SetDataSource(tabla);
            crystalReportViewer1.ReportSource = Reporte;
            crystalReportViewer1.Refresh();
        }
    }
}
