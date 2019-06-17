namespace BauOgrenci
{
    partial class frmAnaSayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEgitmenGiris = new System.Windows.Forms.Button();
            this.btnDersGiris = new System.Windows.Forms.Button();
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnEgitmenGiris);
            this.panel1.Controls.Add(this.btnDersGiris);
            this.panel1.Controls.Add(this.btnOgrenciGiris);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnEgitmenGiris
            // 
            this.btnEgitmenGiris.Location = new System.Drawing.Point(244, 12);
            this.btnEgitmenGiris.Name = "btnEgitmenGiris";
            this.btnEgitmenGiris.Size = new System.Drawing.Size(92, 44);
            this.btnEgitmenGiris.TabIndex = 0;
            this.btnEgitmenGiris.Text = "Eğitmen Giriş";
            this.btnEgitmenGiris.UseVisualStyleBackColor = true;
            this.btnEgitmenGiris.Click += new System.EventHandler(this.btnEgitmenGiris_Click);
            // 
            // btnDersGiris
            // 
            this.btnDersGiris.Location = new System.Drawing.Point(125, 12);
            this.btnDersGiris.Name = "btnDersGiris";
            this.btnDersGiris.Size = new System.Drawing.Size(92, 44);
            this.btnDersGiris.TabIndex = 0;
            this.btnDersGiris.Text = "Ders Giriş";
            this.btnDersGiris.UseVisualStyleBackColor = true;
            this.btnDersGiris.Click += new System.EventHandler(this.btnDersGiris_Click);
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.Location = new System.Drawing.Point(12, 12);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(92, 44);
            this.btnOgrenciGiris.TabIndex = 0;
            this.btnOgrenciGiris.Text = "Öğrenci Giriş";
            this.btnOgrenciGiris.UseVisualStyleBackColor = true;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 351);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEgitmenGiris;
        private System.Windows.Forms.Button btnDersGiris;
        private System.Windows.Forms.Button btnOgrenciGiris;
    }
}