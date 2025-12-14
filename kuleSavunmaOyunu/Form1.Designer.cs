namespace kuleSavunmaOyunu
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblSkor = new Label();
            lblDalga = new Label();
            lblCan = new Label();
            lblAltin = new Label();
            panel2 = new Panel();
            btnBuyuKulesi = new Button();
            btnTopKulesi = new Button();
            btnOkKulesi = new Button();
            pnlYol1 = new Panel();
            pnlYol3 = new Panel();
            pnlYol4 = new Panel();
            pnlYol5 = new Panel();
            pnlBitis = new Panel();
            tmrOyun = new System.Windows.Forms.Timer(components);
            pnlYol2 = new Panel();
            pnlYol6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(lblSkor);
            panel1.Controls.Add(lblDalga);
            panel1.Controls.Add(lblCan);
            panel1.Controls.Add(lblAltin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 150);
            panel1.TabIndex = 0;
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.Font = new Font("OCR A Extended", 14F);
            lblSkor.ForeColor = Color.DarkBlue;
            lblSkor.Location = new Point(696, 22);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(115, 30);
            lblSkor.TabIndex = 3;
            lblSkor.Text = "Skor:0";
            // 
            // lblDalga
            // 
            lblDalga.AutoSize = true;
            lblDalga.Font = new Font("OCR A Extended", 14F);
            lblDalga.ForeColor = Color.DarkBlue;
            lblDalga.Location = new Point(436, 22);
            lblDalga.Name = "lblDalga";
            lblDalga.Size = new Size(166, 30);
            lblDalga.TabIndex = 2;
            lblDalga.Text = "Dalga:1/5";
            lblDalga.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblCan
            // 
            lblCan.AutoSize = true;
            lblCan.Font = new Font("OCR A Extended", 14F);
            lblCan.ForeColor = Color.Gold;
            lblCan.Location = new Point(251, 22);
            lblCan.Name = "lblCan";
            lblCan.Size = new Size(115, 30);
            lblCan.TabIndex = 1;
            lblCan.Text = "Can:20";
            // 
            // lblAltin
            // 
            lblAltin.AutoSize = true;
            lblAltin.Font = new Font("OCR A Extended", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltin.ForeColor = Color.Gold;
            lblAltin.Location = new Point(12, 22);
            lblAltin.Name = "lblAltin";
            lblAltin.Size = new Size(166, 30);
            lblAltin.TabIndex = 0;
            lblAltin.Text = "Altın:100";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBuyuKulesi);
            panel2.Controls.Add(btnTopKulesi);
            panel2.Controls.Add(btnOkKulesi);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.Cornsilk;
            panel2.Location = new Point(0, 565);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 179);
            panel2.TabIndex = 1;
            // 
            // btnBuyuKulesi
            // 
            btnBuyuKulesi.BackColor = Color.Purple;
            btnBuyuKulesi.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnBuyuKulesi.Location = new Point(555, 76);
            btnBuyuKulesi.Name = "btnBuyuKulesi";
            btnBuyuKulesi.Size = new Size(278, 34);
            btnBuyuKulesi.TabIndex = 2;
            btnBuyuKulesi.Text = "Büyü Kulesi(200tl)";
            btnBuyuKulesi.UseVisualStyleBackColor = false;
            btnBuyuKulesi.Click += btnBuyuKulesi_Click;
            // 
            // btnTopKulesi
            // 
            btnTopKulesi.BackColor = Color.Orange;
            btnTopKulesi.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnTopKulesi.Location = new Point(284, 76);
            btnTopKulesi.Name = "btnTopKulesi";
            btnTopKulesi.Size = new Size(251, 34);
            btnTopKulesi.TabIndex = 1;
            btnTopKulesi.Text = "Top Kulesi(250tl)";
            btnTopKulesi.UseVisualStyleBackColor = false;
            btnTopKulesi.Click += btnTopKulesi_Click;
            // 
            // btnOkKulesi
            // 
            btnOkKulesi.BackColor = Color.White;
            btnOkKulesi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOkKulesi.ForeColor = Color.RoyalBlue;
            btnOkKulesi.Location = new Point(24, 76);
            btnOkKulesi.Name = "btnOkKulesi";
            btnOkKulesi.Size = new Size(238, 34);
            btnOkKulesi.TabIndex = 0;
            btnOkKulesi.Text = "Ok Kulesi(100tl)";
            btnOkKulesi.UseVisualStyleBackColor = false;
            btnOkKulesi.Click += btnOkKulesi_Click;
            // 
            // pnlYol1
            // 
            pnlYol1.BackColor = Color.DarkOliveGreen;
            pnlYol1.Location = new Point(2, 392);
            pnlYol1.Name = "pnlYol1";
            pnlYol1.Size = new Size(162, 36);
            pnlYol1.TabIndex = 2;
            // 
            // pnlYol3
            // 
            pnlYol3.BackColor = Color.DarkOliveGreen;
            pnlYol3.Location = new Point(208, 252);
            pnlYol3.Name = "pnlYol3";
            pnlYol3.Size = new Size(534, 36);
            pnlYol3.TabIndex = 4;
            // 
            // pnlYol4
            // 
            pnlYol4.BackColor = Color.DarkOliveGreen;
            pnlYol4.Location = new Point(699, 285);
            pnlYol4.Name = "pnlYol4";
            pnlYol4.Size = new Size(43, 143);
            pnlYol4.TabIndex = 5;
            // 
            // pnlYol5
            // 
            pnlYol5.BackColor = Color.DarkOliveGreen;
            pnlYol5.Location = new Point(740, 395);
            pnlYol5.Name = "pnlYol5";
            pnlYol5.Size = new Size(178, 33);
            pnlYol5.TabIndex = 6;
            // 
            // pnlBitis
            // 
            pnlBitis.BackColor = Color.DarkOliveGreen;
            pnlBitis.Location = new Point(918, 395);
            pnlBitis.Name = "pnlBitis";
            pnlBitis.Size = new Size(60, 33);
            pnlBitis.TabIndex = 7;
            // 
            // tmrOyun
            // 
            tmrOyun.Interval = 50;
            tmrOyun.Tick += tmrOyun_Tick;
            // 
            // pnlYol2
            // 
            pnlYol2.BackColor = Color.DarkOliveGreen;
            pnlYol2.Location = new Point(163, 252);
            pnlYol2.Name = "pnlYol2";
            pnlYol2.Size = new Size(46, 143);
            pnlYol2.TabIndex = 8;
            // 
            // pnlYol6
            // 
            pnlYol6.BackColor = Color.DarkOliveGreen;
            pnlYol6.Location = new Point(163, 392);
            pnlYol6.Name = "pnlYol6";
            pnlYol6.Size = new Size(46, 36);
            pnlYol6.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(978, 744);
            Controls.Add(pnlBitis);
            Controls.Add(pnlYol6);
            Controls.Add(pnlYol5);
            Controls.Add(pnlYol4);
            Controls.Add(pnlYol3);
            Controls.Add(pnlYol1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlYol2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kuleSavunmaOyunu";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAltin;
        private Label lblDalga;
        private Label lblCan;
        private Label lblSkor;
        private Panel panel2;
        private Button btnBuyuKulesi;
        private Button btnTopKulesi;
        private Button btnOkKulesi;
        private Panel pnlYol1;
        private Panel pnlYol3;
        private Panel pnlYol4;
        private Panel pnlYol5;
        private System.Windows.Forms.Timer tmrOyun;
        private Panel pnlBitis;
        private Panel pnlYol2;
        private Panel pnlYol6;
    }
}
