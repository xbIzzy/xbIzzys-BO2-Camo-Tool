using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace xbIzzys_BO2_Camo_Tool.Things
{
    public class Border : UserControl
    {
        private Timer timer;
        private float blendFactor = 0f;
        private bool increasing = true;

        public Color GradientColor1 { get; set; } = Color.DeepPink;
        public Color GradientColor2 { get; set; } = Color.Cyan;

        public Border()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(200, 100);

            timer = new Timer { Interval = 50 };
            timer.Tick += (s, e) => AnimateBorder();
            timer.Start();
        }

        private void AnimateBorder()
        {
            if (increasing)
            {
                blendFactor += 0.05f;
                if (blendFactor >= 1f) increasing = false;
            }
            else
            {
                blendFactor -= 0.05f;
                if (blendFactor <= 0f) increasing = true;
            }
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, this.Width, this.Height),
                InterpolateColor(GradientColor1, GradientColor2, blendFactor),
                InterpolateColor(GradientColor2, GradientColor1, blendFactor),
                LinearGradientMode.ForwardDiagonal))
            {
                using (Pen pen = new Pen(brush, 5))
                {
                    e.Graphics.DrawRectangle(pen, 2, 2, this.Width - 5, this.Height - 5);
                }
            }
        }

        private Color InterpolateColor(Color c1, Color c2, float factor)
        {
            int r = (int)(c1.R + (c2.R - c1.R) * factor);
            int g = (int)(c1.G + (c2.G - c1.G) * factor);
            int b = (int)(c1.B + (c2.B - c1.B) * factor);
            return Color.FromArgb(r, g, b);
        }
    }
}
