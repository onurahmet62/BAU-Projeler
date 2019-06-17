namespace AdoGiris
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
            this.btnSqlBagla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSqlBagla
            // 
            this.btnSqlBagla.Location = new System.Drawing.Point(197, 126);
            this.btnSqlBagla.Name = "btnSqlBagla";
            this.btnSqlBagla.Size = new System.Drawing.Size(84, 29);
            this.btnSqlBagla.TabIndex = 0;
            this.btnSqlBagla.Text = "SQL Bağla";
            this.btnSqlBagla.UseVisualStyleBackColor = true;
            this.btnSqlBagla.Click += new System.EventHandler(this.btnSqlBagla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 313);
            this.Controls.Add(this.btnSqlBagla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSqlBagla;
    }
}

