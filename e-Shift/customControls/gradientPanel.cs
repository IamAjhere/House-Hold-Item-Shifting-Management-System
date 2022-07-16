using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace e_Shift.customControls
{
    internal class gradientPanel : Panel
    {
        public Color topcolor { get; set; }

        public Color botColor { get; set; }

        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.topcolor, this.botColor, this.Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(brush,this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
