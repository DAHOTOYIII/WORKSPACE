namespace Network_Host_Console
{
    partial class Device_Health_Meter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Device_Health_Meter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.lblHostname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grp_PerfromanceCounter = new System.Windows.Forms.GroupBox();
            this.lbl_memory = new System.Windows.Forms.Label();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new CircularProgressBar.CircularProgressBar();
            this.progressBar1 = new CircularProgressBar.CircularProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_available = new System.Windows.Forms.Label();
            this.lbl_used = new System.Windows.Forms.Label();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.barAvailable = new CircularProgressBar.CircularProgressBar();
            this.barUsed = new CircularProgressBar.CircularProgressBar();
            this.barTotal = new CircularProgressBar.CircularProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_ViewTree = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grp_PerfromanceCounter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Controls.Add(this.lblHostname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 31);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_minimize.Location = new System.Drawing.Point(566, -2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(50, 33);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHostname.Location = new System.Drawing.Point(143, 8);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(23, 17);
            this.lblHostname.TabIndex = 1;
            this.lblHostname.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device Health Meter:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(611, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_PerfromanceCounter
            // 
            this.grp_PerfromanceCounter.Controls.Add(this.lbl_memory);
            this.grp_PerfromanceCounter.Controls.Add(this.lbl_cpu);
            this.grp_PerfromanceCounter.Controls.Add(this.label4);
            this.grp_PerfromanceCounter.Controls.Add(this.label3);
            this.grp_PerfromanceCounter.Controls.Add(this.progressBar2);
            this.grp_PerfromanceCounter.Controls.Add(this.progressBar1);
            this.grp_PerfromanceCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_PerfromanceCounter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grp_PerfromanceCounter.Location = new System.Drawing.Point(12, 54);
            this.grp_PerfromanceCounter.Name = "grp_PerfromanceCounter";
            this.grp_PerfromanceCounter.Size = new System.Drawing.Size(244, 190);
            this.grp_PerfromanceCounter.TabIndex = 2;
            this.grp_PerfromanceCounter.TabStop = false;
            this.grp_PerfromanceCounter.Text = "Performance Meter";
            // 
            // lbl_memory
            // 
            this.lbl_memory.AutoSize = true;
            this.lbl_memory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_memory.Location = new System.Drawing.Point(118, 52);
            this.lbl_memory.Name = "lbl_memory";
            this.lbl_memory.Size = new System.Drawing.Size(15, 13);
            this.lbl_memory.TabIndex = 3;
            this.lbl_memory.Text = "--";
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.AutoSize = true;
            this.lbl_cpu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_cpu.Location = new System.Drawing.Point(119, 27);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(15, 13);
            this.lbl_cpu.TabIndex = 3;
            this.lbl_cpu.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(26, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Memory Usage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPU Usage:";
            // 
            // progressBar2
            // 
            this.progressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar2.AnimationSpeed = 500;
            this.progressBar2.BackColor = System.Drawing.Color.Transparent;
            this.progressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.progressBar2.InnerMargin = 2;
            this.progressBar2.InnerWidth = -1;
            this.progressBar2.Location = new System.Drawing.Point(122, 76);
            this.progressBar2.MarqueeAnimationSpeed = 2000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.OuterColor = System.Drawing.Color.Gray;
            this.progressBar2.OuterMargin = -25;
            this.progressBar2.OuterWidth = 26;
            this.progressBar2.ProgressColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar2.ProgressWidth = 18;
            this.progressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar2.Size = new System.Drawing.Size(101, 93);
            this.progressBar2.StartAngle = 270;
            this.progressBar2.Step = 1;
            this.progressBar2.SubscriptColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar2.SubscriptMargin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.progressBar2.SubscriptText = "--";
            this.progressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar2.SuperscriptText = "";
            this.progressBar2.TabIndex = 0;
            this.progressBar2.Text = "Memory";
            this.progressBar2.TextMargin = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.progressBar2.Value = 80;
            // 
            // progressBar1
            // 
            this.progressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar1.AnimationSpeed = 500;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.progressBar1.InnerMargin = 2;
            this.progressBar1.InnerWidth = -1;
            this.progressBar1.Location = new System.Drawing.Point(13, 75);
            this.progressBar1.MarqueeAnimationSpeed = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.OuterColor = System.Drawing.Color.Gray;
            this.progressBar1.OuterMargin = -25;
            this.progressBar1.OuterWidth = 26;
            this.progressBar1.ProgressColor = System.Drawing.Color.Plum;
            this.progressBar1.ProgressWidth = 18;
            this.progressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar1.Size = new System.Drawing.Size(101, 93);
            this.progressBar1.StartAngle = 270;
            this.progressBar1.Step = 1;
            this.progressBar1.SubscriptColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar1.SubscriptMargin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.progressBar1.SubscriptText = "--";
            this.progressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.progressBar1.SuperscriptText = "";
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Text = "CPU";
            this.progressBar1.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.progressBar1.Value = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_available);
            this.groupBox1.Controls.Add(this.lbl_used);
            this.groupBox1.Controls.Add(this.lbl_capacity);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.barAvailable);
            this.groupBox1.Controls.Add(this.barUsed);
            this.groupBox1.Controls.Add(this.barTotal);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(281, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Device";
            // 
            // lbl_available
            // 
            this.lbl_available.AutoSize = true;
            this.lbl_available.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_available.Location = new System.Drawing.Point(295, 27);
            this.lbl_available.Name = "lbl_available";
            this.lbl_available.Size = new System.Drawing.Size(15, 13);
            this.lbl_available.TabIndex = 3;
            this.lbl_available.Text = "--";
            // 
            // lbl_used
            // 
            this.lbl_used.AutoSize = true;
            this.lbl_used.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_used.Location = new System.Drawing.Point(129, 52);
            this.lbl_used.Name = "lbl_used";
            this.lbl_used.Size = new System.Drawing.Size(15, 13);
            this.lbl_used.TabIndex = 3;
            this.lbl_used.Text = "--";
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_capacity.Location = new System.Drawing.Point(129, 27);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(15, 13);
            this.lbl_capacity.TabIndex = 3;
            this.lbl_capacity.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(189, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Available Storage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(26, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Used Storage:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(26, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Storage Capacity:";
            // 
            // barAvailable
            // 
            this.barAvailable.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.barAvailable.AnimationSpeed = 500;
            this.barAvailable.BackColor = System.Drawing.Color.Transparent;
            this.barAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAvailable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.barAvailable.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.barAvailable.InnerMargin = 2;
            this.barAvailable.InnerWidth = -1;
            this.barAvailable.Location = new System.Drawing.Point(229, 75);
            this.barAvailable.MarqueeAnimationSpeed = 2000;
            this.barAvailable.Name = "barAvailable";
            this.barAvailable.OuterColor = System.Drawing.Color.Gray;
            this.barAvailable.OuterMargin = -25;
            this.barAvailable.OuterWidth = 26;
            this.barAvailable.ProgressColor = System.Drawing.Color.SpringGreen;
            this.barAvailable.ProgressWidth = 18;
            this.barAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.barAvailable.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAvailable.Size = new System.Drawing.Size(101, 93);
            this.barAvailable.StartAngle = 270;
            this.barAvailable.Step = 1;
            this.barAvailable.SubscriptColor = System.Drawing.SystemColors.ControlLightLight;
            this.barAvailable.SubscriptMargin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.barAvailable.SubscriptText = "--";
            this.barAvailable.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.barAvailable.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.barAvailable.SuperscriptText = "";
            this.barAvailable.TabIndex = 0;
            this.barAvailable.Text = "Available";
            this.barAvailable.TextMargin = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.barAvailable.Value = 80;
            // 
            // barUsed
            // 
            this.barUsed.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.barUsed.AnimationSpeed = 500;
            this.barUsed.BackColor = System.Drawing.Color.Transparent;
            this.barUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barUsed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.barUsed.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.barUsed.InnerMargin = 2;
            this.barUsed.InnerWidth = -1;
            this.barUsed.Location = new System.Drawing.Point(122, 76);
            this.barUsed.MarqueeAnimationSpeed = 2000;
            this.barUsed.Name = "barUsed";
            this.barUsed.OuterColor = System.Drawing.Color.Gray;
            this.barUsed.OuterMargin = -25;
            this.barUsed.OuterWidth = 26;
            this.barUsed.ProgressColor = System.Drawing.Color.IndianRed;
            this.barUsed.ProgressWidth = 18;
            this.barUsed.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barUsed.Size = new System.Drawing.Size(101, 93);
            this.barUsed.StartAngle = 270;
            this.barUsed.Step = 1;
            this.barUsed.SubscriptColor = System.Drawing.SystemColors.ControlLightLight;
            this.barUsed.SubscriptMargin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.barUsed.SubscriptText = "--";
            this.barUsed.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.barUsed.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.barUsed.SuperscriptText = "";
            this.barUsed.TabIndex = 0;
            this.barUsed.Text = "Used";
            this.barUsed.TextMargin = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.barUsed.Value = 80;
            // 
            // barTotal
            // 
            this.barTotal.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.barTotal.AnimationSpeed = 500;
            this.barTotal.BackColor = System.Drawing.Color.Transparent;
            this.barTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.barTotal.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.barTotal.InnerMargin = 2;
            this.barTotal.InnerWidth = -1;
            this.barTotal.Location = new System.Drawing.Point(13, 75);
            this.barTotal.MarqueeAnimationSpeed = 2000;
            this.barTotal.Name = "barTotal";
            this.barTotal.OuterColor = System.Drawing.Color.Gray;
            this.barTotal.OuterMargin = -25;
            this.barTotal.OuterWidth = 26;
            this.barTotal.ProgressColor = System.Drawing.Color.Goldenrod;
            this.barTotal.ProgressWidth = 18;
            this.barTotal.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barTotal.Size = new System.Drawing.Size(101, 93);
            this.barTotal.StartAngle = 270;
            this.barTotal.Step = 1;
            this.barTotal.SubscriptColor = System.Drawing.SystemColors.ControlLightLight;
            this.barTotal.SubscriptMargin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.barTotal.SubscriptText = "--";
            this.barTotal.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.barTotal.SuperscriptMargin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.barTotal.SuperscriptText = "";
            this.barTotal.TabIndex = 0;
            this.barTotal.Text = "Capacity";
            this.barTotal.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.barTotal.Value = 100;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 273);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(662, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel1.Text = "---";
            // 
            // btn_ViewTree
            // 
            this.btn_ViewTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewTree.Enabled = false;
            this.btn_ViewTree.Location = new System.Drawing.Point(530, 247);
            this.btn_ViewTree.Name = "btn_ViewTree";
            this.btn_ViewTree.Size = new System.Drawing.Size(116, 23);
            this.btn_ViewTree.TabIndex = 4;
            this.btn_ViewTree.Text = "Tree View of Files";
            this.btn_ViewTree.UseVisualStyleBackColor = true;
            this.btn_ViewTree.Click += new System.EventHandler(this.btn_ViewTree_Click);
            // 
            // Device_Health_Meter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(662, 295);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_PerfromanceCounter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ViewTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Device_Health_Meter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device_Health_Meter";
            this.Load += new System.EventHandler(this.Device_Health_Meter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_PerfromanceCounter.ResumeLayout(false);
            this.grp_PerfromanceCounter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grp_PerfromanceCounter;
        private System.Windows.Forms.Label lbl_memory;
        private System.Windows.Forms.Label lbl_cpu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar progressBar2;
        private CircularProgressBar.CircularProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_used;
        private System.Windows.Forms.Label lbl_capacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CircularProgressBar.CircularProgressBar barAvailable;
        private CircularProgressBar.CircularProgressBar barUsed;
        private CircularProgressBar.CircularProgressBar barTotal;
        private System.Windows.Forms.Label lbl_available;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn_ViewTree;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}