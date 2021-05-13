using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace Krkavec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Administrator.Find();
            dataGridView2.DataSource = Hrac.Find();
            dataGridView3.DataSource = Organizator.Find();
            dataGridView4.DataSource = Trener.Find();
            dataGridView5.DataSource = Turnaj.Find();
            dataGridView6.DataSource = Tym.Find();
            dataGridView7.DataSource = TymVturnaji.Find();
            dataGridView8.DataSource = Zapas.Find();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Tym.getTymSnejviceBody());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
