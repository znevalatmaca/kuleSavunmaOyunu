using System.Diagnostics.Eventing.Reader;

namespace kuleSavunmaOyunu
{
    public partial class Form1 : Form
    {

        List<Panel> yolListesi = new List<Panel>();
        List<Dusman> dusmanlar = new List<Dusman>();

        int dalgaSayisi = 0;

        int oyuncuAltin = 500;

        string seciliKuleTuru = "";

        List<Kule> kulelerim = new List<Kule>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yolListesi.Add(pnlYol1);
            yolListesi.Add(pnlYol6);
            yolListesi.Add(pnlYol2);
            yolListesi.Add(pnlYol3);
            yolListesi.Add(pnlYol4);
            yolListesi.Add(pnlYol5);

            yolListesi.Add(pnlBitis);

            tmrOyun.Start();

        }

        private void tmrOyun_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (rnd.Next(0, 100) < 2)
            {
                DusmanYarat();
            }

            for (int i = dusmanlar.Count - 1; i >= 0; i--)
            {
                Dusman d = dusmanlar[i];

                Panel hedefYol = yolListesi[d.YolAdimi];



                if (d.Gorsel.Left < hedefYol.Left) d.Gorsel.Left += d.Hiz;
                if (d.Gorsel.Left > hedefYol.Left) d.Gorsel.Left -= d.Hiz;
                if (d.Gorsel.Top < hedefYol.Top) d.Gorsel.Top += d.Hiz;
                if (d.Gorsel.Top > hedefYol.Top) d.Gorsel.Top -= d.Hiz;

                if (Math.Abs(d.Gorsel.Left - hedefYol.Left) < 10 && Math.Abs(d.Gorsel.Top - hedefYol.Top) < 10)
                {
                    d.YolAdimi++;

                    if (d.YolAdimi >= yolListesi.Count)
                    {
                        this.Controls.Remove(d.Gorsel);
                        dusmanlar.Remove(d);
                    }
                }
            }

            foreach (Kule k in kulelerim)
            {
                k.Saldir(dusmanlar);
            }

            for(int i = dusmanlar.Count - 1; i >= 0; i--)
            {
                if (dusmanlar[i].Can <= 0)
                {
                    this.Controls.Remove(dusmanlar[i].Gorsel);

                    oyuncuAltin += dusmanlar[i].Odul;

                    if (lblAltin != null) lblAltin.Text = "Altýn:" + oyuncuAltin;

                    dusmanlar.RemoveAt(i);

                }
            }
        }
        private void DusmanYarat()
        {
            PictureBox resim = new PictureBox();
            resim.BackColor = Color.Red;
            resim.Size = new Size(30, 30);
            resim.SizeMode = PictureBoxSizeMode.StretchImage;

            resim.Left = yolListesi[0].Left;
            resim.Top = yolListesi[0].Top;

            this.Controls.Add(resim);
            resim.BringToFront();

            Dusman yeniDusman = new Dusman(100, 5, 10, resim);
            dusmanlar.Add(yeniDusman);
        }

        private void btnOkKulesi_Click(object sender, EventArgs e)
        {
            seciliKuleTuru = "Ok";
            this.Cursor = Cursors.Cross; //buraya sonra bak

        }

        private void btnTopKulesi_Click(object sender, EventArgs e)
        {
            seciliKuleTuru = "Top";
            this.Cursor = Cursors.Cross;
        }

        private void btnBuyuKulesi_Click(object sender, EventArgs e)
        {
            seciliKuleTuru = "Buyu";
            this.Cursor = Cursors.Cross;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (seciliKuleTuru == "") return;

            PictureBox kuleResmi=new PictureBox();
            kuleResmi.Size=new Size(40,40);
            kuleResmi.SizeMode=PictureBoxSizeMode.StretchImage;
            kuleResmi.Left = e.X - 20;
            kuleResmi.Top = e.Y - 20;

            Kule yeniKule = null;

           

            if (seciliKuleTuru == "Ok" && oyuncuAltin >= 100)
            {
                kuleResmi.BackColor = Color.White;
                yeniKule = new OkKulesi(kuleResmi);
                oyuncuAltin -= 100;

            }
            
                else if (seciliKuleTuru == "Top" && oyuncuAltin >= 250)
            {
                kuleResmi.BackColor = Color.Orange;
                yeniKule = new TopKulesi(kuleResmi);
                oyuncuAltin -= 250;
            }
             else if(seciliKuleTuru=="Buyu" && oyuncuAltin>=400)
            {
                kuleResmi.BackColor = Color.Purple;
                yeniKule = new BuyuKulesi(kuleResmi);
                oyuncuAltin -= 400;
            }

            if (yeniKule != null)
            {
                this.Controls.Add(kuleResmi);
                kuleResmi.BringToFront();
                kulelerim.Add(yeniKule);

                lblAltin.Text= "Altýn: " + oyuncuAltin.ToString();

                seciliKuleTuru = "";
                this.Cursor = Cursors.Default;
            }

            else
            {
                seciliKuleTuru = "";
                this.Cursor = Cursors.Default;
                MessageBox.Show("Yeterli Altýnýnýz Yok!");
            }



        }
    }
}
