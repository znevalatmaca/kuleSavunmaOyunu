using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;   

namespace kuleSavunmaOyunu
{
    public class  TopKulesi:Kule,ISaldirabilir,IYukseltilebilir
    {
        private DateTime sonSaldiriZamani= DateTime.Now;

        public int Seviye { get; set; } = 1;
        public TopKulesi(PictureBox gorsel) : base(250, 120, 50, gorsel)
        {
        }

        public void Yukselt()
        {
            this.Seviye++;
            this.Hasar += 25;
            this.Menzil += 10;
            this.Gorsel.Width += 5;
            this.Gorsel.Height += 5;
        }
        public override void Saldir(List<Dusman> dusmanlar)
        {
            if ((DateTime.Now - sonSaldiriZamani).TotalSeconds < 3.0) return; 

            double menzilKaresi = this.Menzil * this.Menzil;
            bool biriVurulduMu = false;


            foreach (Dusman d in dusmanlar)
            {
                double farkX = this.Gorsel.Left - d.Gorsel.Left;
                double farkY = this.Gorsel.Top - d.Gorsel.Top;
                double mesafeKaresi = (farkX * farkX) + (farkY * farkY);

                
                if (mesafeKaresi <= menzilKaresi)
                {
                    d.Can -= this.Hasar;
                    biriVurulduMu = true;
                }
            }

            if (biriVurulduMu)
            {
                sonSaldiriZamani = DateTime.Now;
            }
        }
    }
}
