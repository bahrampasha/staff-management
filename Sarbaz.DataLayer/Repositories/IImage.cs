using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Sarbaz.DataLayer.Repositories
{
    interface IImage
    {
        Image GetImage();
        byte[] ConvertImageToBinary(Image img);
        Image ConvertBinaryToImage(byte[] data);
    }
}
