namespace AdoOrnekler
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKargo = new System.Windows.Forms.Button();
            this.btnCalisan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnKargo
            // 
            this.btnKargo.Location = new System.Drawing.Point(137, 340);
            this.btnKargo.Name = "btnKargo";
            this.btnKargo.Size = new System.Drawing.Size(179, 23);
            this.btnKargo.TabIndex = 1;
            this.btnKargo.Text = "Kargoları Getir";
            this.btnKargo.UseVisualStyleBackColor = true;
            this.btnKargo.Click += new System.EventHandler(this.btnKargo_Click);
            // 
            // btnCalisan
            // 
            this.btnCalisan.Location = new System.Drawing.Point(472, 340);
            this.btnCalisan.Name = "btnCalisan";
            this.btnCalisan.Size = new System.Drawing.Size(153, 23);
            this.btnCalisan.TabIndex = 2;
            this.btnCalisan.Text = "Çalışanları Getir";
            this.btnCalisan.UseVisualStyleBackColor = true;
            this.btnCalisan.Click += new System.EventHandler(this.btnCalisan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalisan);
            this.Controls.Add(this.btnKargo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKargo;
        private System.Windows.Forms.Button btnCalisan;
    }
}

