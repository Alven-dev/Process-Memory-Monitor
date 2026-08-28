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
            lblMb.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMb.ForeColor = Color.FromArgb(232, 232, 230);
            lblMb.Location = new Point(179, 165);
            lblMb.Name = "lblMb";
            lblMb.Size = new Size(30, 22);
            lblMb.TabIndex = 6;
            lblMb.Text = "MB";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(63, 63, 70);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 278);
            label1.Name = "label1";
            label1.Size = new Size(410, 2);
            label1.TabIndex = 7;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(63, 63, 70);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 445);
            label2.Name = "label2";
            label2.Size = new Size(410, 2);
            label2.TabIndex = 8;
            // 
            // timerRefresh
            // 
            timerRefresh.Interval = 1000;
            timerRefresh.Tick += timerRefresh_Tick;
            // 
            // ProcessMemoryMonitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(464, 481);
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
    }
}
