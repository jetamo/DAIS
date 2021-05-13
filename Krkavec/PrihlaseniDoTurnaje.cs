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
    public partial class PrihlaseniDoTurnaje : Form
    {
        int turnaj_id = -1;
        public PrihlaseniDoTurnaje()
        {
            InitializeComponent();
            lb_turnaje.DataSource = Turnaj.Find();
            l_uzivatel.Text = Trener.Find(Global.IdTrener).ToString();
            l_tym.Text = Tym.FindByCoach(Global.IdTrener).nazev;
        }

        private void lb_turnaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            turnaj_id = Convert.ToInt32(((Turnaj)((ListBox)sender).SelectedItem).ID);
            l_nazev.Text = ((Turnaj)((ListBox)sender).SelectedItem).nazev;
            l_od.Text = Convert.ToDateTime(((Turnaj)((ListBox)sender).SelectedItem).datumOD).ToString("dd.MM.yyyy");
            l_do.Text = Convert.ToDateTime(((Turnaj)((ListBox)sender).SelectedItem).datumDO).ToString("dd.MM.yyyy");
            l_prize.Text = "$" + ((Turnaj)((ListBox)sender).SelectedItem).prizepool.ToString();
            l_org.Text = ((Turnaj)((ListBox)sender).SelectedItem).organizator.nazev;
            l_misto.Text = ((Turnaj)((ListBox)sender).SelectedItem).misto;
            l_zeme.Text = ((Turnaj)((ListBox)sender).SelectedItem).zeme;
        }

        private void PrihlaseniDoTurnaje_Load(object sender, EventArgs e)
        {

        }

        private void b_prohlasit_Click(object sender, EventArgs e)
        {
            string error = TymVturnaji.PrihlasitDoTurnaje(turnaj_id);
            if (error == null)
            {
                MessageBox.Show("Prihlaseno!");
                this.Close();
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
