using System.Drawing;
using System.Windows.Forms;

namespace kuleSavunmaOyunu
{
    public class Dusman
    {
        public int Can { get; set; }
        public int Hiz { get; set; }
        public int Odul { get; set; }
        public PictureBox Gorsel { get; set; }

        public int YolAdimi { get; set; }

        public int BaslangicCani { get; set; }
        public Panel CanBari;

        public Dusman(int can,int hiz,int odul, PictureBox gorsel)
        {
            this.Can = can;
            this.Hiz = hiz;
            this.Odul = odul;
            this.Gorsel = gorsel;
            this.YolAdimi = 0;
        }
        public void HareketEt() 
        { 
        
        }
    }
}