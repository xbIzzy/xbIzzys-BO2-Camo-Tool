using System;
using XDevkit;
using JRPC_Client;
using System.Drawing;
using System.Threading.Tasks;
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
            cbPreviews.SelectedIndex = 0;
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

        private async void btnInjectCustomCyborgCamo_Click(object sender, EventArgs e)
        {
            string CyborgCamos = cbCyborgCamos.Text;
            switch (CyborgCamos)
            {
                case "Akatsuki":
                    await InjectCyborgCamo("Akatsuki", Properties.Resources.AkatsukiGlow, Properties.Resources.AkatsukiReveal, Properties.Resources.AkatsukiRgb, Properties.Resources.AkatsukiCol, Properties.Resources.AkatsukiHeat);
                    break;

                case "Bubblegum":
                    await InjectCyborgCamo("Bubblegum", Properties.Resources.BubblegumGlow, Properties.Resources.BubblegumReveal, Properties.Resources.BubblegumRgb, Properties.Resources.BubblegumCol, Properties.Resources.BubblegumHeat);
                    break;

                case "xbIzzys":
                    await InjectCyborgCamo("xbIzzys", Properties.Resources.xbIzzyGlow, Properties.Resources.xbIzzyReveal, Properties.Resources.xbIzzyRgb, Properties.Resources.xbIzzyCol, Properties.Resources.xbIzzyHeat);
                    break;

                case "Dark Matter":
                    await InjectCyborgCamo("Dark Matter", Properties.Resources.DarkMatterGlow, Properties.Resources.DarkMatterReveal, Properties.Resources.DarkMatterRgb, Properties.Resources.DarkMatterCol, Properties.Resources.DarkMatterHeat);
                    break;

                case "Let It Rip":
                    await InjectCyborgCamo("let It Rip", Properties.Resources.letItRipGlow, Properties.Resources.letItRipReveal, Properties.Resources.letItRipRgb, Properties.Resources.letItRipCol, Properties.Resources.letItRipHeat);
                    break;

                case "Manipulation":
                    await InjectCyborgCamo("Manipulation", Properties.Resources.ManipulationGlow, Properties.Resources.ManipulationReveal, Properties.Resources.ManipulationRgb, Properties.Resources.ManipulationCol, Properties.Resources.ManipulationHeat);
                    break;

                case "Rick and Morty":
                    await InjectCyborgCamo("Rick and Morty", Properties.Resources.RickAndMortyGlow, Properties.Resources.RickAndMortyReveal, Properties.Resources.RickAndMortyRgb, Properties.Resources.RickAndMortyCol, Properties.Resources.RickAndMortyHeat);
                    break;

                case "Interstellar":
                    await InjectCyborgCamo("Interstellar", Properties.Resources.InterstellarGlow, Properties.Resources.InterstellarReveal, Properties.Resources.InterstellarRgb, Properties.Resources.InterstellarCol, Properties.Resources.InterstellarHeat);
                    break;

                case "Plasma":
                    await InjectCyborgCamo("Plasma", Properties.Resources.PlasmaGlow, Properties.Resources.PlasmaReveal, Properties.Resources.PlasmaRgb, Properties.Resources.PlasmaCol, Properties.Resources.PlasmaHeat);
                    break;

                case "xbIzzys V2":
                    await InjectCyborgCamo("xbIzzys V2", Properties.Resources.xbIzzysV2Glow, Properties.Resources.xbIzzysV2Reveal, Properties.Resources.xbIzzysV2Rgb, Properties.Resources.xbIzzysV2Col, Properties.Resources.xbIzzysV2Heat);
                    break;

                case "Rainbow Louie V":
                    await InjectCyborgCamo("Rainbow Louie V", Properties.Resources.RLVGlow, Properties.Resources.RLVReveal, Properties.Resources.RLVRgb, Properties.Resources.RLVCol, Properties.Resources.RLVHeat);
                    break;

                case "Nether Portal":
                    await InjectCyborgCamo("Nether Portal", Properties.Resources.NpGlow, Properties.Resources.NpReveal, Properties.Resources.NpRgb, Properties.Resources.NpCol, Properties.Resources.NpHeat);
                    break;
            }
        }

        private async void btnInjectCustomDragonCamo_Click(object sender, EventArgs e)
        {
            string DragonCamos = cbDragonCamos.Text;
            switch (DragonCamos)
            {
                case "115 Lava":
                    await InjectDragonCamo("115 Lava", Properties.Resources.LavaEmber, Properties.Resources.LavaReveal, Properties.Resources.LavaMtlReveal, Properties.Resources.LavaCol, Properties.Resources.LavaAltCol, Properties.Resources.LavaRgb, Properties.Resources.LavaAltRgb, Properties.Resources.LavaHeat);
                    break;

                case "Rainbow Diamond":
                    await InjectDragonCamo("Rainbow Diamond", Properties.Resources.RainbowDiamondEmber, Properties.Resources.RainbowDiamondReveal, Properties.Resources.RainbowDiamondMtlReveal, Properties.Resources.RainbowDiamondCol, Properties.Resources.RainbowDiamondAltCol, Properties.Resources.RainbowDiamondRgb, Properties.Resources.RainbowDiamondAltRgb, Properties.Resources.RainbowDiamondHeat);
                    break;
            }
        }

        private void btnApplyCyborg_Click(object sender, EventArgs e)
        {
            if (!EnsureConnected()) return;
            DialogResult WarnRes = MessageBox.Show("1. Must be in Main Menu\n2. Only Works for Public Match Classes", "xbIzzys BO2 Camo Tool", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnApplyDragon_Click(object sender, EventArgs e)
        {
            if (!EnsureConnected()) return;
            DialogResult WarnRes = MessageBox.Show("1. Must be in Main Menu\n2. Only Works for Public Match Classes", "xbIzzys BO2 Camo Tool", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (WarnRes == DialogResult.OK)
            {
                Console.SetMemory(0x84353A50, new byte[] { 0x11, 0xA1, 0x00 });
                Console.SetMemory(0x84353A5D, new byte[] { 0x00, 0x88, 0x00 });
                Console.SetMemory(0x84353A83, new byte[] { 0x00, 0x00, 0x11 });
                Console.SetMemory(0x84353A92, new byte[] { 0x80, 0xA8, 0x00 });
                Console.SetMemory(0x84353AB9, new byte[] { 0x10, 0x01, 0x00 });
                Console.SetMemory(0x84353AC6, new byte[] { 0x00, 0x88, 0x00 });
                Console.SetMemory(0x84353AED, new byte[] { 0x00, 0x11, 0x00 });
                Console.SetMemory(0x84353AFB, new byte[] { 0x80, 0x08, 0x00 });
                Console.SetMemory(0x84353B22, new byte[] { 0x10, 0x01, 0x00 });
                Console.SetMemory(0x84353B30, new byte[] { 0x88, 0x00, 0x00 });
                Console.SetMemory(0x84353B56, new byte[] { 0x00, 0x11, 0x00 });
                Console.SetMemory(0x84353B64, new byte[] { 0x80, 0x08, 0x00 });
                Console.SetMemory(0x84353B8B, new byte[] { 0x10, 0x01, 0x00 });
                Console.SetMemory(0x84353B99, new byte[] { 0x88, 0x0A, 0x00 });
                Console.SetMemory(0x84353BBF, new byte[] { 0x00, 0x11, 0x00 });
                Console.SetMemory(0x84353BCD, new byte[] { 0x80, 0x08, 0x00 });
                Console.SetMemory(0x84353BF4, new byte[] { 0x10, 0x01, 0x00 });
                Console.SetMemory(0x84353C02, new byte[] { 0x88, 0x00, 0x00 });
                Console.SetMemory(0x84353C28, new byte[] { 0x00, 0x11, 0x00 });
                Console.SetMemory(0x84353C36, new byte[] { 0x80, 0x08, 0x00 });
                Console.XNotify("xbIzzys BO2 Camo Tool | Applied Dragon to Public Classes");
            }
            else return;
        }

        private void btnChangelogs_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "(+) Added 115 Lava Camo\n" +
                    "(+) Added Dragon Inject Code\n" +
                    "(+) Added Rainbow Diamond Camo\n" +
                    "(+) Added Apply Dragon to all public classes\n" +
                    "(+) Added Loading Screen when injecting camos\n" +
                    "(-) Removed Inject Camo Buttons for Comboboxes\n",
                    "xbIzzys BO2 Camo Tool V1.2 Changelog"
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

                case "115 Lava":
                    pbPreviews.Image = Properties.Resources.Lava_Preview;
                    break;
                case "Rainbow Diamond":
                    pbPreviews.Image = Properties.Resources.RainbowDiamond_Preview;
                    break;
            }
        }

        public async Task InjectCyborgCamo(string CamoName, byte[] Glow, byte[] Reveal, byte[] Rgb, byte[] Col, byte[] Heat)
        {
            if (!EnsureConnected()) return;
            using (Loading loadingForm = new Loading())
            {
                loadingForm.Show();
                loadingForm.Refresh();
                await Task.Run(() =>
                {
                    int step = 0;
                    int totalSteps = 5;

                    void UpdateProgress(string message)
                    {
                        int percent = (int)((++step / (float)totalSteps) * 100);
                        loadingForm.SetProgress(percent, message);
                    }
                    Console.WriteByte(0x82FF9B57, 0x03);
                    Console.WriteByte(0x82FF9CFF, 0x03);
                    Console.WriteByte(0x82FF9DD3, 0x03);
                    Console.WriteByte(0x82FF9EA7, 0x03);
                    Console.WriteByte(0x82FF9F7B, 0x03);
                    UpdateProgress("Writing Glow...");
                    Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Glow);
                    UpdateProgress("Writing Reveal...");
                    Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Reveal);
                    UpdateProgress("Writing RGB...");
                    Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Rgb);
                    UpdateProgress("Writing Color...");
                    Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Col);
                    UpdateProgress("Writing Heat...");
                    Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Heat);
                });
                loadingForm.Close();
            }
            Console.XNotify($"xbIzzys BO2 Camo Tool | {CamoName} Camo Done!");
        }

        public async Task InjectDragonCamo(string CamoName, byte[] Ember, byte[] Reveal, byte[] MtlReveal, byte[] Col, byte[] AltCol, byte[] Rgb, byte[] AltRgb, byte[] Heat)
        {
            if (!EnsureConnected()) return;
            using (Loading loadingForm = new Loading())
            {
                loadingForm.Show();
                loadingForm.Refresh();
                await Task.Run(() =>
                {
                    int step = 0;
                    int totalSteps = 8;

                    void UpdateProgress(string message)
                    {
                        int percent = (int)((++step / (float)totalSteps) * 100);
                        loadingForm.SetProgress(percent, message);
                    }

                    Console.WriteByte(0x82FFA04F, 0x03);
                    Console.WriteByte(0x82FFA1F7, 0x03);
                    Console.WriteByte(0x82FFA61B, 0x03);
                    Console.WriteByte(0x82FFA39F, 0x03);
                    Console.WriteByte(0x82FFA7C3, 0x03);
                    Console.WriteByte(0x82FFA2CB, 0x03);
                    Console.WriteByte(0x82FFA6EF, 0x03);
                    Console.WriteByte(0x82FFA473, 0x03);
                    UpdateProgress("Writing Ember...");
                    Console.WriteByte(Console.ReadUInt32(0x82FFA054), Ember);
                    UpdateProgress("Writing Reveal...");
                    Console.WriteByte(Console.ReadUInt32(0x82FFA1FC), Reveal);
                    UpdateProgress("Writing MtlReveal...");
                    Console.WriteByte(Console.ReadUInt32(0x82FFA620), MtlReveal);
                    UpdateProgress("Writing Col...");
                    Console.WriteByte(Console.ReadUInt32(0x82FFA3A4), Col);
                    UpdateProgress("Writing AltCol...");
                    Console.WriteByte(Console.ReadUInt32(0x82FFA7C8), AltCol);
                    UpdateProgress("Writing Rgb...");
                    Console.WriteByte(Console.ReadUInt32(0x82FFA2D0), Rgb);
                    UpdateProgress("Writing AltRgb...");
                    Console.WriteByte(Console.ReadUInt32(0x82FFA6F4), AltRgb);
                    UpdateProgress("Writing Heat...");
                    Console.WriteByte(Console.ReadUInt32(0x82FFA478), Heat);
                });
                loadingForm.Close();
            }
            Console.XNotify($"xbIzzys BO2 Camo Tool | {CamoName} Camo Done!");
        }

        public bool EnsureConnected()
        {
            if (!Connected || Console == null)
            {
                MessageBox.Show("Connect to console first!", "xbIzzys BO2 Camo Tool");
                return false;
            }
            return true;
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
    }
}
