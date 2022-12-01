using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.GUI
{
    public static class ListChatUtilities
    {
        public static int GetTextHeight(Label lbl)
        {
            using(Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 328);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
