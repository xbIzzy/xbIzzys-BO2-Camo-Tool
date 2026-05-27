using System.Drawing;

namespace xbIzzys_BO2_Camo_Tool.Utilities.Camos
{
    public class CyborgCamo
    {
        public string Name { get; set; }

        public byte[] Glow { get; set; }
        public byte[] Reveal { get; set; }
        public byte[] Rgb { get; set; }
        public byte[] Col { get; set; }
        public byte[] Heat { get; set; }

        public Image Preview { get; set; }
    }
}