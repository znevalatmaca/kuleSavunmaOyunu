using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kuleSavunmaOyunu
{
    public class OkKulesi : Kule, ISaldirabilir
    {

        private DateTime sonSaldiriZamani = DateTime.Now;
        public OkKulesi(PictureBox gorsel) : base(100, 150, 15, gorsel)
        {

        }

        public override void Saldir(List<Dusman> dusmanlar)
        {
            if ((DateTime.Now- sonSaldiriZamani).TotalSeconds < 1)
                return;

            Dusman enYakinDusman = null;
            double enKisaMesafe= double.MaxValue;
            
            foreach(Dusman d in dusmanlar)
            {
                double mesafe = Math.Sqrt(Math.Pow(this.Gorsel.Left - d.Gorsel.Left, 2) + Math.Pow(this.Gorsel.Top - d.Gorsel.Top, 2));

                if (mesafe<=this.Menzil && mesafe < enKisaMesafe)
                {
                    enKisaMesafe = mesafe;
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