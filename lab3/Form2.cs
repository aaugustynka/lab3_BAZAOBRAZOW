using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        Form1 form;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            form.tytul_t = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            form.tworca_t = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.dataGrid_Add(form.tytul_t, form.tworca_t, form.rok_t, form.technika_t);
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            form.rok_t = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            form.technika_t = textBox4.Text;
        }

        public Form2(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

    }
}
