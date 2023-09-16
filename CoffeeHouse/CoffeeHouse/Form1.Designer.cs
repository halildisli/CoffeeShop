namespace CoffeeHouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxIcecekler = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisiEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisiOnayla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "KAHVELER :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "KAHVE BOYUTU :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "EKSTRA MALZEMELER :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "IcecekAdi";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(443, 29);
            this.comboBox1.TabIndex = 4;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Checked = true;
            this.rbKucuk.Location = new System.Drawing.Point(15, 256);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(75, 25);
            this.rbKucuk.TabIndex = 5;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(114, 256);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(61, 25);
            this.rbOrta.TabIndex = 6;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(209, 256);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(76, 25);
            this.rbBuyuk.TabIndex = 7;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 170);
            this.panel1.TabIndex = 8;
            // 
            // lbxIcecekler
            // 
            this.lbxIcecekler.FormattingEnabled = true;
            this.lbxIcecekler.HorizontalScrollbar = true;
            this.lbxIcecekler.ItemHeight = 21;
            this.lbxIcecekler.Location = new System.Drawing.Point(298, 314);
            this.lbxIcecekler.Name = "lbxIcecekler";
            this.lbxIcecekler.ScrollAlwaysVisible = true;
            this.lbxIcecekler.Size = new System.Drawing.Size(443, 172);
            this.lbxIcecekler.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "ADET :";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(76, 500);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(120, 29);
            this.nudAdet.TabIndex = 12;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisiEkle
            // 
            this.btnSiparisiEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSiparisiEkle.ForeColor = System.Drawing.Color.White;
            this.btnSiparisiEkle.Location = new System.Drawing.Point(12, 539);
            this.btnSiparisiEkle.Name = "btnSiparisiEkle";
            this.btnSiparisiEkle.Size = new System.Drawing.Size(280, 48);
            this.btnSiparisiEkle.TabIndex = 13;
            this.btnSiparisiEkle.Text = "SİPARİŞİ EKLE";
            this.btnSiparisiEkle.UseVisualStyleBackColor = false;
            this.btnSiparisiEkle.Click += new System.EventHandler(this.btnSiparisiEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "TOPLAM SİPARİŞ TUTARI :";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(507, 500);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(50, 21);
            this.lblToplamTutar.TabIndex = 15;
            this.lblToplamTutar.Text = "₺0.00";
            // 
            // btnSiparisiOnayla
            // 
            this.btnSiparisiOnayla.BackColor = System.Drawing.Color.Purple;
            this.btnSiparisiOnayla.ForeColor = System.Drawing.Color.White;
            this.btnSiparisiOnayla.Location = new System.Drawing.Point(298, 539);
            this.btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            this.btnSiparisiOnayla.Size = new System.Drawing.Size(443, 48);
            this.btnSiparisiOnayla.TabIndex = 16;
            this.btnSiparisiOnayla.Text = "SİPARİŞİ ONAYLA";
            this.btnSiparisiOnayla.UseVisualStyleBackColor = false;
            this.btnSiparisiOnayla.Click += new System.EventHandler(this.btnSiparisiOnayla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 597);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "SİPARİŞ DURUMU :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Barista 1 :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 660);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(731, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(101, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(640, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "UYGUN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(101, 693);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(640, 27);
            this.button2.TabIndex = 23;
            this.button2.Text = "UYGUN";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(10, 726);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(731, 23);
            this.progressBar2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 699);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Barista 2 :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CoffeeHouse.Properties.Resources.son;
            this.pictureBox2.Location = new System.Drawing.Point(240, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(443, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CoffeeHouse.Properties.Resources.aaaaaaaaaaaaa;
            this.pictureBox3.Location = new System.Drawing.Point(275, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(347, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(101, 755);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(640, 27);
            this.button3.TabIndex = 31;
            this.button3.Text = "UYGUN";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(10, 792);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(731, 23);
            this.progressBar3.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 827);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Barista 4:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(100, 820);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(640, 27);
            this.button4.TabIndex = 28;
            this.button4.Text = "UYGUN";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(10, 851);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(731, 23);
            this.progressBar4.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 761);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 26;
            this.label10.Text = "Barista 3 :";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 876);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSiparisiOnayla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSiparisiEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxIcecekler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbBuyuk);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.rbKucuk);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Coffee House Sipariş Sayfası :";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private RadioButton rbKucuk;
        private RadioButton rbOrta;
        private RadioButton rbBuyuk;
        private Panel panel1;
        private ListBox lbxIcecekler;
        private Label label5;
        private NumericUpDown nudAdet;
        private Button btnSiparisiEkle;
        private Label label6;
        private Label lblToplamTutar;
        private Button btnSiparisiOnayla;
        private Label label7;
        private Label label8;
        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private ProgressBar progressBar2;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button3;
        private ProgressBar progressBar3;
        private Label label4;
        private Button button4;
        private ProgressBar progressBar4;
        private Label label10;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}