﻿namespace HaberUygulamasi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.haberlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniHaberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniYazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haberlerToolStripMenuItem,
            this.yazarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // haberlerToolStripMenuItem
            // 
            this.haberlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniHaberToolStripMenuItem,
            this.yeniKategoriToolStripMenuItem,
            this.kategorilerToolStripMenuItem});
            this.haberlerToolStripMenuItem.Name = "haberlerToolStripMenuItem";
            this.haberlerToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.haberlerToolStripMenuItem.Text = "Haberler";
            // 
            // yeniHaberToolStripMenuItem
            // 
            this.yeniHaberToolStripMenuItem.Name = "yeniHaberToolStripMenuItem";
            this.yeniHaberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniHaberToolStripMenuItem.Text = "Yeni Haber";
            this.yeniHaberToolStripMenuItem.Click += new System.EventHandler(this.yeniHaberToolStripMenuItem_Click);
            // 
            // yeniKategoriToolStripMenuItem
            // 
            this.yeniKategoriToolStripMenuItem.Name = "yeniKategoriToolStripMenuItem";
            this.yeniKategoriToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.yeniKategoriToolStripMenuItem.Text = "Yeni Kategori";
            this.yeniKategoriToolStripMenuItem.Click += new System.EventHandler(this.yeniKategoriToolStripMenuItem_Click);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // yazarlarToolStripMenuItem
            // 
            this.yazarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarlarToolStripMenuItem1,
            this.yeniYazarToolStripMenuItem});
            this.yazarlarToolStripMenuItem.Name = "yazarlarToolStripMenuItem";
            this.yazarlarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.yazarlarToolStripMenuItem.Text = "Yazarlar";
            // 
            // yazarlarToolStripMenuItem1
            // 
            this.yazarlarToolStripMenuItem1.Name = "yazarlarToolStripMenuItem1";
            this.yazarlarToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.yazarlarToolStripMenuItem1.Text = "Yazarlar";
            this.yazarlarToolStripMenuItem1.Click += new System.EventHandler(this.yazarlarToolStripMenuItem1_Click);
            // 
            // yeniYazarToolStripMenuItem
            // 
            this.yeniYazarToolStripMenuItem.Name = "yeniYazarToolStripMenuItem";
            this.yeniYazarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.yeniYazarToolStripMenuItem.Text = "Yeni Yazar";
            this.yeniYazarToolStripMenuItem.Click += new System.EventHandler(this.yeniYazarToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 313);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Başlık";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçerik";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 343);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem haberlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniHaberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yeniYazarToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

