using System.Diagnostics;
using System.Windows.Media;
using Color = System.Drawing.Color;
using System.IO;
namespace ProcessMemoryMonitor
{
    public partial class ProcessMemoryMonitor : Form
    {
        private void ClearShaderCache(string path)
        {
            if (!Directory.Exists(path))
            {
                lblStatus.Text = "Shader folder not found";
                return;
            }

            if (!path.Contains("shaders"))
            {
                lblStatus.Text = "Path does not look like a shaders folder";
                MessageBox.Show("Path does not look like a shaders folder");
                return;
            }

            try
            {
                Directory.Delete(path, true);
                lblStatus.Text = "Shader cache cleared";
                MessageBox.Show("Shader cache cleared.");
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Could not clear cache: {ex.Message}";
            }
        }
        private bool processWasRunning = false;
        private bool alertShown = false;
        private MediaPlayer alertPlayer = new MediaPlayer();
        public ProcessMemoryMonitor()
        {
            InitializeComponent();

            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "WarningMemory.wav");
                alertPlayer.Open(new Uri(path));
            }
            catch
            {

            }

            txtShaderPath.Text = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "AAClassic", "USER", "shaders");
        }
        private void LoadProcesses()
        {
            cmbProcesses.Items.Clear();
            cmbProcesses.SelectedIndex = -1;


            btnStartStop.ForeColor = Color.FromArgb(110, 110, 106);
            btnStartStop.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);

            lblMemory.Text = "0";
            pnlBarFill.Width = 0;
            lblStatus.Text = "Stopped";

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
            if (timerRefresh.Enabled)
            {
                return;
            }
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
                lblStatus.Text = "Process not found";

                if (processWasRunning)
                {
                    processWasRunning = false;
                    
                    if (chkClearShaders.Checked)
                    {
                        ClearShaderCache(txtShaderPath.Text);
                    }
                }

                return;
            }

            processWasRunning = true;

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

            int threshold = 3600;

            if (int.TryParse(txtThreshold.Text, out int parsed))
            {
                threshold = parsed;
            }

            if (mb >= threshold)
            {
                pnlBarFill.BackColor = Color.FromArgb(232, 93, 93);
            }
            else if (mb >= threshold * 0.9)
            {
                pnlBarFill.BackColor = Color.FromArgb(239, 159, 39);
            }
            else
            {
                pnlBarFill.BackColor = Color.FromArgb(74, 158, 255);
            }

            if (mb >= threshold && !alertShown)
            {
                alertShown = true;
                alertPlayer.Position = TimeSpan.Zero;
                alertPlayer.Play();
                notifyIcon.ShowBalloonTip(5000, "Memory alert", "Threshold exceeded, ArcheAge will collapse soon!", ToolTipIcon.Warning);
            }
            else if (mb < threshold)
            {
                alertShown = false;
            }

            lblStatus.Text = "Monitoring";
        }

        private void cmbProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMemory();
            btnStartStop.Enabled = true;
            btnStartStop.ForeColor = Color.FromArgb(232, 232, 230);
            btnStartStop.FlatAppearance.BorderColor = Color.FromArgb(74, 158, 255);
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            UpdateMemory();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (cmbProcesses.SelectedIndex == -1)
            {
                return;
            }
            if (timerRefresh.Enabled)
            {
                btnStartStop.Text = "Start Monitoring";
                btnStartStop.FlatAppearance.BorderColor = Color.FromArgb(74, 158, 255);
                timerRefresh.Enabled = false;
                pnlStatusDot.BackColor = Color.FromArgb(110, 110, 106);
                lblStatus.Text = "Stopped";
                btnRefresh.ForeColor = Color.FromArgb(232, 232, 230);
                btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(74, 158, 255);
                txtThreshold.ReadOnly = false;
                txtThreshold.BackColor = Color.FromArgb(45, 45, 48);
                txtThreshold.ForeColor = Color.FromArgb(232, 232, 230);
                btnBrowse.ForeColor = Color.FromArgb(232, 232, 230);
                btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(74, 158, 255);
                chkClearShaders.Enabled = true;
                txtShaderPath.ReadOnly = false;
                txtShaderPath.BackColor = Color.FromArgb(45, 45, 48);
                txtShaderPath.ForeColor = Color.FromArgb(232, 232, 230);
            }
            else
            {
                btnStartStop.Text = "Stop Monitoring";
                btnStartStop.FlatAppearance.BorderColor = Color.FromArgb(232, 93, 93);
                timerRefresh.Enabled = true;
                pnlStatusDot.BackColor = Color.FromArgb(99, 153, 34);
                btnRefresh.ForeColor = Color.FromArgb(110, 110, 106);
                btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
                txtThreshold.ReadOnly = true;
                txtThreshold.BackColor = Color.FromArgb(38, 38, 40);
                txtThreshold.ForeColor = Color.FromArgb(110, 110, 106);
                btnBrowse.ForeColor = Color.FromArgb(110, 110, 106);
                btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 70);
                txtShaderPath.ReadOnly = true;
                chkClearShaders.Enabled = false;
                txtShaderPath.BackColor = Color.FromArgb(38, 38, 40);
                txtShaderPath.ForeColor = Color.FromArgb(110, 110, 106);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (timerRefresh.Enabled)
            {
                return;
            }

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = txtShaderPath.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtShaderPath.Text = dialog.SelectedPath;
            }
            
        }
    }
}
