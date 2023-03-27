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
    public partial class ZAPIS : Form
    {
        Form1 form;

        private void button1_Click(object sender, EventArgs e)
        {
            form.dataGrid_Save(form.sciezka);
            this.Close();
        }

        public ZAPIS(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            form.sciezka = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
