using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace kuleSavunmaOyunu
{
    public class BuyuKulesi : Kule,ISaldirabilir
    {

        private  DateTime sonSaldiriZamani = DateTime.Now;
        public BuyuKulesi(PictureBox gorsel) : base(200,130,25,gorsel)
        {
          
        }

        public override void Saldir(List<Dusman> dusmanlar)
        {
            if ((DateTime.Now - sonSaldiriZamani).TotalSeconds < 1.5) return; 

            
            List<Dusman> menzildekiler = new List<Dusman>();

            foreach (Dusman d in dusmanlar)
            {
                double mesafe = Math.Sqrt(Math.Pow(this.Gorsel.Left - d.Gorsel.Left, 2) +
                                          Math.Pow(this.Gorsel.Top - d.Gorsel.Top, 2));

                if (mesafe <= this.Menzil)
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
