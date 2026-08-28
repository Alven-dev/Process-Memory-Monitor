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
