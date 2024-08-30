using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cargar la imagen en el PictureBox  
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                    // Mostrar la ruta en el TextBox  
                    txtfoto.Text = openFileDialog.FileName;
                }
            }

        } //fin evento click del boton foto

        //Metodo para cambiar la mayuscula de la primera letra del texbox
        private void cambiarMayuTextbox(TextBox txt)
        {
            if (txt.Text.Length > 0)
            {
                txt.Text = char.ToUpper(txt.Text[0]) + txt.Text.Substring(1).ToLower();
            }
        } //fin metodo para cambiar la letra de texbox 
        
        
        //cuando el control sale del campo nombre
        private void txtnombre_Leave(object sender, EventArgs e)
        {
            cambiarMayuTextbox(txtnombre);
        } // fin evento cuando deja el campo nombre

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            cambiarMayuTextbox(txtapellido);
        }

       
        //evento cuando carga el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar el DataGridView column styles  
            dataGridView1.Columns["Nombre"].DefaultCellStyle.Font = new Font("Papyrus", 12, FontStyle.Bold);
            dataGridView1.Columns["Apellido"].DefaultCellStyle.Font = new Font("Papyrus", 12, FontStyle.Bold);

            //Agregar datos al dgv manualmente para probar
            dataGridView1.Rows.Add("Batista", "María", "12/05/2014", "Mujer", "Eliminar", 340, null , "TP5 C/Foto1.jpg");
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


        } //fin evento cuando carga el formulario


        //PARA CARGAR IMAGEN AL dgv
        private void LoadImages()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Foto"].Value != null)
                {
                    row.Cells["Foto"].Value = Image.FromFile(row.Cells["Ruta"].Value.ToString());
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Suponiendo que ya has vinculado el DataGridView con un BindingList o DataTable  
            var saldo = decimal.Parse(txtsaldo.Text); //convertimos
            var row = new DataGridViewRow();
            row.CreateCells(dataGridView1, 
                            txtnombre.Text, 
                            txtapellido.Text, 
                            dtp_fecha.Text, 
                            rbmasc.Checked ? "Hombre" : "Mujer", 
                            "Eliminar",
                            saldo,
                            pictureBox1.Image, // Ajusta el ancho según sea necesario // Asegúrate de que la imagen esté cargada  
                            txtfoto.Text
                            );

            // Agregar la fila al DataGridView  
            dataGridView1.Rows.Add(row);

            // Verificar saldo y cambiar color  
            if (saldo < 100)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
            }
            
        }


        //evento del dgv para eliminar la fila  seleccionado
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                DialogResult result;

                if (dataGridView1.CurrentRow != null)
                {
                    result = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        } //fin evento click de la celda eliminar

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Foto"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);
                if (e.Value != null)
                {
                    Image img = (Image)e.Value;
                    // Ajustar el tamaño de la imagen  
                    Rectangle imageRect = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2, e.CellBounds.Width - 4, e.CellBounds.Height - 4);
                    e.Graphics.DrawImage(img, imageRect);
                }
                e.Handled = true;
            }
        }



    }
}
