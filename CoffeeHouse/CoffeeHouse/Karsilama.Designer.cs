﻿namespace CoffeeHouse
{
    partial class Karsilama
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSiraNo = new System.Windows.Forms.Label();
            this.tmrSiraNo = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "STARBUCKS\'A HOŞGELDİNİZ..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sipariş İçin Bekleyen Müşteri Sayısı";
            // 
            // lblSiraNo
            // 
            this.lblSiraNo.AutoSize = true;
            this.lblSiraNo.Font = new System.Drawing.Font("Segoe UI", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSiraNo.Location = new System.Drawing.Point(221, 203);
            this.lblSiraNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiraNo.Name = "lblSiraNo";
            this.lblSiraNo.Size = new System.Drawing.Size(136, 159);
            this.lblSiraNo.TabIndex = 2;
            this.lblSiraNo.Text = "0";
            this.lblSiraNo.Click += new System.EventHandler(this.lblSiraNo_Click);
            // 
            // tmrSiraNo
            // 
            this.tmrSiraNo.Interval = 1000;
            this.tmrSiraNo.Tick += new System.EventHandler(this.tmrSiraNo_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeHouse.Properties.Resources.purple_logo_starbucks_coffee_png_27;
            this.pictureBox1.Location = new System.Drawing.Point(234, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Karsilama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 371);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSiraNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Karsilama";
            this.Text = "Karsilama";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblSiraNo;
        private System.Windows.Forms.Timer tmrSiraNo;
        private PictureBox pictureBox1;
    }
}