using JRPC_Client;
using System;
using System.Drawing;
using System.Windows.Forms;
using XDevkit;

namespace xbIzzys_BO2_Camo_Tool
{
    public partial class Main : Form
    {
        Point lastPoint;
        IXboxConsole Console;

        public Main()
        {
            InitializeComponent();
        }

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
                lblStatus.Text = "Status: Connected";
                Console.XNotify("xbIzzys BO2 Camo Tool | Connected");
                MessageBox.Show("Dont move around when injecting!", "xbIzzys BO2 Camo Tool");
            }
            else
            {
                lblStatus.Text = "Status: Failed";
            }
        }

        private void cbPreviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CurPreview = cbPreviews.Text;
            switch (CurPreview)
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
            }
        }

        private void btnInjectAkatsuki_Click(object sender, EventArgs e)
        {
            Console.WriteByte(0x82FF9B57, 0x03);
            Console.WriteByte(0x82FF9CFF, 0x03);
            Console.WriteByte(0x82FF9DD3, 0x03);
            Console.WriteByte(0x82FF9EA7, 0x03);
            Console.WriteByte(0x82FF9F7B, 0x03);
            Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Properties.Resources.AkatsukiGlow);
            Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Properties.Resources.AkatsukiReveal);
            Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Properties.Resources.AkatsukiRgb);
            Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Properties.Resources.AkatsukiCol);
            Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Properties.Resources.AkatsukiHeat);
            Console.XNotify("xbIzzys BO2 Camo Tool | Akatsuki Camo Done!");
        }

        private void btnInjectBubblegum_Click(object sender, EventArgs e)
        {
            Console.WriteByte(0x82FF9B57, 0x03);
            Console.WriteByte(0x82FF9CFF, 0x03);
            Console.WriteByte(0x82FF9DD3, 0x03);
            Console.WriteByte(0x82FF9EA7, 0x03);
            Console.WriteByte(0x82FF9F7B, 0x03);
            Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Properties.Resources.BubblegumGlow);
            Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Properties.Resources.BubblegumReveal);
            Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Properties.Resources.BubblegumRgb);
            Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Properties.Resources.BubblegumCol);
            Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Properties.Resources.BubblegumHeat);
            Console.XNotify("xbIzzys BO2 Camo Tool | Bubblegum Camo Done!");
        }

        private void btnInjectxbIzzys_Click(object sender, EventArgs e)
        {
            Console.WriteByte(0x82FF9B57, 0x03);
            Console.WriteByte(0x82FF9CFF, 0x03);
            Console.WriteByte(0x82FF9DD3, 0x03);
            Console.WriteByte(0x82FF9EA7, 0x03);
            Console.WriteByte(0x82FF9F7B, 0x03);
            Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Properties.Resources.xbIzzyGlow);
            Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Properties.Resources.xbIzzyReveal);
            Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Properties.Resources.xbIzzyRgb);
            Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Properties.Resources.xbIzzyCol);
            Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Properties.Resources.xbIzzyHeat);
            Console.XNotify("xbIzzys BO2 Camo Tool | xbIzzys Camo Done!");
        }

        private void btnInjectDarkMatter_Click(object sender, EventArgs e)
        {
            Console.WriteByte(0x82FF9B57, 0x03);
            Console.WriteByte(0x82FF9CFF, 0x03);
            Console.WriteByte(0x82FF9DD3, 0x03);
            Console.WriteByte(0x82FF9EA7, 0x03);
            Console.WriteByte(0x82FF9F7B, 0x03);
            Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Properties.Resources.DarkMatterGlow);
            Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Properties.Resources.DarkMatterReveal);
            Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Properties.Resources.DarkMatterRgb);
            Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Properties.Resources.DarkMatterCol);
            Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Properties.Resources.DarkMatterHeat);
            Console.XNotify("xbIzzys BO2 Camo Tool | Dark Matter Camo Done!");
        }

        private void btnInjectLetItRip_Click(object sender, EventArgs e)
        {
            Console.WriteByte(0x82FF9B57, 0x03);
            Console.WriteByte(0x82FF9CFF, 0x03);
            Console.WriteByte(0x82FF9DD3, 0x03);
            Console.WriteByte(0x82FF9EA7, 0x03);
            Console.WriteByte(0x82FF9F7B, 0x03);
            Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Properties.Resources.letItRipGlow);
            Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Properties.Resources.letItRipReveal);
            Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Properties.Resources.letItRipRgb);
            Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Properties.Resources.letItRipCol);
            Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Properties.Resources.letItRipHeat);
            Console.XNotify("xbIzzys BO2 Camo Tool | let It Rip Camo Done!");
        }

        private void btnInjectManipulation_Click(object sender, EventArgs e)
        {
            Console.WriteByte(0x82FF9B57, 0x03);
            Console.WriteByte(0x82FF9CFF, 0x03);
            Console.WriteByte(0x82FF9DD3, 0x03);
            Console.WriteByte(0x82FF9EA7, 0x03);
            Console.WriteByte(0x82FF9F7B, 0x03);
            Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Properties.Resources.ManipulationGlow);
            Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Properties.Resources.ManipulationReveal);
            Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Properties.Resources.ManipulationRgb);
            Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Properties.Resources.ManipulationCol);
            Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Properties.Resources.ManipulationHeat);
            Console.XNotify("xbIzzys BO2 Camo Tool | Manipulation Camo Done!");
        }

        private void btnInjectRickandMorty_Click(object sender, EventArgs e)
        {
            Console.WriteByte(0x82FF9B57, 0x03);
            Console.WriteByte(0x82FF9CFF, 0x03);
            Console.WriteByte(0x82FF9DD3, 0x03);
            Console.WriteByte(0x82FF9EA7, 0x03);
            Console.WriteByte(0x82FF9F7B, 0x03);
            Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Properties.Resources.RickAndMortyGlow);
            Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Properties.Resources.RickAndMortyReveal);
            Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Properties.Resources.RickAndMortyRgb);
            Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Properties.Resources.RickAndMortyCol);
            Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Properties.Resources.RickAndMortyHeat);
            Console.XNotify("xbIzzys BO2 Camo Tool | Rick and Morty Camo Done!");
        }

        private void btnInjectInterstellar_Click(object sender, EventArgs e)
        {
            Console.WriteByte(0x82FF9B57, 0x03);
            Console.WriteByte(0x82FF9CFF, 0x03);
            Console.WriteByte(0x82FF9DD3, 0x03);
            Console.WriteByte(0x82FF9EA7, 0x03);
            Console.WriteByte(0x82FF9F7B, 0x03);
            Console.WriteByte(Console.ReadUInt32(0x82FF9B5C), Properties.Resources.InterstellarGlow);
            Console.WriteByte(Console.ReadUInt32(0x82FF9D04), Properties.Resources.InterstellarReveal);
            Console.WriteByte(Console.ReadUInt32(0x82FF9DD8), Properties.Resources.InterstellarRgb);
            Console.WriteByte(Console.ReadUInt32(0x82FF9EAC), Properties.Resources.InterstellarCol);
            Console.WriteByte(Console.ReadUInt32(0x82FF9F80), Properties.Resources.InterstellarHeat);
            Console.XNotify("xbIzzys BO2 Camo Tool | Interstellar Camo Done!");
        }
    }
}
