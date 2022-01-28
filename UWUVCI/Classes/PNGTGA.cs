using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWUVCI.Classes
{
	[Serializable]
    public class PNGTGA
    {
		private string imgPath = null;

		public string ImgPath 
		{
			get { return imgPath; }
			set { imgPath = value;
			}
		}

		public byte[] ImgBin { get; set; } = null;

		public string extension { get; set; }
    }
}
