using System;
using XDevkit;
using System.Linq;
using JRPC_Client;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using xbIzzys_BO2_Camo_Tool.Utilities;
using xbIzzys_BO2_Camo_Tool.Utilities.Camos;

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
            WindowState = FormWindowState.Minimized;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (Console.Connect(out Console))
            {
                Connected = true;

                ClassCamos.Console = Console;
                CamoInjector.Console = Console;
                OtherFunctions.Console = Console;

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

        //INJECT CAMOS
        private async void btnInjectCustomCyborgCamo_Click(object sender, EventArgs e)
        {
            var Camo = Camos.CyborgCamos.FirstOrDefault(x => x.Name == cbCyborgCamos.Text);

            if (Camo == null)
            {
                MessageBox.Show("Select a Camo first.");
                return;
            }

            Console.XNotify($"{Camo.Name} Started!");

            await Task.Run(() =>
            {
                CamoInjector.InjectCyborg(Camo);
            });

            Console.XNotify($"{Camo.Name} Injected!");
        }

        private async void btnInjectCustomDragonCamo_Click(object sender, EventArgs e)
        {
            var Camo = Camos.DragonCamos.FirstOrDefault(x => x.Name == cbDragonCamos.Text);

            if (Camo == null)
            {
                MessageBox.Show("Select a Camo first.");
                return;
            }

            Console.XNotify($"{Camo.Name} Started!");

            await Task.Run(() =>
            {
                CamoInjector.InjectDragon(Camo);
            });

            Console.XNotify($"{Camo.Name} Injected!");
        }

        private async void btnInjectCustomW115Camo_Click(object sender, EventArgs e)
        {
            var Camo = Camos.W115Camos.FirstOrDefault(x => x.Name == cbW115Camos.Text);

            if (Camo == null)
            {
                MessageBox.Show("Select a Camo first.");
                return;
            }

            Console.XNotify($"{Camo.Name} Started!");

            await Task.Run(() =>
            {
                CamoInjector.InjectW115(Camo);
            });

            Console.XNotify($"{Camo.Name} Injected!");
        }

        //CUSTOMIZE W115
        private void btnW115Speed_Click(object sender, EventArgs e)
        {
            byte ScrollByte = Convert.ToByte(tbW115Speed.Text, 16);
            OtherFunctions.SetW115Speed(ScrollByte);
        }

        private void btnW115Glow_Click(object sender, EventArgs e)
        {
            byte GlowByte = Convert.ToByte(tbW115Glow.Text, 16);
            OtherFunctions.SetW115Glow(GlowByte);
        }

        //APPLY CAMO TO CLASSES
        private void btnApplyCyborg_Click(object sender, EventArgs e)
        {
            if (!EnsureConnected()) return;
            DialogResult WarnRes = MessageBox.Show("1. Must be in Main Menu\n2. Only Works for Public Match Classes", "xbIzzys BO2 Camo Tool", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (WarnRes == DialogResult.OK)
            {
                ClassCamos.ApplyCyborg();
            }
            else return;
        }

        private void btnApplyDragon_Click(object sender, EventArgs e)
        {
            if (!EnsureConnected()) return;
            DialogResult WarnRes = MessageBox.Show("1. Must be in Main Menu\n2. Only Works for Public Match Classes", "xbIzzys BO2 Camo Tool", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (WarnRes == DialogResult.OK)
            {
                ClassCamos.ApplyDragon();
            }
            else return;
        }

        private void btnApplyW115_Click(object sender, EventArgs e)
        {
            if (!EnsureConnected()) return;
            DialogResult WarnRes = MessageBox.Show("1. Must be in Main Menu\n2. Only Works for Public Match Classes", "xbIzzys BO2 Camo Tool", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (WarnRes == DialogResult.OK)
            {
                ClassCamos.ApplyW115();
            }
            else return;
        }

        //EXTRA SHIT
        private void btnChangelogs_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "(!) Cleaned up code\n" +
                    "(-) Removed loading screen\n" +
                    "(+) Added Custom W115 Camos\n" +
                    "(+) Added Sorex Dragon Camos\n" +
                    "(+) Set Public Classes to W115\n" +
                    "(+) Added W115 Inject, Scroll Speed, and Glow by EFK\n",
                    "xbIzzys BO2 Camo Tool V1.3 Changelog"
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

        //CHANGE PREVIEW IMAGE
        private void cbPreviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Cyborg = Camos.CyborgCamos.FirstOrDefault(x => x.Name == cbPreviews.Text);
            if (Cyborg != null)
            {
                pbPreviews.Image = Cyborg.Preview;
                return;
            }

            var Dragon = Camos.DragonCamos.FirstOrDefault(x => x.Name == cbPreviews.Text);
            if (Dragon != null)
            {
                pbPreviews.Image = Dragon.Preview;
            }

            var W115 = Camos.W115Camos.FirstOrDefault(x => x.Name == cbPreviews.Text);
            if (W115 != null)
            {
                pbPreviews.Image = W115.Preview;
            }
        }

        //CHECK CONNECTED
        public bool EnsureConnected()
        {
            if (!Connected || Console == null)
            {
                MessageBox.Show("Connect to console first!", "xbIzzys BO2 Camo Tool");
                return false;
            }
            return true;
        }

        //MAKES FORM MOVEABLE
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
