namespace kuleSavunmaOyunu
{
    public partial class Form1 : Form
    {

        List<Panel> yolListesi = new List<Panel>();
        List<Dusman> dusmanlar = new List<Dusman>();

        int dalgaSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yolListesi.Add(pnlYol1);
            yolListesi.Add(pnlYol2);
            yolListesi.Add(pnlYol3);
            yolListesi.Add(pnlYol4);
            yolListesi.Add(pnlYol5);

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
    }
}
