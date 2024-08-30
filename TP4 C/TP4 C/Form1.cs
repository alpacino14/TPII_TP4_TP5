using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            lbnum.Items.Clear(); // Limpiar el ListBox antes de agregar numeros  

            if (int.TryParse(txtdesde.Text, out int desde) && int.TryParse(txthasta.Text, out int hasta))
            {
                for (int i = desde; i <= hasta; i++)
                {
                    lbnum.Items.Add(i); // Agregar números al ListBox  
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos en ambos campos.");
            }
        }

        private void btnpares_Click(object sender, EventArgs e)
        {
            lbnum.Items.Clear(); // Limpiar el ListBox  

            // Validar campos  
            if (!ValidarCampos(out int desde, out int hasta))
                return;

            // Agregar números pares al ListBox  
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 == 0) // Verificar si es par  
                {
                    lbnum.Items.Add(i.ToString());
                }
            }

        } // Fin evento click boton pares



        //Funcion para validar datos
        private bool ValidarCampos(out int desde, out int hasta)
        {
            desde = 0;
            hasta = 0;

            if (string.IsNullOrWhiteSpace(txtdesde.Text) || string.IsNullOrWhiteSpace(txthasta.Text))
            {
                MessageBox.Show("Los campos desde y hasta no pueden estar vacíos. Ingrese valores.");
                return false;
            }

            if (!int.TryParse(txtdesde.Text, out desde) || !int.TryParse(txthasta.Text, out hasta))
            {
                MessageBox.Show("Por favor, ingrese solo números válidos.");
                return false;
            }

            if (desde > hasta)
            {
                MessageBox.Show("El valor desde no puede ser mayor que el valor Hasta");
                return false;
            }

            return true;
        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            lbnum.Items.Clear(); // Limpiar el ListBox  

            // Validar campos  
            if (!ValidarCampos(out int desde, out int hasta))
                return;

            // Agregar números impares al ListBox  
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 != 0) // Verificar si es impar  
                {
                    lbnum.Items.Add(i.ToString());
                }
            }

        } // Fin evento click del boton Numero impares


        //Metodo para saber si un num es primo recibe un num
        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        } // Fin metodo para detectar num primo

        private void btnprimos_Click(object sender, EventArgs e)
        {
            lbnum.Items.Clear(); // Limpiar el ListBox  

            // Validar campos  
            if (!ValidarCampos(out int desde, out int hasta))
                return;

            // Agregar números primos al ListBox  
            for (int i = desde; i <= hasta; i++)
            {
                if (EsPrimo(i))
                {
                    lbnum.Items.Add(i.ToString());
                }
            }

        }
    }
}
