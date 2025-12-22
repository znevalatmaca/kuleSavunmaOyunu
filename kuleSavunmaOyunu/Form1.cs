using System.Diagnostics.Eventing.Reader;

namespace kuleSavunmaOyunu
{
    public partial class Form1 : Form
    {

        List<Panel> yolListesi = new List<Panel>();
        List<Dusman> dusmanlar = new List<Dusman>();

        int dusmanSpawnSayaci = 0;
        int mevcutDalga = 1;
        int spawnSuresi = 50;

        int temelDusmanCan = 50;
        int temelDusmanHiz = 2;
        Random rnd= new Random();

        int donguSayaci = 0;
        int dalgaSayisi = 0;
        int toplamDalga = 5;
        int oyuncuSkor = 0;

        int dalgaSeviyesi = 1;
        int oldurulenDusmanSayisi = 0;
        int dalgaHedefi = 3;

        int oyuncuCan = 10;

        int oyuncuAltin = 300;

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
            donguSayaci++;

            dusmanSpawnSayaci++;

            if(dusmanSpawnSayaci>=spawnSuresi && dusmanlar.Count < 8)
            {
                DusmanYarat();
                dusmanSpawnSayaci = 0;
            }

            
            foreach (Kule k in kulelerim)
            {
                k.Saldir(dusmanlar);
            }

            
            for (int i = dusmanlar.Count - 1; i >= 0; i--)
            {
                Dusman d = dusmanlar[i]; 
                Panel hedefYol = yolListesi[d.YolAdimi];

                int hedefX = (hedefYol.Left + hedefYol.Width / 2) - (d.Gorsel.Width / 2);
                int hedefY = (hedefYol.Top + hedefYol.Height / 2) - (d.Gorsel.Height / 2);


                if (d.Gorsel.Left < hedefYol.Left) d.Gorsel.Left += d.Hiz;
                if (d.Gorsel.Left > hedefYol.Left) d.Gorsel.Left -= d.Hiz;
                if (d.Gorsel.Top < hedefYol.Top) d.Gorsel.Top += d.Hiz;
                if (d.Gorsel.Top > hedefYol.Top) d.Gorsel.Top -= d.Hiz;

                if (d.CanBari != null)
                {
                    d.CanBari.Left = d.Gorsel.Left;
                    d.CanBari.Top = d.Gorsel.Top-10;
                }

                if (d.BaslangicCani>0)
                {
                    float canYuzdesi=(float)d.Can/d.BaslangicCani;

                    d.CanBari.Width=(int)(d.Gorsel.Width*canYuzdesi);

                    if (canYuzdesi < 0.3) d.CanBari.BackColor = Color.Red;
                    else if (canYuzdesi < 0.6) d.CanBari.BackColor = Color.Orange;
                    else d.CanBari.BackColor = Color.LimeGreen;

                }
               

                if (Math.Abs(d.Gorsel.Left - hedefYol.Left) < 15 && Math.Abs(d.Gorsel.Top - hedefYol.Top) < 15)
                {
                    d.YolAdimi++;

               
                    if (d.YolAdimi >= yolListesi.Count)
                    {
                        oyuncuCan -= 1;
                        if (lblCan != null) lblCan.Text = "Can: " + oyuncuCan;
                        if (d.CanBari != null) { this.Controls.Remove(d.CanBari); d.CanBari.Dispose(); }
                        this.Controls.Remove(d.Gorsel); d.Gorsel.Dispose();
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
                    oyuncuSkor += 10;
                    
                    
                    if (lblAltin != null) lblAltin.Text = "Altýn: " + oyuncuAltin;
                    if(lblSkor!=null) lblSkor.Text="Skor: " + oyuncuSkor;

                    if (d.CanBari != null)
                    {
                        this.Controls.Remove(d.CanBari);
                        d.CanBari.Dispose();
                    }

                    if (d.Gorsel != null)
                    {
                        this.Controls.Remove(d.Gorsel);
                        d.Gorsel.Dispose();
                    }
                    dusmanlar.RemoveAt(i);

                    oldurulenDusmanSayisi++;

                    if (oldurulenDusmanSayisi >= dalgaHedefi)
                    {
                        DalgaAtla();
                    }

                   
                }
            }

            if (donguSayaci%5==0)
            {
                foreach(var kule in kulelerim)
                {
                    if (kule is ISaldirabilir saldiranKule)
                    {
                        saldiranKule.Saldir(dusmanlar);
                    }
                }
            }
        }
        private void DusmanYarat()
        {
            PictureBox resim = new PictureBox();
            resim.BackColor = Color.Transparent;
            resim.Image=Properties.Resources.dusman6;

            resim.Size = new Size(40, 40);
            resim.SizeMode = PictureBoxSizeMode.StretchImage;

            resim.Left = yolListesi[0].Left;
            resim.Top = yolListesi[0].Top;

            this.Controls.Add(resim);
            resim.BringToFront();
            
            int yeniCan = 120 + (dalgaSeviyesi * 20);
            int yeniOdul=10+ (dalgaSeviyesi * 2);

            int temelHiz = 3;
            int yeniHiz = temelHiz + (dalgaSeviyesi / 2);

           Dusman yeniDusman = new Dusman(yeniCan, 5, yeniOdul, resim);
           

            yeniDusman.BaslangicCani = yeniCan;

            Panel bar=new Panel();
            bar.BackColor = Color.LimeGreen;
            bar.Size = new Size(resim.Width,5);

            this.Controls.Add(bar);
            bar.BringToFront();

            yeniDusman.CanBari = bar;

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

                lblAltin.Text= " Altýn: " + oyuncuAltin.ToString();

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
            dalgaHedefi += 3;

            spawnSuresi = Math.Max(10, spawnSuresi - 5);

            if(lblDalga!=null) lblDalga.Text="Dalga:" + dalgaSeviyesi+ "/" +toplamDalga;

            tmrOyun.Stop();
            MessageBox.Show(dalgaSeviyesi + ". Dalga Baþlýyor!Düþmanlar güçlendi.");
            tmrOyun.Start();

        }
    }
}
