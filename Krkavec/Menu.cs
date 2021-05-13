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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void b_prihlasit_do_turnaje_Click(object sender, EventArgs e)
        {
            PrihlaseniDoTurnaje p = new PrihlaseniDoTurnaje();
            p.Show();
        }

        private void b_data_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turnaj.PripsatBody();
            MessageBox.Show("Body pripsany");
        }

        private void b_upravit_Click(object sender, EventArgs e)
        {
            Upravit u = new Upravit();
            u.Show();
        }

        private void b_pridat_Click(object sender, EventArgs e)
        {
            Pridat p = new Pridat();
            p.Show();
        }
    }
}
