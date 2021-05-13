
namespace Krkavec
{
    partial class Pridat
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_jmeno = new System.Windows.Forms.TextBox();
            this.tb_prijmeni = new System.Windows.Forms.TextBox();
            this.tb_zeme = new System.Windows.Forms.TextBox();
            this.cb_tym = new System.Windows.Forms.ComboBox();
            this.b_ulozit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jmeno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prijmeni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zeme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tym";
            // 
            // tb_jmeno
            // 
            this.tb_jmeno.Location = new System.Drawing.Point(107, 39);
            this.tb_jmeno.Name = "tb_jmeno";
            this.tb_jmeno.Size = new System.Drawing.Size(121, 20);
            this.tb_jmeno.TabIndex = 4;
            // 
            // tb_prijmeni
            // 
            this.tb_prijmeni.Location = new System.Drawing.Point(107, 73);
            this.tb_prijmeni.Name = "tb_prijmeni";
            this.tb_prijmeni.Size = new System.Drawing.Size(121, 20);
            this.tb_prijmeni.TabIndex = 5;
            // 
            // tb_zeme
            // 
            this.tb_zeme.Location = new System.Drawing.Point(107, 107);
            this.tb_zeme.Name = "tb_zeme";
            this.tb_zeme.Size = new System.Drawing.Size(121, 20);
            this.tb_zeme.TabIndex = 6;
            // 
            // cb_tym
            // 
            this.cb_tym.FormattingEnabled = true;
            this.cb_tym.Location = new System.Drawing.Point(107, 144);
            this.cb_tym.Name = "cb_tym";
            this.cb_tym.Size = new System.Drawing.Size(121, 21);
            this.cb_tym.TabIndex = 7;
            // 
            // b_ulozit
            // 
            this.b_ulozit.Location = new System.Drawing.Point(226, 191);
            this.b_ulozit.Name = "b_ulozit";
            this.b_ulozit.Size = new System.Drawing.Size(131, 37);
            this.b_ulozit.TabIndex = 8;
            this.b_ulozit.Text = "Ulozit";
            this.b_ulozit.UseVisualStyleBackColor = true;
            this.b_ulozit.Click += new System.EventHandler(this.b_ulozit_Click);
            // 
            // Pridat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 258);
            this.Controls.Add(this.b_ulozit);
            this.Controls.Add(this.cb_tym);
            this.Controls.Add(this.tb_zeme);
            this.Controls.Add(this.tb_prijmeni);
            this.Controls.Add(this.tb_jmeno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pridat";
            this.Text = "Pridat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_jmeno;
        private System.Windows.Forms.TextBox tb_prijmeni;
        private System.Windows.Forms.TextBox tb_zeme;
        private System.Windows.Forms.ComboBox cb_tym;
        private System.Windows.Forms.Button b_ulozit;
    }
}