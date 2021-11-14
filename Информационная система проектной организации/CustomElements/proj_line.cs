using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Информационная_система_проектной_организации.CustomElements
{
    public class proj_line : Control
    {
        private StringFormat SF;
        private Rectangle rectangle;

        public proj_line()
        {
            SF = new StringFormat();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            BackColor = Color.Black;
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
            Size = new System.Drawing.Size(100, 30);
            rectangle = new Rectangle(1, 1, Width - 3, Height - 3);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Parent.BackColor);

            g.DrawLine(new Pen(BackColor, Height*2), 0, Height / 2, Width, Height / 2);
            
        }
    }
}
