using System.Diagnostics.Eventing.Reader;

namespace kuleSavunmaOyunu
{
    public partial class Form1 : Form
    {

        List<Panel> yolListesi = new List<Panel>();
        List<Dusman> dusmanlar = new List<Dusman>();

        int dalgaSayisi = 0;
        int toplamDalga = 5;
        int oyuncuSkor = 0;

        int dalgaSeviyesi = 1;
        int oldurulenDusmanSayisi = 0;
        int dalgaHedefi = 5;

        int oyuncuCan = 20;

        int oyuncuAltin = 1000;

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
            // 1. DÜÞMAN YARATMA (SPAWN)
            Random rnd = new Random();
            if (rnd.Next(0, 100) < 2)
            {
                DusmanYarat();
            }

            // 2. KULELER SALDIRSIN
            foreach (Kule k in kulelerim)
            {
                k.Saldir(dusmanlar);
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
                        oyuncuCan -= 1;
                        if (lblCan != null) lblCan.Text = "Can: " + oyuncuCan;

                        this.Controls.Remove(d.Gorsel); 
                        dusmanlar.RemoveAt(i);          

                        if (oyuncuCan <= 0)
                        {
                            tmrOyun.Stop();
                            MessageBox.Show("OYUN BÝTTÝ! Kaybettin.");
                            this.Close();
                        }

                        continue; 
                    }
                }
                
                if (d.Can <= 0)
                {                  
                    oyuncuAltin += d.Odul;
                    if (lblAltin != null) lblAltin.Text = "Altýn: " + oyuncuAltin;

                    oyuncuSkor += 10;

                    if(lblSkor!=null) lblSkor.Text="Skor: " + oyuncuSkor;

                    this.Controls.Remove(d.Gorsel);             
                    dusmanlar.RemoveAt(i);
                    oldurulenDusmanSayisi++;

                    if (oldurulenDusmanSayisi >= dalgaHedefi)
                    {
                        DalgaAtla();
                    }
                }
            }
        }
        private void DusmanYarat()
        {
            PictureBox resim = new PictureBox();
            resim.BackColor = Color.Transparent;
            resim.Image=Properties.Resources.dusman4;

            resim.Size = new Size(40, 40);
            resim.SizeMode = PictureBoxSizeMode.StretchImage;

            resim.Left = yolListesi[0].Left;
            resim.Top = yolListesi[0].Top;

            this.Controls.Add(resim);
            resim.Parent = this;
            resim.BringToFront();
            
            int yeniCan = 100 + (dalgaSeviyesi * 20);
            int yeniOdul=10+ (dalgaSeviyesi * 2);

           Dusman yeniDusman = new Dusman(yeniCan, 5, yeniOdul, resim);
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
            kuleResmi.Size=new Size(60,60);
            kuleResmi.SizeMode=PictureBoxSizeMode.StretchImage;
            kuleResmi.BackColor = Color.Transparent;
            

            kuleResmi.Left = e.X - 20;
            kuleResmi.Top = e.Y - 20;

            Kule yeniKule = null;
           

            if (seciliKuleTuru == "Ok" && oyuncuAltin >= 100)
            {
                kuleResmi.Image = Properties.Resources.kule_ok;
                yeniKule = new OkKulesi(kuleResmi);
                oyuncuAltin -= 100;

            }
            
                else if (seciliKuleTuru == "Top" && oyuncuAltin >= 250)
            {
                kuleResmi.Image = Properties.Resources.kule_top;
                yeniKule = new TopKulesi(kuleResmi);
                oyuncuAltin -= 250;
            }
             else if(seciliKuleTuru=="Buyu" && oyuncuAltin>=200)
            {
                kuleResmi.Image = Properties.Resources.kule_buyu;
                yeniKule = new BuyuKulesi(kuleResmi);
                oyuncuAltin -= 200;
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

        private void DalgaAtla()
        {

            if(dalgaSeviyesi>=toplamDalga)
            {
                tmrOyun.Stop();
                MessageBox.Show("Tebrikler! Tüm Dalgalarý Geçtiniz!");
                Application.Restart();
                return;
            }
            dalgaSeviyesi++;
            oldurulenDusmanSayisi = 0;
            dalgaHedefi += 5;

            if(lblDalga!=null) lblDalga.Text="Dalga:" + dalgaSeviyesi+ "/" +toplamDalga;

            tmrOyun.Stop();
            MessageBox.Show(dalgaSeviyesi + ". Dalga Baþlýyor!Düþmanlar güçlendi.");
            tmrOyun.Start();

        }
    }
}
