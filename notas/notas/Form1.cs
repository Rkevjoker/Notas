using notas.Entidades;
using notas.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Materia;

            ClsNota datos = new ClsNota();
            Materia = asignatura.Text;
            datos.Nombre =nombre.Text;
            datos.Apellido =apellido.Text;
            datos.Lab1 = double.Parse(lab1.Text);
            datos.Lab2 = double.Parse(lab2.Text);
            datos.Lab3 = double.Parse(lab3.Text);
            datos.Parcial1 = double.Parse(parcial1.Text);
            datos.Parcial2 = double.Parse(parcial2.Text);
            datos.Parcial3 = double.Parse(parcial3.Text);
            NClsNota logic = new NClsNota();
            MessageBox.Show("Notas de la Asignatura de: " + Materia + logic.Calculo(datos));

        }

        private void lab1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
