namespace ProcessMemoryMonitor
{
    partial class ProcessMemoryMonitor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cmbProcesses = new ComboBox();
            btnRefresh = new Button();
            lblProcess = new Label();
            lblBar = new Label();
            lblMemUsg = new Label();
            lblMemory = new Label();
            lblMb = new Label();
            label1 = new Label();
            label2 = new Label();
            timerRefresh = new System.Windows.Forms.Timer(components);
            lblStart = new Label();
            label3 = new Label();
            txtThreshold = new Label();
            textBox1 = new TextBox();
            lblInfoMb = new Label();
            button1 = new Button();
            pnlBarBg = new Panel();
            pnlBarFill = new Panel();
            lblStatus = new Label();
            pnlStatusDot = new Panel();
            pnlBarBg.SuspendLayout();
            SuspendLayout();
            // 
            // cmbProcesses
            // 
            cmbProcesses.BackColor = Color.FromArgb(45, 45, 48);
            cmbProcesses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProcesses.ForeColor = Color.FromArgb(232, 232, 230);
            cmbProcesses.FormattingEnabled = true;
            cmbProcesses.Location = new Point(22, 59);
            cmbProcesses.Name = "cmbProcesses";
            cmbProcesses.Size = new Size(310, 23);
            cmbProcesses.Sorted = true;
            cmbProcesses.TabIndex = 0;
            cmbProcesses.SelectedIndexChanged += cmbProcesses_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(45, 45, 48);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FromArgb(232, 230, 230);
            btnRefresh.Location = new Point(338, 59);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(96, 23);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh List";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblProcess
            // 
            lblProcess.AutoSize = true;
            lblProcess.ForeColor = Color.FromArgb(160, 160, 156);
            lblProcess.Location = new Point(22, 41);
            lblProcess.Name = "lblProcess";
            lblProcess.Size = new Size(47, 15);
            lblProcess.TabIndex = 2;
            lblProcess.Text = "Process";
            // 
            // lblBar
            // 
            lblBar.BackColor = Color.FromArgb(63, 63, 70);
            lblBar.ForeColor = Color.White;
            lblBar.Location = new Point(22, 100);
            lblBar.Name = "lblBar";
            lblBar.Size = new Size(410, 2);
            lblBar.TabIndex = 3;
            // 
            // lblMemUsg
            // 
            lblMemUsg.AutoSize = true;
            lblMemUsg.ForeColor = Color.FromArgb(160, 160, 156);
            lblMemUsg.Location = new Point(22, 122);
            lblMemUsg.Name = "lblMemUsg";
            lblMemUsg.Size = new Size(87, 15);
            lblMemUsg.TabIndex = 4;
            lblMemUsg.Text = "Memory Usage";
            // 
            // lblMemory
            // 
            lblMemory.AutoSize = true;
            lblMemory.Font = new Font("Consolas", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMemory.ForeColor = Color.FromArgb(232, 232, 230);
            lblMemory.Location = new Point(22, 150);
            lblMemory.Name = "lblMemory";
            lblMemory.Size = new Size(151, 41);
            lblMemory.TabIndex = 5;
            lblMemory.Text = "123test";
            // 
            // lblMb
            // 
            lblMb.AutoSize = true;
            lblMb.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMb.ForeColor = Color.FromArgb(232, 232, 230);
            lblMb.Location = new Point(168, 165);
            lblMb.Name = "lblMb";
            lblMb.Size = new Size(30, 22);
            lblMb.TabIndex = 6;
            lblMb.Text = "MB";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(63, 63, 70);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 270);
            label1.Name = "label1";
            label1.Size = new Size(410, 2);
            label1.TabIndex = 7;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(63, 63, 70);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 347);
            label2.Name = "label2";
            label2.Size = new Size(410, 2);
            label2.TabIndex = 8;
            // 
            // timerRefresh
            // 
            timerRefresh.Interval = 1000;
            timerRefresh.Tick += timerRefresh_Tick;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Consolas", 8.25F, FontStyle.Bold);
            lblStart.ForeColor = Color.FromArgb(160, 160, 156);
            lblStart.Location = new Point(22, 216);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(13, 13);
            lblStart.TabIndex = 10;
            lblStart.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 8.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(160, 160, 156);
            label3.Location = new Point(349, 216);
            label3.Name = "label3";
            label3.Size = new Size(85, 13);
            label3.TabIndex = 11;
            label3.Text = "2800 MB limit";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtThreshold
            // 
            txtThreshold.AutoSize = true;
            txtThreshold.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtThreshold.ForeColor = Color.FromArgb(160, 160, 156);
            txtThreshold.Location = new Point(22, 296);
            txtThreshold.Name = "txtThreshold";
            txtThreshold.Size = new Size(97, 13);
            txtThreshold.TabIndex = 12;
            txtThreshold.Text = "Alert threshold";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(45, 45, 48);
            textBox1.ForeColor = Color.FromArgb(232, 232, 230);
            textBox1.Location = new Point(22, 312);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // lblInfoMb
            // 
            lblInfoMb.AutoSize = true;
            lblInfoMb.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoMb.ForeColor = Color.FromArgb(160, 160, 156);
            lblInfoMb.Location = new Point(128, 315);
            lblInfoMb.Name = "lblInfoMb";
            lblInfoMb.Size = new Size(21, 15);
            lblInfoMb.TabIndex = 14;
            lblInfoMb.Text = "MB";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 45, 48);
            button1.FlatAppearance.BorderColor = Color.FromArgb(74, 158, 255);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(232, 230, 230);
            button1.Location = new Point(305, 296);
            button1.Name = "button1";
            button1.Size = new Size(127, 34);
            button1.TabIndex = 15;
            button1.Text = "Start Monitoring";
            button1.UseVisualStyleBackColor = false;
            // 
            // pnlBarBg
            // 
            pnlBarBg.BackColor = Color.FromArgb(45, 45, 48);
            pnlBarBg.Controls.Add(pnlBarFill);
            pnlBarBg.Location = new Point(22, 194);
            pnlBarBg.Name = "pnlBarBg";
            pnlBarBg.Size = new Size(410, 12);
            pnlBarBg.TabIndex = 16;
            // 
            // pnlBarFill
            // 
            pnlBarFill.BackColor = Color.FromArgb(99, 153, 34);
            pnlBarFill.Location = new Point(0, 2);
            pnlBarFill.Name = "pnlBarFill";
            pnlBarFill.Size = new Size(100, 8);
            pnlBarFill.TabIndex = 17;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.FromArgb(160, 160, 156);
            lblStatus.Location = new Point(39, 357);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(159, 15);
            lblStatus.TabIndex = 17;
            lblStatus.Text = "Monitoring - updated 1s ago";
            // 
            // pnlStatusDot
            // 
            pnlStatusDot.Location = new Point(27, 361);
            pnlStatusDot.Name = "pnlStatusDot";
            pnlStatusDot.Size = new Size(8, 8);
            pnlStatusDot.TabIndex = 18;
            // 
            // ProcessMemoryMonitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(464, 381);
            Controls.Add(pnlStatusDot);
            Controls.Add(lblStatus);
            Controls.Add(pnlBarBg);
            Controls.Add(button1);
            Controls.Add(lblInfoMb);
            Controls.Add(textBox1);
            Controls.Add(txtThreshold);
            Controls.Add(label3);
            Controls.Add(lblStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMb);
            Controls.Add(lblMemory);
            Controls.Add(lblMemUsg);
            Controls.Add(lblBar);
            Controls.Add(lblProcess);
            Controls.Add(btnRefresh);
            Controls.Add(cmbProcesses);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProcessMemoryMonitor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Process Memory Monitor";
            pnlBarBg.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProcesses;
        private Button btnRefresh;
        private Label lblProcess;
        private Label lblBar;
        private Label lblMemUsg;
        private Label lblMemory;
        private Label lblMb;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timerRefresh;
        private Label lblStart;
        private Label label3;
        private Label txtThreshold;
        private TextBox textBox1;
        private Label lblInfoMb;
        private Button button1;
        private Panel pnlBarBg;
        private Panel pnlBarFill;
        private Label lblStatus;
        private Panel pnlStatusDot;
    }
}
