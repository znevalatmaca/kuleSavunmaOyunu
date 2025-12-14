using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;   

namespace kuleSavunmaOyunu
{
    public class  TopKulesi:Kule,ISaldirabilir
    {
        private DateTime sonSaldiriZamani= DateTime.Now;
        public TopKulesi(PictureBox gorsel) : base(250, 120, 50, gorsel)
        {
        }

        public override void Saldir(List<Dusman> dusmanlar)
        {
            if ((DateTime.Now - sonSaldiriZamani).TotalSeconds < 3.0) return; 

            bool atesEdildi = false;

            foreach (Dusman d in dusmanlar)
            {
                double mesafe = Math.Sqrt(Math.Pow(this.Gorsel.Left - d.Gorsel.Left, 2) +
                                          Math.Pow(this.Gorsel.Top - d.Gorsel.Top, 2));

                
                if (mesafe <= this.Menzil)
                {
                    d.Can -= this.Hasar;
                    atesEdildi = true;
                }
            }

            if (atesEdildi)
            {
                sonSaldiriZamani = DateTime.Now;
            }
        }
    }
}
