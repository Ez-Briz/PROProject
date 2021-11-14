using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Информационная_система_проектной_организации.CustomElements
{
    public class proj_button : Control
    {
        private bool MouseEntered = false;
        private bool MousePressed = false;
        private StringFormat SF;
        private Rectangle rectangle;
        Animation CircleAnim = new Animation();


        Point ClickLocation = new Point();
        public proj_button()
        {
            SF = new StringFormat();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            BackColor = Color.White;
            ForeColor = Color.Black;
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
            Size = new System.Drawing.Size(100, 30);
            rectangle = new Rectangle(1, 1, Width - 3, Height - 3);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            rectangle = new Rectangle(1, 1, Width - 3, Height - 3);
        }

        private GraphicsPath RoundedRect(Rectangle rect, int RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);
            gp.CloseFigure();
            return gp;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Parent.BackColor);

            Rectangle rectangleCircle = new Rectangle(ClickLocation.X - (int)CircleAnim.Value / 8,
                ClickLocation.Y - (int)CircleAnim.Value / 8,
                (int)CircleAnim.Value / 4, (int)CircleAnim.Value / 4);
            GraphicsPath rectGP = RoundedRect(rectangle, rectangle.Height);
            g.DrawPath(new Pen(Color.Black, 2), rectGP);
            g.FillPath(new SolidBrush(BackColor), rectGP);
            if (MouseEntered)
            {
                g.DrawPath(new Pen(Color.FromArgb(25, Color.Black), 2), rectGP);
                g.FillPath(new SolidBrush(Color.FromArgb(25, Color.Black)), rectGP);
            }
            if (!Enabled)
            {
                g.FillPath(new SolidBrush(Color.FromArgb(35, Color.Black)), rectGP);
            }
            if (CircleAnim.Value > 0 && CircleAnim.Value < CircleAnim.TargetValue)
            {
                g.DrawEllipse(new Pen(Color.FromArgb(20, Color.Black), 2), rectangleCircle);
                g.FillEllipse(new SolidBrush(Color.FromArgb(20, Color.Black)), rectangleCircle);
            }
            else if (CircleAnim.Value == CircleAnim.TargetValue)
            {
                CircleAnim.Value = 0;
            }
            g.DrawString(Text, Font, new SolidBrush(ForeColor), rectangle, SF);
        }
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;
            Invalidate();
        }


        private void CircleAnimMethod()
        {
            CircleAnim = new Animation("CircleAnim_" + Handle, Invalidate, 0, Width);

            Animator.Request(CircleAnim, true);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = true;
            ClickLocation = e.Location;
            CircleAnimMethod();
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter)
            {
                OnClick(new MouseEventArgs(MouseButtons.Left, 1, Width/2, Height/2, 0));
            }
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
        }
        protected override void OnTabIndexChanged(EventArgs e)
        {
            base.OnTabIndexChanged(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = false;

            Invalidate();
        }
    }
}
