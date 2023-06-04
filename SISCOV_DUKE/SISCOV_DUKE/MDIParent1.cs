using biblioteca_conexion;
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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();

        }
        


        private void cONDUCTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FML_CONDUCTOR FRM = new FML_CONDUCTOR();
            FRM.MdiParent = this;
            FRM.Show();
            //this.Hide();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void fACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FML_FACTURA FRM = new FML_FACTURA();
            FRM.MdiParent = this;
            FRM.Show();
            //this.Hide();
        }

        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FML_PRODUCTO FRM = new FML_PRODUCTO();
            FRM.MdiParent = this;
            FRM.Show();
            //this.Hide();
        }

        private void oRDENCREDITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FML_ORDEN FRM = new FML_ORDEN();
            FRM.MdiParent = this;
            FRM.Show();
            //this.Hide();
        }

        private void fACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMLRe_FACTURA FRM = new FMLRe_FACTURA();
            FRM.MdiParent = this;
            FRM.Show();
            //this.Hide();
        }

        private void oRDENCREDITOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FMLRe_ORDEN FRM = new FMLRe_ORDEN();
            FRM.MdiParent = this;
            FRM.Show();
            //this.Hide();
        }

        private void FormMDIParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cerrar todos los formularios hijos antes de cerrar el formulario del padre MDI
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void sOATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FML_SOAT FRM = new FML_SOAT();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void vEHICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FML_VEHICULO FRM = new FML_VEHICULO();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FRM = new Form1();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void oPERACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sOATToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FML_SOAT FRM = new FML_SOAT();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void vEHICULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FML_VEHICULO FRM = new FML_VEHICULO();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void vEHICULOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FMLRe_VEHICULO FRM = new FMLRe_VEHICULO();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void vEHICULOCONDUCTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMLRe_OrdenVehiculoConductor FRM = new FRMLRe_OrdenVehiculoConductor();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void gASFECHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORT FRM = new REPORT();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void fECHARECORRIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORTE_RF FRM = new REPORTE_RF();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void rECORRIDOGALONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORT_G FRM = new REPORT_G();
            FRM.MdiParent = this;
            FRM.Show();
        }

        private void gALONESVEHICULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteGalon FRM = new reporteGalon();
            FRM.MdiParent = this;
            FRM.Show();
        }
    }
}
