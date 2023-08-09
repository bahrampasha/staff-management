using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sarbaz.DataLayer.Repositories;
using System.Windows.Forms;
using System.IO;

namespace Sarbaz.DataLayer.Services
{
    public class ImageRepository : IImage
    {
        string filename;

        public Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        public byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public Image GetImage()
        {
            using (OpenFileDialog openimage = new OpenFileDialog()
            { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })

                if (openimage.ShowDialog() == DialogResult.OK)
                {
                    filename = openimage.FileName;
                }
            return Image.FromFile(filename);
        }
    }
}
