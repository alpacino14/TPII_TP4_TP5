
namespace TP5_C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnguardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txtfoto = new System.Windows.Forms.TextBox();
            this.btnfoto = new System.Windows.Forms.Button();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.rbfem = new System.Windows.Forms.RadioButton();
            this.rbmasc = new System.Windows.Forms.RadioButton();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnguardar.Image = global::TP5_C.Properties.Resources.save_14706;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(294, 337);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(126, 44);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Agregar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.dtp_fecha);
            this.panel2.Controls.Add(this.txtfoto);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.btnfoto);
            this.panel2.Controls.Add(this.txtapellido);
            this.panel2.Controls.Add(this.txtsaldo);
            this.panel2.Controls.Add(this.rbfem);
            this.panel2.Controls.Add(this.rbmasc);
            this.panel2.Controls.Add(this.txtnombre);
            this.panel2.Controls.Add(this.Label5);
            this.panel2.Controls.Add(this.Label4);
            this.panel2.Controls.Add(this.Label3);
            this.panel2.Controls.Add(this.Label2);
            this.panel2.Controls.Add(this.Label1);
            this.panel2.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(32, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 384);
            this.panel2.TabIndex = 2;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(220, 122);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 41);
            this.dtp_fecha.TabIndex = 5;
            // 
            // txtfoto
            // 
            this.txtfoto.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfoto.Location = new System.Drawing.Point(131, 282);
            this.txtfoto.Margin = new System.Windows.Forms.Padding(2);
            this.txtfoto.Name = "txtfoto";
            this.txtfoto.Size = new System.Drawing.Size(289, 41);
            this.txtfoto.TabIndex = 15;
            // 
            // btnfoto
            // 
            this.btnfoto.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnfoto.ForeColor = System.Drawing.Color.White;
            this.btnfoto.Location = new System.Drawing.Point(13, 282);
            this.btnfoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(97, 41);
            this.btnfoto.TabIndex = 14;
            this.btnfoto.Text = "foto";
            this.btnfoto.UseVisualStyleBackColor = false;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(131, 66);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(289, 41);
            this.txtapellido.TabIndex = 13;
            this.txtapellido.Leave += new System.EventHandler(this.txtapellido_Leave);
            // 
            // txtsaldo
            // 
            this.txtsaldo.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaldo.Location = new System.Drawing.Point(131, 216);
            this.txtsaldo.Margin = new System.Windows.Forms.Padding(2);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(289, 41);
            this.txtsaldo.TabIndex = 12;
            // 
            // rbfem
            // 
            this.rbfem.AutoSize = true;
            this.rbfem.BackColor = System.Drawing.Color.Transparent;
            this.rbfem.Location = new System.Drawing.Point(283, 168);
            this.rbfem.Margin = new System.Windows.Forms.Padding(2);
            this.rbfem.Name = "rbfem";
            this.rbfem.Size = new System.Drawing.Size(120, 37);
            this.rbfem.TabIndex = 10;
            this.rbfem.TabStop = true;
            this.rbfem.Text = "Femenino";
            this.rbfem.UseVisualStyleBackColor = false;
            // 
            // rbmasc
            // 
            this.rbmasc.AutoSize = true;
            this.rbmasc.BackColor = System.Drawing.Color.Transparent;
            this.rbmasc.Location = new System.Drawing.Point(109, 168);
            this.rbmasc.Margin = new System.Windows.Forms.Padding(2);
            this.rbmasc.Name = "rbmasc";
            this.rbmasc.Size = new System.Drawing.Size(129, 37);
            this.rbmasc.TabIndex = 2;
            this.rbmasc.TabStop = true;
            this.rbmasc.Text = "Masculino";
            this.rbmasc.UseVisualStyleBackColor = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(131, 11);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(289, 41);
            this.txtnombre.TabIndex = 5;
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(18, 223);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(77, 34);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Saldo";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(18, 171);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 34);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Sexo";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(19, 123);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(189, 34);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Fecha Nacimiento";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(19, 68);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 34);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Apellido";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(19, 14);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(91, 34);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP5_C.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(536, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.FechaNacimiento,
            this.Sexo,
            this.Eliminar,
            this.Saldo,
            this.Foto,
            this.Ruta});
            this.dataGridView1.Location = new System.Drawing.Point(32, 458);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP5_C.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(974, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario con Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.TextBox txtfoto;
        internal System.Windows.Forms.Button btnfoto;
        internal System.Windows.Forms.TextBox txtapellido;
        internal System.Windows.Forms.TextBox txtsaldo;
        internal System.Windows.Forms.RadioButton rbfem;
        internal System.Windows.Forms.RadioButton rbmasc;
        internal System.Windows.Forms.TextBox txtnombre;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
    }
}

