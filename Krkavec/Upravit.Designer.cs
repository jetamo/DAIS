
namespace Krkavec
{
    partial class Upravit
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
            this.b_ulozit = new System.Windows.Forms.Button();
            this.cb_tym = new System.Windows.Forms.ComboBox();
            this.tb_zeme = new System.Windows.Forms.TextBox();
            this.tb_prijmeni = new System.Windows.Forms.TextBox();
            this.tb_jmeno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_smazat = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_ulozit
            // 
            this.b_ulozit.Location = new System.Drawing.Point(10, 273);
            this.b_ulozit.Name = "b_ulozit";
            this.b_ulozit.Size = new System.Drawing.Size(131, 37);
            this.b_ulozit.TabIndex = 17;
            this.b_ulozit.Text = "Ulozit";
            this.b_ulozit.UseVisualStyleBackColor = true;
            this.b_ulozit.Click += new System.EventHandler(this.b_ulozit_Click);
            // 
            // cb_tym
            // 
            this.cb_tym.FormattingEnabled = true;
            this.cb_tym.Location = new System.Drawing.Point(85, 128);
            this.cb_tym.Name = "cb_tym";
            this.cb_tym.Size = new System.Drawing.Size(121, 21);
            this.cb_tym.TabIndex = 16;
            // 
            // tb_zeme
            // 
            this.tb_zeme.Location = new System.Drawing.Point(85, 91);
            this.tb_zeme.Name = "tb_zeme";
            this.tb_zeme.Size = new System.Drawing.Size(121, 20);
            this.tb_zeme.TabIndex = 15;
            // 
            // tb_prijmeni
            // 
            this.tb_prijmeni.Location = new System.Drawing.Point(85, 57);
            this.tb_prijmeni.Name = "tb_prijmeni";
            this.tb_prijmeni.Size = new System.Drawing.Size(121, 20);
            this.tb_prijmeni.TabIndex = 14;
            // 
            // tb_jmeno
            // 
            this.tb_jmeno.Location = new System.Drawing.Point(85, 23);
            this.tb_jmeno.Name = "tb_jmeno";
            this.tb_jmeno.Size = new System.Drawing.Size(121, 20);
            this.tb_jmeno.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tym";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zeme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prijmeni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jmeno";
            // 
            // b_smazat
            // 
            this.b_smazat.Location = new System.Drawing.Point(186, 273);
            this.b_smazat.Name = "b_smazat";
            this.b_smazat.Size = new System.Drawing.Size(131, 37);
            this.b_smazat.TabIndex = 18;
            this.b_smazat.Text = "Smazat";
            this.b_smazat.UseVisualStyleBackColor = true;
            this.b_smazat.Click += new System.EventHandler(this.b_smazat_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(334, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 212);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hraci";
            // 
            // Upravit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 336);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.b_smazat);
            this.Controls.Add(this.b_ulozit);
            this.Controls.Add(this.cb_tym);
            this.Controls.Add(this.tb_zeme);
            this.Controls.Add(this.tb_prijmeni);
            this.Controls.Add(this.tb_jmeno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Upravit";
            this.Text = "Upravit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_ulozit;
        private System.Windows.Forms.ComboBox cb_tym;
        private System.Windows.Forms.TextBox tb_zeme;
        private System.Windows.Forms.TextBox tb_prijmeni;
        private System.Windows.Forms.TextBox tb_jmeno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_smazat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
    }
}