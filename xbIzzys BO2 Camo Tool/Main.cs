using System;
using XDevkit;
using JRPC_Client;
using System.Drawing;
using System.Windows.Forms;

namespace xbIzzys_BO2_Camo_Tool
{
    public partial class Main : Form
    {
        Point lastPoint;
        IXboxConsole Console;
        bool Connected = false;

        public Main()
        {
            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await VersionCheck.CheckVersionAsync(lblVersion);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (Console.Connect(out Console))
            {
                Connected = true;
                lblStatus.Text = "Status: Connected";
                Console.XNotify("xbIzzys BO2 Camo Tool | Connected!");
                MessageBox.Show("Dont move around when injecting!", "xbIzzys BO2 Camo Tool");
            }
            else
            {
                Connected = false;
                lblStatus.Text = "Status: Failed";
            }
        }

        private void btnInjectAkatsuki_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("Akatsuki", Properties.Resources.AkatsukiGlow, Properties.Resources.AkatsukiReveal, Properties.Resources.AkatsukiRgb, Properties.Resources.AkatsukiCol, Properties.Resources.AkatsukiHeat);
        }

        private void btnInjectBubblegum_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("Bubblegum", Properties.Resources.BubblegumGlow, Properties.Resources.BubblegumReveal, Properties.Resources.BubblegumRgb, Properties.Resources.BubblegumCol, Properties.Resources.BubblegumHeat);
        }

        private void btnInjectxbIzzys_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("xbIzzys", Properties.Resources.xbIzzyGlow, Properties.Resources.xbIzzyReveal, Properties.Resources.xbIzzyRgb, Properties.Resources.xbIzzyCol, Properties.Resources.xbIzzyHeat);
        }

        private void btnInjectDarkMatter_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("Dark Matter", Properties.Resources.DarkMatterGlow, Properties.Resources.DarkMatterReveal, Properties.Resources.DarkMatterRgb, Properties.Resources.DarkMatterCol, Properties.Resources.DarkMatterHeat);
        }

        private void btnInjectLetItRip_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("let It Rip", Properties.Resources.letItRipGlow, Properties.Resources.letItRipReveal, Properties.Resources.letItRipRgb, Properties.Resources.letItRipCol, Properties.Resources.letItRipHeat);
        }

        private void btnInjectManipulation_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("Manipulation", Properties.Resources.ManipulationGlow, Properties.Resources.ManipulationReveal, Properties.Resources.ManipulationRgb, Properties.Resources.ManipulationCol, Properties.Resources.ManipulationHeat);
        }

        private void btnInjectRickandMorty_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("Rick and Morty", Properties.Resources.RickAndMortyGlow, Properties.Resources.RickAndMortyReveal, Properties.Resources.RickAndMortyRgb, Properties.Resources.RickAndMortyCol, Properties.Resources.RickAndMortyHeat);
        }

        private void btnInjectInterstellar_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("Interstellar", Properties.Resources.InterstellarGlow, Properties.Resources.InterstellarReveal, Properties.Resources.InterstellarRgb, Properties.Resources.InterstellarCol, Properties.Resources.InterstellarHeat);
        }

        private void btnInjectPlasma_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("Plasma", Properties.Resources.PlasmaGlow, Properties.Resources.PlasmaReveal, Properties.Resources.PlasmaRgb, Properties.Resources.PlasmaCol, Properties.Resources.PlasmaHeat);
        }

        private void btnInjectxbIzzysV2_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("xbIzzys V2", Properties.Resources.xbIzzysV2Glow, Properties.Resources.xbIzzysV2Reveal, Properties.Resources.xbIzzysV2Rgb, Properties.Resources.xbIzzysV2Col, Properties.Resources.xbIzzysV2Heat);
        }

        private void btnInjectRainbowLouieV_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("Rainbow Louie V", Properties.Resources.RLVGlow, Properties.Resources.RLVReveal, Properties.Resources.RLVRgb, Properties.Resources.RLVCol, Properties.Resources.RLVHeat);
        }

        private void btnInjectNetherPortal_Click(object sender, EventArgs e)
        {
            InjectCyborgCamo("Nether Portal", Properties.Resources.NpGlow, Properties.Resources.NpReveal, Properties.Resources.NpRgb, Properties.Resources.NpCol, Properties.Resources.NpHeat);
        }

        private void btnApplyCyborg_Click(object sender, EventArgs e)
        {
            if (!EnsureConnected()) return;
            DialogResult WarnRes = MessageBox.Show("1. Must be in Lobby\n2. Only Works for Public Match Classes", "xbIzzys BO2 Camo Tool", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (WarnRes == DialogResult.OK)
            {
                Console.SetMemory(0x84353A50, new byte[] { 0x0D, 0x01, 0x00 });
                Console.SetMemory(0x84353A5D, new byte[] { 0x0D, 0x87, 0x00 });
                Console.SetMemory(0x84353A83, new byte[] { 0x0D, 0xC1, 0x10 });
                Console.SetMemory(0x84353A92, new byte[] { 0x6D, 0x08, 0x00 });
                Console.SetMemory(0x84353AB9, new byte[] { 0x0D, 0x01, 0x00 });
                Console.SetMemory(0x84353AC6, new byte[] { 0x0D, 0x87, 0x00 });
                Console.SetMemory(0x84353AED, new byte[] { 0xCD, 0x10, 0x00 });
                Console.SetMemory(0x84353AFB, new byte[] { 0x6D, 0x08, 0x00 });
                Console.SetMemory(0x84353B22, new byte[] { 0x0D, 0x01, 0x00 });
                Console.SetMemory(0x84353B30, new byte[] { 0x87, 0x00, 0x00 });
                Console.SetMemory(0x84353B56, new byte[] { 0xCD, 0x10, 0x00 });
                Console.SetMemory(0x84353B64, new byte[] { 0x6D, 0x08, 0x00 });
                Console.SetMemory(0x84353B8B, new byte[] { 0x0D, 0x01, 0x00 });
                Console.SetMemory(0x84353B99, new byte[] { 0x87, 0x00, 0x00 });
                Console.SetMemory(0x84353BBF, new byte[] { 0xCD, 0x10, 0x00 });
                Console.SetMemory(0x84353BCD, new byte[] { 0x6D, 0x08, 0x00 });
                Console.SetMemory(0x84353BF4, new byte[] { 0x0D, 0x01, 0x00 });
                Console.SetMemory(0x84353C02, new byte[] { 0x87, 0x00, 0x00 });
                Console.SetMemory(0x84353C28, new byte[] { 0xCD, 0x10, 0x00 });
                Console.SetMemory(0x84353C36, new byte[] { 0x6D, 0x08, 0x00 });
                Console.XNotify("xbIzzys BO2 Camo Tool | Applied Cyborg to Public Classes");
            }
            else return;
        }

        private void btnChangelogs_Click(object sender, EventArgs e)
        {
            MessageBox.Show(       
                    "(+) Added Plasma Camo\n" +
                    "(~) Fixed Akatsuki Camo\n" +
                    "(+) Added Version Check\n" +
                    "(+) Added xbIzzys V2 Camo\n" +
                    "(+) Added Nether Portal Camo\n" +
                    "(+) Added Rainbow Louie V Camo\n" +
                    "(~) Cleaned up code for Inject buttons\n" +
                    "(+) Added Discord and Youtube buttons\n" +
                    "(+) Added Apply Cyborg to all public classes\n" +
                    "(+) Added Connected to Console checks to every button\n" +
                    "(~) Moved Custom Winform Controls to a Class Library ( xbIzzy.dll )",
                    "xbIzzys BO2 Camo Tool V1.1 Changelog"
                );
        }

        private void btnMyYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@xbIzzyxex");
        }

        private void btnMyDiscordUser_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show($"Discord Username: xblzzyxex\nPress OK to copy", "xbIzzys BO2 Camo Tool", MessageBoxButtons.OKCancel);
            if (Res == DialogResult.OK)
            {
                Clipboard.SetText("xblzzyxex");
            }
        }
       
        // Makes form dragable at the top
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void lblName_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void lblName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void cbPreviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CurrPreview = cbPreviews.Text;
            switch (CurrPreview)
            {
                case "Akatsuki":
                    pbPreviews.Image = Properties.Resources.Akatsuki_Preview;
                    break;

                case "Bubblegum":
                    pbPreviews.Image = Properties.Resources.Bubblegum_Preview;
                    break;

                case "xbIzzys":
                    pbPreviews.Image = Properties.Resources.xbIzzy_Preview;
                    break;

                case "Dark Matter":
                    pbPreviews.Image = Properties.Resources.DarkMatter_Preview;
                    break;

                case "Let It Rip":
                    pbPreviews.Image = Properties.Resources.letItRip_Preview;
                    break;

                case "Manipulation":
                    pbPreviews.Image = Properties.Resources.Manipulation_Preview;
                    break;

                case "Rick and Morty":
                    pbPreviews.Image = Properties.Resources.RickAndMorty_Preview;
                    break;

                case "Interstellar":
                    pbPreviews.Image = Properties.Resources.Interstellar_Preview;
                    break;

                case "Plasma":
                    pbPreviews.Image = Properties.Resources.Plasma_Preview;
                    break;

                case "xbIzzys V2":
                    pbPreviews.Image = Properties.Resources.xbIzzyV2_Preview;
                    break;

                case "Rainbow Louie V":
                    pbPreviews.Image = Properties.Resources.RainbowLouieV_Preview;
                    break;

                case "Nether Portal":
                    pbPreviews.Image = Properties.Resources.NetherPortal_Preview;
                    break;
            }
        }

        private void InjectCyborgCamo(string Name, byte[] Glow, byte[] Reveal, byte[] Rgb, byte[] Col, byte[] Heat)
        {
            if (!EnsureConnected()) return;
            Console.WriteByte(0x82FF9B57, 0x03);
            Console.WriteByte(0x82FF9CFF, 0x03);
            Console.WriteByte(0x82FF9DD3, 0x03);
            Console.WriteByte(0x82FF9EA7, 0x03);
            Console.WriteByte(0x82FF9F7B, 0x03);
            Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Glow);
            Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Reveal);
            Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Rgb);
            Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Col);
            Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Heat);
            Console.XNotify($"xbIzzys BO2 Camo Tool | {Name} Camo Done!");
        }
        
        private bool EnsureConnected()
        {
            if (!Connected || Console == null)
            {
                MessageBox.Show("Connect to Console first!", "xbIzzys BO2 Camo Tool");
                return false;
            }
            return true;
        }
    }
}
