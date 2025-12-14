using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace kuleSavunmaOyunu
{
    public class BuyuKulesi : Kule,ISaldirabilir
    {

        public  DateTime sonSaldiriZamani = DateTime.Now;
        public BuyuKulesi(PictureBox gorsel) : base(200,130,25,gorsel)
        {
          
        }

        public override void Saldir(List<Dusman> dusmanlar)
        {
            
        }
    }
}
