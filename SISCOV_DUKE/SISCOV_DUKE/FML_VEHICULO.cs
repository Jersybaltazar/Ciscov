
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace biblioteca_conexion
{
    public partial class FML_VEHICULO : Form
    {
        //variables
        

        biblioteca_conexion.Class1 dat = new biblioteca_conexion.Class1();
        private string rutaImagenVehiculo;
        private string rutaImagenTP;




        public FML_VEHICULO()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            
            txtTipo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCarroseria.Clear();
            txtCategoria.Clear();
            dtfabrica.Value = DateTime.Now;
            txtUbicacion.Text = "";
            lblimg.Text = "nombre de la imagen";
            lblTP.Text = "nombre de la imagen";
            pbimg.Image = null;
            pbTP.Image = null;
         //datatimepiker   
        }

        public OpenFileDialog examinar = new OpenFileDialog();
        private void btnexaminar_Click(object sender, EventArgs e)
        {
            
           
        }
        private void btnexaminarTP_Click(object sender, EventArgs e)
        {
            
        }


        private void vista_formulario_Load(object sender, EventArgs e)
        {
            control(false);
            rutaImagenVehiculo = dat.detalleConfigurable("ruta de imagen vehiculo");
            rutaImagenTP = dat.detalleConfigurable("ruta de imagen de TP");
        }
        


       public static MemoryStream ByteToImage(Byte[] array)
        {
            MemoryStream ms = new MemoryStream((byte[])array);
            return ms;
        }
        public static byte[] imageByte(Image imageln)
        {
            MemoryStream ms = new MemoryStream();
            imageln.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        private void traerdatvehiculo()
        {
            var lis = dat.buscarvehiculo(txtPlaca.Text);
            if (lis.Rows.Count > 0)
            {

                //txtPlaca.Tag = lis.Rows[0]["id_vehiculo"].ToString();
                //txtPlaca.Text = lis.Rows[0]["placa"].ToString();
                //txtTipo.Text = lis.Rows[0]["tipo"].ToString();
                //txtMarca.Text = lis.Rows[0]["marca"].ToString();
                //txtModelo.Text = lis.Rows[0]["modelo"].ToString();
                //txtCarroseria.Text = lis.Rows[0]["carroceria"].ToString();
                //txtCategoria.Text = lis.Rows[0]["categoria"].ToString();
                //txtUbicacion.Text = lis.Rows[0]["ubicacion"].ToString();
                //dtfabrica.Text = lis.Rows[0]["anio_fabrica"].ToString();

                //pbimg.Image = Image.FromFile("C:\\IMG\\vehiculos\\" + lis.Rows[0]["nombre_imagen"].ToString());
                //pbTP.Image = Image.FromFile("C:\\IMG\\TP\\" + lis.Rows[0]["tarjeta_imagen"].ToString());
                MessageBox.Show("Se encontro registro del vehiculo", "VALIDACION DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                txtPlaca.Clear();
                control(false);
            }
            else
            {
                //txtPlaca.Tag = "0";
                MessageBox.Show("No se encontro registro del vehiculo, registre los datos","VALIDACION DE DATOS",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                limpiar();
                control(true);
            }
        }
        

    private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            if(txtPlaca.Text == ""&& txtTipo.Text=="") return;
            
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "" && txtTipo.Text == "") return;
        }

        private void otraventana()
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
        private void guardarImg()
        {
            string origen = examinar.FileName;
            string destino = rutaImagenVehiculo + lblimg.Text;
            System.IO.File.Copy(origen, destino, true);
        }
        private void guardarTP()
        {
            string origen = examinar.FileName;
            string destino = rutaImagenTP + lblTP.Text;
            System.IO.File.Copy(origen, destino, true);
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            double id_vehiculo = 0;
            id_vehiculo = dat.registrarVehiculo(txtPlaca.Text, txtTipo.Text, txtMarca.Text, txtModelo.Text, txtCarroseria.Text, txtCategoria.Text, dtfabrica.Value, txtUbicacion.Text, lblimg.Text, lblTP.Text);


            if (id_vehiculo > 0)
            {
                guardarImg();
                guardarTP();
                MessageBox.Show("Datos del vehiculo registrado","VALIDACION DE DATOS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //otraventana();
                limpiar();
                control(false);
            }
            else
            {
                MessageBox.Show("No se guardo el registro del vehiculo, registre los datos","VALIDACION DE DATOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            traerdatvehiculo();
            
        }

        private void control(Boolean bandera)
        {
            txtMarca.Enabled = bandera;
            txtModelo.Enabled = bandera;
            txtCarroseria.Enabled = bandera;
            dtfabrica.Enabled = bandera;
            txtUbicacion.Enabled = bandera;
            txtTipo.Enabled = bandera;
            txtCategoria.Enabled = bandera;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreCarpeta = "C\\gato"; // Reemplazar con el nombre deseado

            // Crear carpeta si no existe
            if (!Directory.Exists(nombreCarpeta))
            {
                Directory.CreateDirectory(nombreCarpeta);
                MessageBox.Show("La carpeta se ha creado correctamente.");
            }
            else
            {
                MessageBox.Show("La carpeta ya existe.");
            }
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg; *.png;*.jpeg";
            DialogResult r = examinar.ShowDialog();
            if (r == DialogResult.Abort)
            {
                return;
            }
            if (r == DialogResult.Cancel)
            {
                return;
            }
            pbimg.Image = Image.FromFile(examinar.FileName);
            
            lblimg.Text = examinar.SafeFileName;
        }

        private void btnTP_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg; *.png;*.jpeg";
            DialogResult r = examinar.ShowDialog();
            if (r == DialogResult.Abort)
            {
                return;
            }
            if (r == DialogResult.Cancel)
            {
                return;
            }
            pbTP.Image = Image.FromFile(examinar.FileName);
            lblTP.Text = examinar.SafeFileName;
        }
    }
}
