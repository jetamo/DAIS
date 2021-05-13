
namespace Krkavec
{
    partial class Menu
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
            this.b_prihlasit_do_turnaje = new System.Windows.Forms.Button();
            this.b_data = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.b_pridat = new System.Windows.Forms.Button();
            this.b_upravit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_prihlasit_do_turnaje
            // 
            this.b_prihlasit_do_turnaje.Location = new System.Drawing.Point(69, 66);
            this.b_prihlasit_do_turnaje.Name = "b_prihlasit_do_turnaje";
            this.b_prihlasit_do_turnaje.Size = new System.Drawing.Size(179, 66);
            this.b_prihlasit_do_turnaje.TabIndex = 0;
            this.b_prihlasit_do_turnaje.Text = "Prihlasit do turnaje";
            this.b_prihlasit_do_turnaje.UseVisualStyleBackColor = true;
            this.b_prihlasit_do_turnaje.Click += new System.EventHandler(this.b_prihlasit_do_turnaje_Click);
            // 
            // b_data
            // 
            this.b_data.Location = new System.Drawing.Point(323, 390);
            this.b_data.Name = "b_data";
            this.b_data.Size = new System.Drawing.Size(142, 48);
            this.b_data.TabIndex = 1;
            this.b_data.Text = "Zobrazit data";
            this.b_data.UseVisualStyleBackColor = true;
            this.b_data.Click += new System.EventHandler(this.b_data_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pripsat body";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_pridat
            // 
            this.b_pridat.Location = new System.Drawing.Point(529, 66);
            this.b_pridat.Name = "b_pridat";
            this.b_pridat.Size = new System.Drawing.Size(179, 66);
            this.b_pridat.TabIndex = 3;
            this.b_pridat.Text = "Pridat hrace";
            this.b_pridat.UseVisualStyleBackColor = true;
            this.b_pridat.Click += new System.EventHandler(this.b_pridat_Click);
            // 
            // b_upravit
            // 
            this.b_upravit.Location = new System.Drawing.Point(529, 193);
            this.b_upravit.Name = "b_upravit";
            this.b_upravit.Size = new System.Drawing.Size(179, 66);
            this.b_upravit.TabIndex = 4;
            this.b_upravit.Text = "Upavit/smazat hrace";
            this.b_upravit.UseVisualStyleBackColor = true;
            this.b_upravit.Click += new System.EventHandler(this.b_upravit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_upravit);
            this.Controls.Add(this.b_pridat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_data);
            this.Controls.Add(this.b_prihlasit_do_turnaje);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_prihlasit_do_turnaje;
        private System.Windows.Forms.Button b_data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_pridat;
        private System.Windows.Forms.Button b_upravit;
    }
}