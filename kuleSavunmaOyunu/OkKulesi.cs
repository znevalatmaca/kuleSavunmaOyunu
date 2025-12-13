using System.Drawing;
using System.Windows.Forms;

namespace kuleSavunmaOyunu
{
    public class OkKulesi : Kule, ISaldirabilir
    {
        public OkKulesi(PictureBox gorsel) : base(100, 150, 15, gorsel)
        {

        }

        public override void Saldir()
        {
            
        }
    }
}