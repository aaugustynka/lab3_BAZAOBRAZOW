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
    public partial class Form4 : Form
    {
        Form1 form;

        private void button1_Click(object sender, EventArgs e)
        {
            form.dataGrid_Load(form.sciezka);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            form.sciezka = textBox1.Text;
        }
        public Form4(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

    }
}
