using System.Diagnostics;
namespace ProcessMemoryMonitor
{
    public partial class ProcessMemoryMonitor : Form
    {
        public ProcessMemoryMonitor()
        {
            InitializeComponent();
        }
        private void LoadProcesses()
        {
            cmbProcesses.Items.Clear();

            Process[] processes = Process.GetProcesses();

            foreach (Process p in processes)
            {
                if (p.MainWindowHandle == IntPtr.Zero)
                {
                    continue;
                }

                if (!cmbProcesses.Items.Contains(p.ProcessName))
                {
                    cmbProcesses.Items.Add(p.ProcessName);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }


        private void UpdateMemory()
        {

            if (cmbProcesses.SelectedIndex == -1)
            {
                return;
            }

            string name = cmbProcesses.SelectedItem.ToString();

            Process[] found = Process.GetProcessesByName(name);
            if (found.Length == 0)
            {
                lblMemory.Text = "-";
                return;
            }

            long bytes = found[0].WorkingSet64;
            long mb = bytes / (1024 * 1024);
            lblMemory.Text = mb.ToString();

            int limit = 4096;
            double percent = (double)mb / limit;
            int fillWidth = (int)(percent * pnlBarBg.Width);

            if (fillWidth > pnlBarBg.Width)
            {
                fillWidth = pnlBarBg.Width;
            }
            pnlBarFill.Width = fillWidth;


            if (percent < 0.6)
            {
                pnlBarFill.BackColor = Color.FromArgb(74, 158, 255);
            }
            else if (percent < 0.85)
            {
                pnlBarFill.BackColor = Color.FromArgb(239, 159, 39);
            }
            else
            {
                pnlBarFill.BackColor = Color.FromArgb(232, 93, 93);
            }
        }

        private void cmbProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMemory();
            timerRefresh.Enabled = true;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            UpdateMemory();
        }
    }
}
