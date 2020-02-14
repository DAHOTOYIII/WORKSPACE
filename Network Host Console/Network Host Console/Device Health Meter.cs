using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Host_Console
{
    public partial class Device_Health_Meter : Form
    {
        private static System.Timers.Timer _timer;
        public string selectedHost { get; set; }
        private Point lastLocation;
        private bool mouseDown;
        public Device_Health_Meter()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer();
            _timer.Interval = 3000;
            _timer.Elapsed += OntimedEvent;
            _timer.AutoReset = true;

        }

        private void CalculateFreeUsed(string srvname)
        {
            try
            {
                ConnectionOptions oConn = new ConnectionOptions();
                new ConnectionOptions();
                string strNameSpace = @"\\";
                if (srvname != "")
                    strNameSpace += srvname;
                else
                    strNameSpace += ".";
                strNameSpace += @"\root\cimv2";
                ManagementScope oMs = new ManagementScope(strNameSpace, oConn);

                //get Fixed disk state

                ObjectQuery oQuery = new ObjectQuery("select FreeSpace,Size,Name from Win32_LogicalDisk where DriveType=3");

                //Execute the query
                ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);

                //Get the results
                ManagementObjectCollection oReturnCollection = oSearcher.Get();

                //loop through found drives and write out info
                double D_Freespace = 0;
                double D_Totalspace = 0;
                foreach (ManagementObject oReturn in oReturnCollection)
                {
                    // Disk name
                     string strFreespace = oReturn["FreeSpace"].ToString();
                    D_Freespace = D_Freespace + System.Convert.ToDouble(strFreespace);
                    string strTotalspace = oReturn["Size"].ToString();
                    D_Totalspace = D_Totalspace + System.Convert.ToDouble(strTotalspace);
                    // int x = Convert.ToInt32(strTotalspace);
                    double finalTotal = D_Totalspace / 1000000000;
                    double finalFree= D_Freespace / 1000000000;
                    double d1 = Math.Round(finalTotal, 0);
                    double d2 = Math.Round(finalFree, 0);
                    int x = (int)d1;
                    int y = (int)d2;
                    int m = x - y;
                    //MessageBox.Show(x.ToString());

                    barUsed.Maximum = x;
                    barAvailable.Maximum = x;
                    barTotal.Maximum = x;
                    barTotal.Value = x;

                    barAvailable.Value = y;
                    barUsed.Value = m;

                    barUsed.SubscriptText = m.ToString() + "GB";
                    barAvailable.SubscriptText = y.ToString() + "GB";
                    barTotal.SubscriptText = x.ToString() + "GB";

                    lbl_capacity.Text = x.ToString()+"GB";
                    lbl_available.Text = y.ToString()+"GB";
                    lbl_used.Text = m.ToString()+"GB";

                }
            }
            catch
            {
                MessageBox.Show("Failed to obtain Server Information.", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Device_Health_Meter_Load(object sender, EventArgs e)
        {
            CalculateFreeUsed(selectedHost);
            groupBox1.Text = selectedHost + ": Storage";
            lblHostname.Text = selectedHost;
            _timer.Enabled = true;
        }
        public void OntimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            int cpuValue = GetCpuValue();
            int memValue = GetMemValue();
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

            progressBar1.SubscriptText = progressBar1.Value.ToString() + "%";
            progressBar2.SubscriptText = progressBar2.Value.ToString() + "%";
            lbl_cpu.Text = progressBar1.Value.ToString() + "%";
            lbl_memory.Text = progressBar2.Value.ToString() + "%";
            //  Form1.SubscriptText = progressBar1.Value.ToString() + "%";
            /// pMem.Text = per_mem.Text;
            int c = progressBar1.Value;
            int m = progressBar2.Value;
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

        private void btn_ViewTree_Click(object sender, EventArgs e)
        {
            Form1 nfrm1 = new Form1();
            nfrm1.Show();
        }
    }
}
