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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            txtOrCredito.Clear();
            txtKM.Clear();
            txtGalones.Clear();
            txtPreGalon.Clear();
            txtImporte.Clear();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculo()
        {
            double precio_galon = Math.Round(double.Parse(txtImporte.Text) / double.Parse(txtGalones.Text),4);
            txtPreGalon.Text = precio_galon.ToString();
            
        }

        #region codigo que no sirve
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtGalones.Text == "") return;
            if (txtImporte.Text == "") return;
            Calculo();

        }

        private void txtGalones_TextChanged(object sender, EventArgs e)
        {
            if (txtImporte.Text == "") return;
            if (txtGalones.Text == "") return;
            Calculo();
        }
    }
}
