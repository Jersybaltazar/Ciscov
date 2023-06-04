
namespace biblioteca_conexion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dbgvehiculo = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnregresar = new FontAwesome.Sharp.IconButton();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.lblbc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbgvehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // dbgvehiculo
            // 
            this.dbgvehiculo.AllowUserToDeleteRows = false;
            this.dbgvehiculo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dbgvehiculo.ColumnHeadersHeight = 29;
            this.dbgvehiculo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dbgvehiculo.Location = new System.Drawing.Point(13, 90);
            this.dbgvehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.dbgvehiculo.Name = "dbgvehiculo";
            this.dbgvehiculo.ReadOnly = true;
            this.dbgvehiculo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dbgvehiculo.RowHeadersWidth = 51;
            this.dbgvehiculo.Size = new System.Drawing.Size(1851, 491);
            this.dbgvehiculo.TabIndex = 4;
            this.dbgvehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "foto";
            //this.dataGridViewImageColumn1.Image = global::vista.Properties.Resources.eliminar;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnregresar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnregresar.IconColor = System.Drawing.Color.Black;
            this.btnregresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregresar.IconSize = 38;
            this.btnregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregresar.Location = new System.Drawing.Point(1713, 29);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(152, 53);
            this.btnregresar.TabIndex = 5;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplaca.Location = new System.Drawing.Point(13, 29);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(292, 30);
            this.txtplaca.TabIndex = 8;
            this.txtplaca.TextChanged += new System.EventHandler(this.txtplaca_TextChanged);
            // 
            // lblbc
            // 
            this.lblbc.AutoSize = true;
            this.lblbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbc.Location = new System.Drawing.Point(322, 29);
            this.lblbc.Name = "lblbc";
            this.lblbc.Size = new System.Drawing.Size(101, 25);
            this.lblbc.TabIndex = 9;
            this.lblbc.Text = "BUSCAR";
            this.lblbc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1877, 575);
            this.Controls.Add(this.lblbc);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.dbgvehiculo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgvehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dbgvehiculo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private FontAwesome.Sharp.IconButton btnregresar;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label lblbc;
    }
}

