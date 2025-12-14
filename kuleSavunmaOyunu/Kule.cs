using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace kuleSavunmaOyunu
{
    public abstract class Kule
    {
        public int _fiyat;
        public int _menzil;
        public int _hasar;
        private PictureBox _gorsel;

        public int Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public int Menzil
        {
            get { return _menzil; }
            set { _menzil = value; }
        }

        public int Hasar
        {
            get { return _hasar; }
            set { _hasar = value; }
        }
        public PictureBox Gorsel
        {
            get { return _gorsel; }
            set { _gorsel = value; }
        }

        public Kule(int fiyat,int menzil,int hasar,PictureBox gorsel)
        {
            this.Fiyat = fiyat;
            this.Menzil = menzil;
            this.Hasar = hasar;
            this.Gorsel = gorsel;
        }

        public abstract void Saldir(List<Dusman>dusmanlar);
    }
}