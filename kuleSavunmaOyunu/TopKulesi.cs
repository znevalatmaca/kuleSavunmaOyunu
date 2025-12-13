using System.Drawing;
using System.Windows.Forms;

namespace kuleSavunmaOyunu
{
    public class  TopKulesi:Kule,ISaldirabilir
    {
        public TopKulesi(PictureBox gorsel) : base(250, 120, 50, gorsel)
        {
        }

        public override void Saldir()
        {
            
        }
    }
}
