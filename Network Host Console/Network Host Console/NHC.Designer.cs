namespace Network_Host_Console
{
    partial class NHC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grp_PerfromanceCounter = new System.Windows.Forms.GroupBox();
            this.lbl_memory = new System.Windows.Forms.Label();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new CircularProgressBar.CircularProgressBar();
            this.progressBar1 = new CircularProgressBar.CircularProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grp_PerfromanceCounter.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 31);
            this.panel1.TabIndex = 0;
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
            this.btn_minimize.Location = new System.Drawing.Point(476, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(50, 33);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Network Host Console";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(521, 0);
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
            this.grp_PerfromanceCounter.Location = new System.Drawing.Point(313, 57);
            this.grp_PerfromanceCounter.Name = "grp_PerfromanceCounter";
            this.grp_PerfromanceCounter.Size = new System.Drawing.Size(250, 190);
            this.grp_PerfromanceCounter.TabIndex = 1;
            this.grp_PerfromanceCounter.TabStop = false;
            this.grp_PerfromanceCounter.Text = "Your Device";
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
            this.progressBar2.ProgressColor = System.Drawing.Color.SpringGreen;
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
            this.progressBar1.ProgressColor = System.Drawing.Color.Goldenrod;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(26, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 92);
            this.button2.TabIndex = 2;
            this.button2.Text = "Installed Programs";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(26, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 92);
            this.button3.TabIndex = 2;
            this.button3.Text = "Backdoor Files";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(165, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 92);
            this.button4.TabIndex = 2;
            this.button4.Text = "List Scan";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(26, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 92);
            this.button5.TabIndex = 2;
            this.button5.Text = "Enter Remote CMD";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(572, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDate
            // 
            this.toolStripDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripDate.Name = "toolStripDate";
            this.toolStripDate.Size = new System.Drawing.Size(22, 17);
            this.toolStripDate.Text = "---";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(165, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 92);
            this.button6.TabIndex = 2;
            this.button6.Text = "PC Health Meter";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(26, 145);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 92);
            this.button7.TabIndex = 4;
            this.button7.Text = "View User";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // NHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(572, 284);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grp_PerfromanceCounter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NHC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHC";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_PerfromanceCounter.ResumeLayout(false);
            this.grp_PerfromanceCounter.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.GroupBox grp_PerfromanceCounter;
        private CircularProgressBar.CircularProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_memory;
        private System.Windows.Forms.Label lbl_cpu;
        private CircularProgressBar.CircularProgressBar progressBar2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

