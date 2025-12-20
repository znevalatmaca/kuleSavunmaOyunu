using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace kuleSavunmaOyunu
{
    public class BuyuKulesi : Kule,ISaldirabilir,IYukseltilebilir
    {

        private  DateTime sonSaldiriZamani = DateTime.Now;
        public int Seviye { get; set; } = 1;
        public BuyuKulesi(PictureBox gorsel) : base(200,130,25,gorsel)
        {
          
        }
        public void Yukselt()
        {
            this.Seviye++;
            this.Hasar += 15;
            this.Menzil += 30;
            this.Gorsel.Width += 5;
            this.Gorsel.Height += 5;
        }
        public override void Saldir(List<Dusman> dusmanlar)
        {
            if ((DateTime.Now - sonSaldiriZamani).TotalSeconds < 1.5) return;

            double menzilKaresi = this.Menzil * this.Menzil;

            
            List<Dusman> menzildekiler = new List<Dusman>();

            foreach (Dusman d in dusmanlar)
            {
                double farkX = this.Gorsel.Left - d.Gorsel.Left;
                double farkY = this.Gorsel.Top - d.Gorsel.Top;
                double mesafeKaresi = (farkX * farkX) + (farkY * farkY);


                if (mesafeKaresi <= menzilKaresi)
                {
                    menzildekiler.Add(d);
                }
            }

            
            if (menzildekiler.Count == 0) return;

           
            int vurulacakSayisi = Math.Min(menzildekiler.Count, 5);

            for (int i = 0; i < vurulacakSayisi; i++)
            {
                menzildekiler[i].Can -= this.Hasar;
            }

            sonSaldiriZamani = DateTime.Now;
        
        }
    }
}
