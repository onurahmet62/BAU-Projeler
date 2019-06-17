namespace PerformansKiyaslama
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
            this.listConnected = new System.Windows.Forms.ListBox();
            this.listDisconnected = new System.Windows.Forms.ListBox();
            this.listEntity = new System.Windows.Forms.ListBox();
            this.btnConnected = new System.Windows.Forms.Button();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.btnEntity = new System.Windows.Forms.Button();
            this.lblConnected = new System.Windows.Forms.Label();
            this.lblDisconnected = new System.Windows.Forms.Label();
            this.lblEntity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listConnected
            // 
            this.listConnected.FormattingEnabled = true;
            this.listConnected.Location = new System.Drawing.Point(104, 133);
            this.listConnected.Name = "listConnected";
            this.listConnected.Size = new System.Drawing.Size(131, 173);
            this.listConnected.TabIndex = 0;
            // 
            // listDisconnected
            // 
            this.listDisconnected.FormattingEnabled = true;
            this.listDisconnected.Location = new System.Drawing.Point(289, 133);
            this.listDisconnected.Name = "listDisconnected";
            this.listDisconnected.Size = new System.Drawing.Size(131, 173);
            this.listDisconnected.TabIndex = 1;
            // 
            // listEntity
            // 
            this.listEntity.FormattingEnabled = true;
            this.listEntity.Location = new System.Drawing.Point(482, 133);
            this.listEntity.Name = "listEntity";
            this.listEntity.Size = new System.Drawing.Size(131, 173);
            this.listEntity.TabIndex = 2;
            // 
            // btnConnected
            // 
            this.btnConnected.Location = new System.Drawing.Point(104, 99);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(131, 23);
            this.btnConnected.TabIndex = 3;
            this.btnConnected.Text = "Connected";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Location = new System.Drawing.Point(289, 99);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(131, 23);
            this.btnDisconnected.TabIndex = 4;
            this.btnDisconnected.Text = "Disconnected";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            this.btnDisconnected.Click += new System.EventHandler(this.btnDisconnected_Click);
            // 
            // btnEntity
            // 
            this.btnEntity.Location = new System.Drawing.Point(482, 99);
            this.btnEntity.Name = "btnEntity";
            this.btnEntity.Size = new System.Drawing.Size(131, 23);
            this.btnEntity.TabIndex = 5;
            this.btnEntity.Text = "Entity";
            this.btnEntity.UseVisualStyleBackColor = true;
            this.btnEntity.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // lblConnected
            // 
            this.lblConnected.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblConnected.Location = new System.Drawing.Point(101, 328);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(134, 23);
            this.lblConnected.TabIndex = 6;
            this.lblConnected.Text = "label1";
            // 
            // lblDisconnected
            // 
            this.lblDisconnected.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDisconnected.Location = new System.Drawing.Point(286, 328);
            this.lblDisconnected.Name = "lblDisconnected";
            this.lblDisconnected.Size = new System.Drawing.Size(134, 23);
            this.lblDisconnected.TabIndex = 7;
            this.lblDisconnected.Text = "label2";
            // 
            // lblEntity
            // 
            this.lblEntity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntity.Location = new System.Drawing.Point(479, 328);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(134, 23);
            this.lblEntity.TabIndex = 8;
            this.lblEntity.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEntity);
            this.Controls.Add(this.lblDisconnected);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.btnEntity);
            this.Controls.Add(this.btnDisconnected);
            this.Controls.Add(this.btnConnected);
            this.Controls.Add(this.listEntity);
            this.Controls.Add(this.listDisconnected);
            this.Controls.Add(this.listConnected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listConnected;
        private System.Windows.Forms.ListBox listDisconnected;
        private System.Windows.Forms.ListBox listEntity;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDisconnected;
        private System.Windows.Forms.Button btnEntity;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label lblDisconnected;
        private System.Windows.Forms.Label lblEntity;
    }
}

