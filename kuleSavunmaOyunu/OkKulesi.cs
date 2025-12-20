using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kuleSavunmaOyunu
{
    public class OkKulesi : Kule, ISaldirabilir,IYukseltilebilir
    {

        private DateTime sonSaldiriZamani = DateTime.Now;

        public int Seviye { get; set; } = 1;
        public OkKulesi(PictureBox gorsel) : base(100, 150, 15, gorsel)
        {

        }

        public void Yukselt()
        {
            this.Seviye++;
            this.Hasar += 10;
            this.Menzil += 20;
            this.Gorsel.Width += 5;
            this.Gorsel.Height += 5;

        }

        public override void Saldir(List<Dusman> dusmanlar)
        {
            if ((DateTime.Now- sonSaldiriZamani).TotalSeconds < 1.0)
                return;

            Dusman enYakinDusman = null;
            double enKisaMesafeKaresi= double.MaxValue;
            double menzilKaresi = this.Menzil * this.Menzil;

            foreach(Dusman d in dusmanlar)
            {
                double farkX = this.Gorsel.Left - d.Gorsel.Left;
                double farkY = this.Gorsel.Top - d.Gorsel.Top;
                double mesafeKaresi = (farkX * farkX) + (farkY * farkY);

                if (mesafeKaresi<=menzilKaresi && mesafeKaresi < enKisaMesafeKaresi)
                {
                    enKisaMesafeKaresi = mesafeKaresi;
                    enYakinDusman = d;
                }
            }

            if(enYakinDusman != null)
            {
                enYakinDusman.Can -= this.Hasar;
                sonSaldiriZamani = DateTime.Now;
            }
        }
    }
}