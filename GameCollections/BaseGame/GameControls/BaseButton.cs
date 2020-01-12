using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BaseGame.GameControls
{
    public class BaseButton : Button
    {
        public Image srcImage
        {
            get { return srcImage; }
            set { srcImage = value; }
        }

        public BaseButton()
        {

        }
    }
}
