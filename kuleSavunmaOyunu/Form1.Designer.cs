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
            pnlYol2 = new Panel();
            pnlYol3 = new Panel();
            pnlYol4 = new Panel();
            pnlYol5 = new Panel();
            tmrOyun = new System.Windows.Forms.Timer(components);
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
            // 
            // pnlYol1
            // 
            pnlYol1.BackColor = Color.DarkOliveGreen;
            pnlYol1.Location = new Point(2, 277);
            pnlYol1.Name = "pnlYol1";
            pnlYol1.Size = new Size(245, 36);
            pnlYol1.TabIndex = 2;
            // 
            // pnlYol2
            // 
            pnlYol2.BackColor = Color.DarkOliveGreen;
            pnlYol2.Location = new Point(204, 312);
            pnlYol2.Name = "pnlYol2";
            pnlYol2.Size = new Size(43, 179);
            pnlYol2.TabIndex = 3;
            // 
            // pnlYol3
            // 
            pnlYol3.BackColor = Color.DarkOliveGreen;
            pnlYol3.Location = new Point(245, 455);
            pnlYol3.Name = "pnlYol3";
            pnlYol3.Size = new Size(376, 36);
            pnlYol3.TabIndex = 4;
            // 
            // pnlYol4
            // 
            pnlYol4.BackColor = Color.DarkOliveGreen;
            pnlYol4.Location = new Point(578, 277);
            pnlYol4.Name = "pnlYol4";
            pnlYol4.Size = new Size(43, 179);
            pnlYol4.TabIndex = 5;
            // 
            // pnlYol5
            // 
            pnlYol5.BackColor = Color.DarkOliveGreen;
            pnlYol5.Location = new Point(617, 277);
            pnlYol5.Name = "pnlYol5";
            pnlYol5.Size = new Size(361, 36);
            pnlYol5.TabIndex = 6;
            // 
            // tmrOyun
            // 
            tmrOyun.Interval = 50;
            tmrOyun.Tick += tmrOyun_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(978, 744);
            Controls.Add(pnlYol5);
            Controls.Add(pnlYol4);
            Controls.Add(pnlYol3);
            Controls.Add(pnlYol2);
            Controls.Add(pnlYol1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kuleSavunmaOyunu";
            Load += Form1_Load;
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
        private Panel pnlYol2;
        private Panel pnlYol3;
        private Panel pnlYol4;
        private Panel pnlYol5;
        private System.Windows.Forms.Timer tmrOyun;
    }
}
