using System;
using System.Windows.Forms;

namespace xbIzzys_BO2_Camo_Tool
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        public void SetProgress(int value, string status = "")
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SetProgress(value, status)));
            }
            else
            {
                progressBar1.Value = Math.Min(progressBar1.Maximum, value);
                if (!string.IsNullOrEmpty(status))
                    lblLoading.Text = status;
            }
        }
    }
}
