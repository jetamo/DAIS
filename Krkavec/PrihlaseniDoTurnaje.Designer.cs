
namespace Krkavec
{
    partial class PrihlaseniDoTurnaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_tym = new System.Windows.Forms.Label();
            this.l_uzivatel = new System.Windows.Forms.Label();
            this.lb_turnaje = new System.Windows.Forms.ListBox();
            this.b_prohlasit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.l_org = new System.Windows.Forms.Label();
            this.l_misto = new System.Windows.Forms.Label();
            this.l_zeme = new System.Windows.Forms.Label();
            this.l_do = new System.Windows.Forms.Label();
            this.l_prize = new System.Windows.Forms.Label();
            this.l_nazev = new System.Windows.Forms.Label();
            this.l_od = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uzivatel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tym:";
            // 
            // l_tym
            // 
            this.l_tym.AutoSize = true;
            this.l_tym.Location = new System.Drawing.Point(75, 40);
            this.l_tym.Name = "l_tym";
            this.l_tym.Size = new System.Drawing.Size(35, 13);
            this.l_tym.TabIndex = 3;
            this.l_tym.Text = "label3";
            // 
            // l_uzivatel
            // 
            this.l_uzivatel.AutoSize = true;
            this.l_uzivatel.Location = new System.Drawing.Point(75, 12);
            this.l_uzivatel.Name = "l_uzivatel";
            this.l_uzivatel.Size = new System.Drawing.Size(35, 13);
            this.l_uzivatel.TabIndex = 2;
            this.l_uzivatel.Text = "label4";
            // 
            // lb_turnaje
            // 
            this.lb_turnaje.FormattingEnabled = true;
            this.lb_turnaje.Location = new System.Drawing.Point(12, 109);
            this.lb_turnaje.Name = "lb_turnaje";
            this.lb_turnaje.Size = new System.Drawing.Size(218, 420);
            this.lb_turnaje.TabIndex = 4;
            this.lb_turnaje.SelectedIndexChanged += new System.EventHandler(this.lb_turnaje_SelectedIndexChanged);
            // 
            // b_prohlasit
            // 
            this.b_prohlasit.Location = new System.Drawing.Point(431, 476);
            this.b_prohlasit.Name = "b_prohlasit";
            this.b_prohlasit.Size = new System.Drawing.Size(136, 53);
            this.b_prohlasit.TabIndex = 5;
            this.b_prohlasit.Text = "Prihlasit";
            this.b_prohlasit.UseVisualStyleBackColor = true;
            this.b_prohlasit.Click += new System.EventHandler(this.b_prohlasit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Turnaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum OD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "datum DO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Prizepool:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Misto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Zeme:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Organizator:";
            // 
            // l_org
            // 
            this.l_org.AutoSize = true;
            this.l_org.Location = new System.Drawing.Point(350, 262);
            this.l_org.Name = "l_org";
            this.l_org.Size = new System.Drawing.Size(64, 13);
            this.l_org.TabIndex = 20;
            this.l_org.Text = "Organizator:";
            // 
            // l_misto
            // 
            this.l_misto.AutoSize = true;
            this.l_misto.Location = new System.Drawing.Point(350, 214);
            this.l_misto.Name = "l_misto";
            this.l_misto.Size = new System.Drawing.Size(35, 13);
            this.l_misto.TabIndex = 19;
            this.l_misto.Text = "Misto:";
            // 
            // l_zeme
            // 
            this.l_zeme.AutoSize = true;
            this.l_zeme.Location = new System.Drawing.Point(350, 240);
            this.l_zeme.Name = "l_zeme";
            this.l_zeme.Size = new System.Drawing.Size(37, 13);
            this.l_zeme.TabIndex = 18;
            this.l_zeme.Text = "Zeme:";
            // 
            // l_do
            // 
            this.l_do.AutoSize = true;
            this.l_do.Location = new System.Drawing.Point(350, 166);
            this.l_do.Name = "l_do";
            this.l_do.Size = new System.Drawing.Size(58, 13);
            this.l_do.TabIndex = 17;
            this.l_do.Text = "datum DO:";
            // 
            // l_prize
            // 
            this.l_prize.AutoSize = true;
            this.l_prize.Location = new System.Drawing.Point(350, 192);
            this.l_prize.Name = "l_prize";
            this.l_prize.Size = new System.Drawing.Size(53, 13);
            this.l_prize.TabIndex = 16;
            this.l_prize.Text = "Prizepool:";
            // 
            // l_nazev
            // 
            this.l_nazev.AutoSize = true;
            this.l_nazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nazev.Location = new System.Drawing.Point(265, 99);
            this.l_nazev.Name = "l_nazev";
            this.l_nazev.Size = new System.Drawing.Size(74, 24);
            this.l_nazev.TabIndex = 15;
            this.l_nazev.Text = "Nazev:";
            // 
            // l_od
            // 
            this.l_od.AutoSize = true;
            this.l_od.Location = new System.Drawing.Point(350, 139);
            this.l_od.Name = "l_od";
            this.l_od.Size = new System.Drawing.Size(60, 13);
            this.l_od.TabIndex = 14;
            this.l_od.Text = "Datum OD:";
            // 
            // PrihlaseniDoTurnaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 541);
            this.Controls.Add(this.l_org);
            this.Controls.Add(this.l_misto);
            this.Controls.Add(this.l_zeme);
            this.Controls.Add(this.l_do);
            this.Controls.Add(this.l_prize);
            this.Controls.Add(this.l_nazev);
            this.Controls.Add(this.l_od);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_prohlasit);
            this.Controls.Add(this.lb_turnaje);
            this.Controls.Add(this.l_tym);
            this.Controls.Add(this.l_uzivatel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrihlaseniDoTurnaje";
            this.Text = "PrihlaseniDoTurnaje";
            this.Load += new System.EventHandler(this.PrihlaseniDoTurnaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_tym;
        private System.Windows.Forms.Label l_uzivatel;
        private System.Windows.Forms.ListBox lb_turnaje;
        private System.Windows.Forms.Button b_prohlasit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label l_org;
        private System.Windows.Forms.Label l_misto;
        private System.Windows.Forms.Label l_zeme;
        private System.Windows.Forms.Label l_do;
        private System.Windows.Forms.Label l_prize;
        private System.Windows.Forms.Label l_nazev;
        private System.Windows.Forms.Label l_od;
    }
}