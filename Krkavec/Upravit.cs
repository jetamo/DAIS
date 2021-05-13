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
    public partial class Upravit : Form
    {
        Hrac _hrac = null;
        public Upravit()
        {
            InitializeComponent();
            listBox1.DataSource = Hrac.Find();
            cb_tym.DataSource = Tym.Find();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hrac = ((Hrac)((ListBox)sender).SelectedItem);
            tb_jmeno.Text = _hrac.jmeno;
            tb_prijmeni.Text = _hrac.prijmeni;
            tb_zeme.Text = _hrac.zeme;
            if(cb_tym.FindString(_hrac.tym.ToString()) >= 0)
                cb_tym.SelectedItem = cb_tym.Items[cb_tym.FindString(_hrac.tym.ToString())];
        }

        private void UpdateHrac()
        {
            _hrac.jmeno = tb_jmeno.Text;
            _hrac.prijmeni = tb_prijmeni.Text;
            _hrac.zeme = tb_zeme.Text;
            _hrac.tym = (Tym)cb_tym.SelectedItem;
        }

        public void ResetDataSource()
        {
            listBox1.DataSource = Hrac.Find();
            tb_jmeno.Text = "";
            tb_prijmeni.Text = "";
            tb_zeme.Text = "";

        }

        private void b_ulozit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_jmeno.Text) || String.IsNullOrEmpty(tb_prijmeni.Text) || String.IsNullOrEmpty(tb_zeme.Text))
            {
                MessageBox.Show("Nevyplnene udaje.");
                return;
            }
            UpdateHrac();
            _hrac.Upravit();
            ResetDataSource();
            MessageBox.Show("Informace o hraci upraveny.");
        }

        private void b_smazat_Click(object sender, EventArgs e)
        {
            UpdateHrac();
            _hrac.Smazat();
            ResetDataSource();
            MessageBox.Show("Hrac smazan.");
        }
    }
}
