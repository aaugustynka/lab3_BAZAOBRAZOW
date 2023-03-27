using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public string rok_t, technika_t, sciezka, tytul_t, tworca_t ;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            bool empty = true;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                empty = true;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if(cell.Value != null)
                        empty = false;
                }
                if(empty == false)
                    dataGridView1.Rows.RemoveAt(row.Index);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Form4 form4 = new Form4(this);
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            ZAPIS form3 = new ZAPIS(this);
            form3.ShowDialog();

        }

        public void dataGrid_Add(string tytul, string tworca, string rok, string technika)
        {
            dataGridView1.Rows.Add(new object[] { tytul, tworca, rok, technika });
            tytul_t = ""; tworca_t = ""; rok_t = ""; technika_t = "";
        }

        public void dataGrid_Save(string sciezka)
        {
            label1.Text = "";
            int l = 0;bool empty = true;
            try
            {
                StreamWriter sw = new StreamWriter(sciezka, true, Encoding.ASCII);
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    l = 0;
                    empty = true;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                            empty = false;
                    }
                    if (empty == false)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (l == 0)
                                sw.Write(cell.Value);
                            else
                                sw.Write("," + cell.Value);
                            l++;
                        }
                        sw.Write("\n");
                    }
                }
                sw.Close();
            }
            catch(Exception e)
            {
                label1.Text = e.Message;
            }
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dataGrid_Load(string sciezka)
        {
            label1.Text = "";
            try
            {
                string[] lines = System.IO.File.ReadAllLines(sciezka);
                foreach (string line in lines)
                {
                    string[] cells = line.Split(',');
                    dataGridView1.Rows.Add(new object[] { cells[0], cells[1], cells[2], cells[3] });
                }
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
