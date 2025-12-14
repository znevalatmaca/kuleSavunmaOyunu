using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;   

namespace kuleSavunmaOyunu
{
    public class  TopKulesi:Kule,ISaldirabilir
    {
        public TopKulesi(PictureBox gorsel) : base(250, 120, 50, gorsel)
        {
        }

        public override void Saldir(List<Dusman> dusmanlar)
        {
            
        }
    }
}
