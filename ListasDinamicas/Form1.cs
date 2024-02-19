using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasDinamicas
{
    public partial class Form1 : Form
    {

        List<int> ListaEnteros = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int numero = Convert.ToInt32(textBox1.Text);
            ListaEnteros.Add(numero);

        }
        private void Mostrar()
        {
            //opcion 1 manual
            //for (int i = 0; i < ListaEnteros.Count; i++)
            //{
            //    listBox1.Items.Add(ListaEnteros[i]);
            //}

            //opcion 2 auto para combobox listbox datagrid
            listBox1.DataSource = null;
            listBox1.Refresh();
            listBox1.DataSource = ListaEnteros;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Mostrar();
        
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ListaEnteros.Sort();
            Mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero = 0;
            bool seConvirtio = int.TryParse(textBox1.Text, out numero);

            if (seConvirtio)
            {
                ListaEnteros.Remove(numero);
                Mostrar();
            }
            else
            {
                MessageBox.Show("Debe Ingresar Un Numero");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListaEnteros.Sort();
            ListaEnteros.Reverse();
            Mostrar();
        }
    }
}
