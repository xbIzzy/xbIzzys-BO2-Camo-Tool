using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace xbIzzys_BO2_Camo_Tool.Things
{
    public class Panel : System.Windows.Forms.Panel
    {
        private Color startColor = Color.DeepPink;
        private Color endColor = Color.Cyan;
        private LinearGradientMode gradientMode = LinearGradientMode.Horizontal;

        public Color StartColor
        {
            get { return startColor; }
            set { startColor = value; Invalidate(); }
        }

        public Color EndColor
        {
            get { return endColor; }
            set { endColor = value; Invalidate(); }
        }

        public LinearGradientMode GradientMode
        {
            get { return gradientMode; }
            set { gradientMode = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, StartColor, EndColor, GradientMode))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}
