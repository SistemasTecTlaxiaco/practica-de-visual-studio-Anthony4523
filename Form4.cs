using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Renta_de_Locales
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\img\1.png");
            button1.Image = imagen;

            Bitmap imagen2 = new Bitmap(Application.StartupPath + @"\img\2.png");
            button2.Image = imagen2;

            Bitmap imagen3 = new Bitmap(Application.StartupPath + @"\img\3.png");
            button3.Image = imagen3;

            Bitmap imagen4 = new Bitmap(Application.StartupPath + @"\img\4.png");
            button4.Image = imagen4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form7();
            formulario.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form8();
            formulario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5 ();
            formulario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9();
            formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Form10();
            formulario.Show();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localesEnRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5();
            formulario.Show();
        }

        private void mensajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
