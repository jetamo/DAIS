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
    public partial class Pridat : Form
    {
        public Pridat()
        {
            InitializeComponent();
            cb_tym.DataSource = Tym.Find();
        }

        private void b_ulozit_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tb_jmeno.Text) || String.IsNullOrEmpty(tb_prijmeni.Text) || String.IsNullOrEmpty(tb_zeme.Text))
            {
                MessageBox.Show("Nevyplnene udaje.");
                return;
            }
            Hrac hrac = new Hrac(-1, tb_jmeno.Text, tb_prijmeni.Text, DateTime.Now, tb_zeme.Text, (Tym)cb_tym.SelectedItem);
            hrac.Pridat();
            MessageBox.Show("Hrac pridan.");
        }
    }
}
