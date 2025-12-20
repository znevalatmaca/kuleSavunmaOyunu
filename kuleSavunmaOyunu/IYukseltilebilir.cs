using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuleSavunmaOyunu
{
    internal interface IYukseltilebilir
    {
        void Yukselt();

        int Seviye {  get; set; }
    }
}
