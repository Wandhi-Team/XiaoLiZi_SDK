using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsTool.Form
{
    public class CustomDataGridView : UIDataGridView
    {
        public new void OnPaint(PaintEventArgs e)
        {
            if (e == null)
            {
                return;
            }
            base.OnPaint(e);

            if (ShowRect)
            {
                Color color = RectColor;
                color = Enabled ? color : UIDisableColor.Fill;
                e.Graphics.DrawRectangle(color, new Rectangle(0, 0, Width - 1, Height - 1));
            }
        }
    }
}
