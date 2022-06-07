using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Insurance.Model
{
    public partial class employees
    {
        public SolidColorBrush ColorFrame { get; set; } = new SolidColorBrush(Colors.LightGray);
        
        public byte[] Photo
        {
            get
            {
                if (photo == null || photo.Length == 0) return new Byte[] { };

                if (File.Exists($"{photo.Substring(1)}"))
                {
                    return File.ReadAllBytes($"{photo.Substring(1)}");
                }
                if (File.Exists($"agents/picture.png"))
                {
                    return File.ReadAllBytes("agents\\picture.png");
                }
                return null;
            }
        }

        public override string ToString()
        {
            return FIO_insurer;
        }




    }
}
