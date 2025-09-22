using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace xbIzzys_BO2_Camo_Tool.Things
{
    public class Label : UserControl
    {
        private string displayText = "Gradient Label";
        private Color startColor = Color.Blue;
        private Color endColor = Color.Red;
        private Font labelFont = new Font("Arial", 24, FontStyle.Bold);

        [Category("Appearance")]
        public string DisplayText
        {
            get => displayText;
            set { displayText = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color StartColor
        {
            get => startColor;
            set { startColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color EndColor
        {
            get => endColor;
            set { endColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Font LabelFont
        {
            get => labelFont;
            set { labelFont = value; Invalidate(); }
        }

        public Label()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.Size = new Size(200, 50);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle rect = this.ClientRectangle;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect, startColor, endColor, LinearGradientMode.Horizontal))
            {
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                e.Graphics.DrawString(displayText, labelFont, brush, rect, format);
            }
        }
    }
}
