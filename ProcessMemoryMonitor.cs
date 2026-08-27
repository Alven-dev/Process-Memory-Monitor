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
                cmbProcesses.Items.Add(p.ProcessName);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }
    }
}
