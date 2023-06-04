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
    public partial class reporteGalon : Form
    {
        public reporteGalon()
        {
            InitializeComponent();
        }

        biblioteca_conexion.Consulta datos = new biblioteca_conexion.Consulta(); 

        public CryRepGalon  cr_Galon = new CryRepGalon();
        private void button1_Click(object sender, EventArgs e)
        {
            var data = datos.reporteGalonPlacaCRy();
            cr_Galon.SetDataSource(data);
            crystalReportViewer1.ReportSource = cr_Galon;
            crystalReportViewer1.Refresh();
        }

        private void btnlupa_Click(object sender, EventArgs e)
        {
            {
                if (txtBuscarPlaca.Text != "")
                {
                    var tabla = datos.buscarGalonCR(txtBuscarPlaca.Text);
                    cr_Galon.SetDataSource(tabla);
                    crystalReportViewer1.ReportSource = cr_Galon;
                    crystalReportViewer1.Refresh();
                }
                else
                {
                    var Dat = datos.reporteGalonPlacaCRy();
                    cr_Galon.SetDataSource(Dat);
                    crystalReportViewer1.ReportSource = cr_Galon;
                    crystalReportViewer1.Refresh();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        DataTable tablafactura;

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            tablafactura = datos.buscarGalonFecha(dtpInicio1.Value.ToString("yyyy-MM-dd"), dtpFinal1.Value.ToString("yyyy-MM-dd"));
            cr_Galon.SetDataSource(tablafactura);
            crystalReportViewer1.ReportSource = cr_Galon;
            crystalReportViewer1.Refresh();
        }

        private void reporteGalon_Load(object sender, EventArgs e)
        {

        }
    }
}
