using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace xbIzzys_BO2_Camo_Tool
{
    public static class VersionCheck
    {
        private const string CurrVersion = "1.1";
        private const string Version = "https://raw.githubusercontent.com/xbIzzy/xbIzzys-BO2-Camo-Tool/refs/heads/main/Version.txt";

        public static async Task CheckVersionAsync(Label label)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string latestVersion = await client.GetStringAsync(Version);
                    latestVersion = latestVersion.Trim();

                    if (latestVersion == CurrVersion)
                    {
                        label.Text = "Version: Updated";
                        label.ForeColor = Color.Lime;
                    }
                    else
                    {
                        label.Text = "Version: Outdated";
                        label.ForeColor = Color.DarkOrange;
                    }
                }
            }
            catch (Exception e)
            {
                label.Text = "Version: Failed";
                label.ForeColor = Color.Red;
            }
        }
    }
}
