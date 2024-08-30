
namespace TP4_C
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
            this.btnprimos = new System.Windows.Forms.Button();
            this.btnImpares = new System.Windows.Forms.Button();
            this.btnpares = new System.Windows.Forms.Button();
            this.lbnum = new System.Windows.Forms.ListBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.txthasta = new System.Windows.Forms.TextBox();
            this.txtdesde = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnprimos
            // 
            this.btnprimos.Location = new System.Drawing.Point(108, 288);
            this.btnprimos.Name = "btnprimos";
            this.btnprimos.Size = new System.Drawing.Size(110, 23);
            this.btnprimos.TabIndex = 19;
            this.btnprimos.Text = "Numeros Primos ";
            this.btnprimos.UseVisualStyleBackColor = true;
            this.btnprimos.Click += new System.EventHandler(this.btnprimos_Click);
            // 
            // btnImpares
            // 
            this.btnImpares.Location = new System.Drawing.Point(108, 235);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(110, 23);
            this.btnImpares.TabIndex = 18;
            this.btnImpares.Text = "Numeros Impares";
            this.btnImpares.UseVisualStyleBackColor = true;
            this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
            // 
            // btnpares
            // 
            this.btnpares.Location = new System.Drawing.Point(108, 191);
            this.btnpares.Name = "btnpares";
            this.btnpares.Size = new System.Drawing.Size(110, 23);
            this.btnpares.TabIndex = 17;
            this.btnpares.Text = "Numeros Pares";
            this.btnpares.UseVisualStyleBackColor = true;
            this.btnpares.Click += new System.EventHandler(this.btnpares_Click);
            // 
            // lbnum
            // 
            this.lbnum.FormattingEnabled = true;
            this.lbnum.Location = new System.Drawing.Point(297, 50);
            this.lbnum.Name = "lbnum";
            this.lbnum.Size = new System.Drawing.Size(192, 264);
            this.lbnum.TabIndex = 16;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(341, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Lista de Numeros";
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(108, 139);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(110, 23);
            this.btngenerar.TabIndex = 14;
            this.btngenerar.Text = "Generar Funcion";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(118, 87);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(100, 20);
            this.txthasta.TabIndex = 13;
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(118, 50);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(100, 20);
            this.txtdesde.TabIndex = 12;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(53, 95);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Hasta";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(50, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Desde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 391);
            this.Controls.Add(this.btnprimos);
            this.Controls.Add(this.btnImpares);
            this.Controls.Add(this.btnpares);
            this.Controls.Add(this.lbnum);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.txthasta);
            this.Controls.Add(this.txtdesde);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnprimos;
        internal System.Windows.Forms.Button btnImpares;
        internal System.Windows.Forms.Button btnpares;
        internal System.Windows.Forms.ListBox lbnum;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btngenerar;
        internal System.Windows.Forms.TextBox txthasta;
        internal System.Windows.Forms.TextBox txtdesde;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

