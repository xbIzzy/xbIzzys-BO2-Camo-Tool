using System.Drawing;

namespace xbIzzys_BO2_Camo_Tool.Utilities.Camos
{
    public class DragonCamo
    {
        public string Name { get; set; }

        public byte[] Ember { get; set; }
        public byte[] Reveal { get; set; }
        public byte[] MtlReveal { get; set; }

        public byte[] Col { get; set; }
        public byte[] AltCol { get; set; }

        public byte[] Rgb { get; set; }
        public byte[] AltRgb { get; set; }

        public byte[] Heat { get; set; }

        public Image Preview { get; set; }
    }
}
