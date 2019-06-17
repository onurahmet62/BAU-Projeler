namespace PersonelTakipOtomasyonu.Forms
{
    partial class Update
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
            this.lblPerAdi = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblMedeni = new System.Windows.Forms.Label();
            this.txtPerAdi = new System.Windows.Forms.TextBox();
            this.txtPerSoyad = new System.Windows.Forms.TextBox();
            this.txtMedeni = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDogumTarihi = new System.Windows.Forms.TextBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPerAdi
            // 
            this.lblPerAdi.AutoSize = true;
            this.lblPerAdi.Location = new System.Drawing.Point(26, 37);
            this.lblPerAdi.Name = "lblPerAdi";
            this.lblPerAdi.Size = new System.Drawing.Size(66, 13);
            this.lblPerAdi.TabIndex = 0;
            this.lblPerAdi.Text = "Personel Adi";
            this.lblPerAdi.Click += new System.EventHandler(this.lblPerAdi_Click);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(26, 71);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(81, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Personel Soyad";
            // 
            // lblMedeni
            // 
            this.lblMedeni.AutoSize = true;
            this.lblMedeni.Location = new System.Drawing.Point(26, 150);
            this.lblMedeni.Name = "lblMedeni";
            this.lblMedeni.Size = new System.Drawing.Size(86, 13);
            this.lblMedeni.TabIndex = 2;
            this.lblMedeni.Text = "Personel Medeni";
            // 
            // txtPerAdi
            // 
            this.txtPerAdi.Location = new System.Drawing.Point(118, 34);
            this.txtPerAdi.Name = "txtPerAdi";
            this.txtPerAdi.Size = new System.Drawing.Size(100, 20);
            this.txtPerAdi.TabIndex = 4;
            // 
            // txtPerSoyad
            // 
            this.txtPerSoyad.Location = new System.Drawing.Point(118, 71);
            this.txtPerSoyad.Name = "txtPerSoyad";
            this.txtPerSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtPerSoyad.TabIndex = 5;
            // 
            // txtMedeni
            // 
            this.txtMedeni.Location = new System.Drawing.Point(118, 143);
            this.txtMedeni.Name = "txtMedeni";
            this.txtMedeni.Size = new System.Drawing.Size(100, 20);
            this.txtMedeni.TabIndex = 6;
            this.txtMedeni.TextChanged += new System.EventHandler(this.txtMedeni_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Saved";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Location = new System.Drawing.Point(118, 110);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtDogumTarihi.TabIndex = 8;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(26, 113);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(70, 13);
            this.lblDogumTarihi.TabIndex = 9;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 301);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMedeni);
            this.Controls.Add(this.txtPerSoyad);
            this.Controls.Add(this.txtPerAdi);
            this.Controls.Add(this.lblMedeni);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblPerAdi);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerAdi;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblMedeni;
        private System.Windows.Forms.TextBox txtPerAdi;
        private System.Windows.Forms.TextBox txtPerSoyad;
        private System.Windows.Forms.TextBox txtMedeni;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDogumTarihi;
        private System.Windows.Forms.Label lblDogumTarihi;
    }
}