namespace Network_Host_Console
{
    partial class List_Scan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Scan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mtxt_Hostnames = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_DateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_scanstat = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_MainGrid = new System.Windows.Forms.DataGridView();
            this.clm_Hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_MacAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_OSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_IPV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_IPV6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Shutdown = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btnCMD = new System.Windows.Forms.Button();
            this.btnRDP = new System.Windows.Forms.Button();
            this.btn_Files = new System.Windows.Forms.Button();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.ctm_dgOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fIlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInstalledAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanPerformanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Lines = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_MainGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.ctm_dgOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 31);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scan Hostnames";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(805, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(853, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mtxt_Hostnames);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 452);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hostnames";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Scan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtxt_Hostnames
            // 
            this.mtxt_Hostnames.Location = new System.Drawing.Point(7, 19);
            this.mtxt_Hostnames.Multiline = true;
            this.mtxt_Hostnames.Name = "mtxt_Hostnames";
            this.mtxt_Hostnames.Size = new System.Drawing.Size(167, 386);
            this.mtxt_Hostnames.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_DateTime,
            this.toolStripProgressBar1,
            this.lbl_scanstat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(903, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(22, 17);
            this.lbl_DateTime.Text = "---";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // lbl_scanstat
            // 
            this.lbl_scanstat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_scanstat.Name = "lbl_scanstat";
            this.lbl_scanstat.Size = new System.Drawing.Size(22, 17);
            this.lbl_scanstat.Text = "---";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_MainGrid);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(232, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 452);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result(s)";
            // 
            // dg_MainGrid
            // 
            this.dg_MainGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Hostname,
            this.clm_MacAddress,
            this.clm_OSName,
            this.clm_IPV4,
            this.clm_IPV6,
            this.clm_Status});
            this.dg_MainGrid.Location = new System.Drawing.Point(7, 23);
            this.dg_MainGrid.Name = "dg_MainGrid";
            this.dg_MainGrid.Size = new System.Drawing.Size(636, 382);
            this.dg_MainGrid.TabIndex = 1;
            // 
            // clm_Hostname
            // 
            this.clm_Hostname.HeaderText = "Hostnames";
            this.clm_Hostname.Name = "clm_Hostname";
            // 
            // clm_MacAddress
            // 
            this.clm_MacAddress.HeaderText = "MacAddress";
            this.clm_MacAddress.Name = "clm_MacAddress";
            // 
            // clm_OSName
            // 
            this.clm_OSName.HeaderText = "OSName";
            this.clm_OSName.Name = "clm_OSName";
            // 
            // clm_IPV4
            // 
            this.clm_IPV4.HeaderText = "IP Address(V4)";
            this.clm_IPV4.Name = "clm_IPV4";
            // 
            // clm_IPV6
            // 
            this.clm_IPV6.HeaderText = "IP Address (V6)";
            this.clm_IPV6.Name = "clm_IPV6";
            // 
            // clm_Status
            // 
            this.clm_Status.HeaderText = "Status";
            this.clm_Status.Name = "clm_Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Shutdown);
            this.panel2.Controls.Add(this.btn_Restart);
            this.panel2.Controls.Add(this.btnCMD);
            this.panel2.Controls.Add(this.btnRDP);
            this.panel2.Controls.Add(this.btn_Files);
            this.panel2.Controls.Add(this.btnPrograms);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Location = new System.Drawing.Point(7, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 35);
            this.panel2.TabIndex = 0;
            // 
            // btn_Shutdown
            // 
            this.btn_Shutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Shutdown.FlatAppearance.BorderSize = 0;
            this.btn_Shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shutdown.Image = ((System.Drawing.Image)(resources.GetObject("btn_Shutdown.Image")));
            this.btn_Shutdown.Location = new System.Drawing.Point(571, 0);
            this.btn_Shutdown.Name = "btn_Shutdown";
            this.btn_Shutdown.Size = new System.Drawing.Size(54, 30);
            this.btn_Shutdown.TabIndex = 0;
            this.btn_Shutdown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Shutdown.UseVisualStyleBackColor = true;
            // 
            // btn_Restart
            // 
            this.btn_Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restart.FlatAppearance.BorderSize = 0;
            this.btn_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restart.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restart.Image")));
            this.btn_Restart.Location = new System.Drawing.Point(520, 0);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(54, 30);
            this.btn_Restart.TabIndex = 0;
            this.btn_Restart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Restart.UseVisualStyleBackColor = true;
            // 
            // btnCMD
            // 
            this.btnCMD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCMD.FlatAppearance.BorderSize = 0;
            this.btnCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCMD.Image = ((System.Drawing.Image)(resources.GetObject("btnCMD.Image")));
            this.btnCMD.Location = new System.Drawing.Point(244, 1);
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.Size = new System.Drawing.Size(54, 30);
            this.btnCMD.TabIndex = 0;
            this.btnCMD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCMD.UseVisualStyleBackColor = true;
            this.btnCMD.Click += new System.EventHandler(this.btnCMD_Click_1);
            // 
            // btnRDP
            // 
            this.btnRDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRDP.FlatAppearance.BorderSize = 0;
            this.btnRDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRDP.Image = ((System.Drawing.Image)(resources.GetObject("btnRDP.Image")));
            this.btnRDP.Location = new System.Drawing.Point(184, 1);
            this.btnRDP.Name = "btnRDP";
            this.btnRDP.Size = new System.Drawing.Size(54, 30);
            this.btnRDP.TabIndex = 0;
            this.btnRDP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRDP.UseVisualStyleBackColor = true;
            this.btnRDP.Click += new System.EventHandler(this.btnRDP_Click_1);
            // 
            // btn_Files
            // 
            this.btn_Files.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Files.FlatAppearance.BorderSize = 0;
            this.btn_Files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Files.Image = ((System.Drawing.Image)(resources.GetObject("btn_Files.Image")));
            this.btn_Files.Location = new System.Drawing.Point(125, 1);
            this.btn_Files.Name = "btn_Files";
            this.btn_Files.Size = new System.Drawing.Size(54, 30);
            this.btn_Files.TabIndex = 0;
            this.btn_Files.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Files.UseVisualStyleBackColor = true;
            this.btn_Files.Click += new System.EventHandler(this.btn_Files_Click_1);
            // 
            // btnPrograms
            // 
            this.btnPrograms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrograms.FlatAppearance.BorderSize = 0;
            this.btnPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrograms.Image = ((System.Drawing.Image)(resources.GetObject("btnPrograms.Image")));
            this.btnPrograms.Location = new System.Drawing.Point(64, 1);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(54, 30);
            this.btnPrograms.TabIndex = 0;
            this.btnPrograms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrograms.UseVisualStyleBackColor = true;
            this.btnPrograms.Click += new System.EventHandler(this.btnPrograms_Click_1);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(4, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(54, 30);
            this.btnExport.TabIndex = 0;
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // ctm_dgOptions
            // 
            this.ctm_dgOptions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctm_dgOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIlesToolStripMenuItem,
            this.viewInstalledAppsToolStripMenuItem,
            this.scanPerformanceToolStripMenuItem,
            this.cMDToolStripMenuItem,
            this.rDPToolStripMenuItem,
            this.bootToolStripMenuItem});
            this.ctm_dgOptions.Name = "ctm_dgOptions";
            this.ctm_dgOptions.Size = new System.Drawing.Size(198, 136);
            // 
            // fIlesToolStripMenuItem
            // 
            this.fIlesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fIlesToolStripMenuItem.Image")));
            this.fIlesToolStripMenuItem.Name = "fIlesToolStripMenuItem";
            this.fIlesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.fIlesToolStripMenuItem.Text = "Access Files";
            this.fIlesToolStripMenuItem.Click += new System.EventHandler(this.fIlesToolStripMenuItem_Click_1);
            // 
            // viewInstalledAppsToolStripMenuItem
            // 
            this.viewInstalledAppsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewInstalledAppsToolStripMenuItem.Image")));
            this.viewInstalledAppsToolStripMenuItem.Name = "viewInstalledAppsToolStripMenuItem";
            this.viewInstalledAppsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.viewInstalledAppsToolStripMenuItem.Text = "View Installed Programs";
            this.viewInstalledAppsToolStripMenuItem.Click += new System.EventHandler(this.viewInstalledAppsToolStripMenuItem_Click_1);
            // 
            // scanPerformanceToolStripMenuItem
            // 
            this.scanPerformanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scanPerformanceToolStripMenuItem.Image")));
            this.scanPerformanceToolStripMenuItem.Name = "scanPerformanceToolStripMenuItem";
            this.scanPerformanceToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.scanPerformanceToolStripMenuItem.Text = "Performance Scan";
            this.scanPerformanceToolStripMenuItem.Click += new System.EventHandler(this.scanPerformanceToolStripMenuItem_Click_1);
            // 
            // cMDToolStripMenuItem
            // 
            this.cMDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cMDToolStripMenuItem.Image")));
            this.cMDToolStripMenuItem.Name = "cMDToolStripMenuItem";
            this.cMDToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cMDToolStripMenuItem.Text = "Access CMD";
            // 
            // rDPToolStripMenuItem
            // 
            this.rDPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rDPToolStripMenuItem.Image")));
            this.rDPToolStripMenuItem.Name = "rDPToolStripMenuItem";
            this.rDPToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.rDPToolStripMenuItem.Text = "RDP";
            // 
            // bootToolStripMenuItem
            // 
            this.bootToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutdownToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.bootToolStripMenuItem.Name = "bootToolStripMenuItem";
            this.bootToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bootToolStripMenuItem.Text = "Boot";
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shutdownToolStripMenuItem.Image")));
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restartToolStripMenuItem.Image")));
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // txt_Lines
            // 
            this.txt_Lines.AutoSize = true;
            this.txt_Lines.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Lines.Location = new System.Drawing.Point(62, 518);
            this.txt_Lines.Name = "txt_Lines";
            this.txt_Lines.Size = new System.Drawing.Size(16, 13);
            this.txt_Lines.TabIndex = 7;
            this.txt_Lines.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inputs:";
            // 
            // List_Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(903, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Lines);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "List_Scan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Scan";
            this.Load += new System.EventHandler(this.List_Scan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_MainGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ctm_dgOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mtxt_Hostnames;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_DateTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dg_MainGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_MacAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_OSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IPV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IPV6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Status;
        private System.Windows.Forms.ContextMenuStrip ctm_dgOptions;
        private System.Windows.Forms.ToolStripMenuItem fIlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInstalledAppsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanPerformanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Button btn_Shutdown;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btnCMD;
        private System.Windows.Forms.Button btnRDP;
        private System.Windows.Forms.Button btn_Files;
        private System.Windows.Forms.Button btnPrograms;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label txt_Lines;
        private System.Windows.Forms.ToolStripMenuItem cMDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rDPToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_scanstat;
    }
}