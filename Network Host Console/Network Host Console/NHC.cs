using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Host_Console
{
    public partial class NHC : Form
    {
        private static System.Timers.Timer _timer;
        private bool mouseDown;
        private Point lastLocation;
        public NHC()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer();
            _timer.Interval = 3000;
            _timer.Elapsed += OntimedEvent;
            _timer.AutoReset = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //--Timer
        public void OntimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            int cpuValue = GetCpuValue();
            int memValue = GetMemValue();
            toolStripDate.Text = DateTime.Now.ToString();
            // 
            // progressBar2.Value = memValue;

            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action(() => progressBar1.Value = cpuValue));
            }
            else
            {
                progressBar1.Value = cpuValue;
            }

            if (progressBar2.InvokeRequired)
            {
                progressBar2.Invoke(new Action(() => progressBar2.Value = memValue));
            }
            else
            {
                progressBar2.Value = memValue;
            }
          //  per_cpu.Text = progressBar1.Value.ToString() + "%";
            //per_mem.Text = progressBar2.Value.ToString() + "%";
            progressBar1.SubscriptText= progressBar1.Value.ToString() + "%";
            progressBar2.SubscriptText = progressBar2.Value.ToString() + "%";
            lbl_cpu.Text= progressBar1.Value.ToString() + "%";
            lbl_memory.Text= progressBar2.Value.ToString() + "%";
            //  Form1.SubscriptText = progressBar1.Value.ToString() + "%";
            /// pMem.Text = per_mem.Text;
            int c = progressBar1.Value;
            int m = progressBar2.Value;
            if (c >= 70 && c != 90)
            {
                progressBar1.ProgressColor = Color.Gold;
            }
            if (c >= 90)
            {
                progressBar1.OuterColor = Color.Gold;
            }
            else
            {
                progressBar1.ProgressColor = Color.Gold;


            }
            if (m >= 70 && m != 90)
            {
                progressBar2.ProgressColor = Color.SpringGreen;
            }
            if (m >= 70)
            {
               progressBar2.ProgressColor= Color.SpringGreen;

            }
            else
            {
                progressBar2.ProgressColor = Color.SpringGreen;
            }


        }
        public int GetCpuValue()
        {
            var CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            CpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            int returnvalue = (int)CpuCounter.NextValue();
            return returnvalue;


        }
        public int GetMemValue()
        {
            var MemCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");
            MemCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            int returnvalue = (int)MemCounter.NextValue();
            return returnvalue;
        }
        private void btn_scanusage_Click(object sender, EventArgs e)
        {
            _timer.Enabled = true;
        }

        private void Device_Details_Load(object sender, EventArgs e)
        {
            //txt_Host.Text = selectedCompname;
        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            grp_PerfromanceCounter.Text = System.Environment.MachineName+": Health Meter";
            _timer.Enabled = true;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           List_Scan lstScan = new List_Scan();
            lstScan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_By_Hostname searchByName = new Search_By_Hostname();
            searchByName.selectedCommand = "p";
            searchByName.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search_By_Hostname srchHost = new Search_By_Hostname();
            srchHost.selectedCommand = "f";
            srchHost.Show();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //button2.ImageAlign = ContentAlignment.TopCenter;
            // elementInstalled.Visible = true;
            button2.BackColor = Color.Tomato;
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Search_By_Hostname srchHost = new Search_By_Hostname();
            srchHost.selectedCommand = "c";
            srchHost.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Search_By_Hostname srchHost = new Search_By_Hostname();
            srchHost.selectedCommand = "s";
            srchHost.Show();
           
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // elementInstalled.Visible = false;
            button2.BackColor = Color.DodgerBlue;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Fuchsia;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.DodgerBlue;
        }
    }
}
