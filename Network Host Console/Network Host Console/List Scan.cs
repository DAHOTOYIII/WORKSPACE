using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Network_Host_Console
{
    
    public partial class List_Scan : Form
    {
        String cname, ipv4, ipv6, status, OsDisplayName, sMacAddress, OSstring, osVersion, osName, mcadd;
        private bool mouseDown;
        private Point lastLocation;
        DataGridViewRow Rowhit;
        public List_Scan()
        {
            InitializeComponent();
            dg_MainGrid.ScrollBars = ScrollBars.Both;
            mtxt_Hostnames.ScrollBars = ScrollBars.Both;
            dg_MainGrid.MouseClick += new MouseEventHandler(dg_MainGrid_RightClick);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // waitStat();
            dg_MainGrid.Enabled = true;
            dg_MainGrid.Rows.Clear();
            lbl_scanstat.Text = "Please wait while scanning";
            string[] lines = mtxt_Hostnames.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int numLines = mtxt_Hostnames.Lines.Length;
            numLines = lines.Count();
            txt_Lines.Text = numLines.ToString();
            if (numLines != 0)
            {
                toolStripProgressBar1.Visible = true;
                try
                {

                    //iteration for each hostname
                    for (int i = 0; i < numLines; i++)
                    {
                        cname = lines[i];
                        if (i == 0)
                        {

                            Ping ping = new Ping();
                            PingReply pingReply = ping.Send(lines[i]);
                            if (pingReply.Status == IPStatus.Success)
                            {
                                status = "Online";
                                getIP(lines[i]);
                                getMac(lines[i]);
                                getOSname(lines[i]);
                            }
                            else
                            {
                                getIP(lines[i]);
                                status = "offline";
                                try
                                {
                                    Rowhit = dg_MainGrid.Rows[i];
                                    Rowhit.DefaultCellStyle.ForeColor = Color.Red;
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                            //first row of datagrid
                            dg_MainGrid.Rows[i].Cells["clm_Status"].Value = status;
                            dg_MainGrid.Rows[i].Cells["clm_Hostname"].Value = lines[i];
                            dg_MainGrid.Rows[i].Cells["clm_IPV4"].Value = ipv4;
                            dg_MainGrid.Rows[i].Cells["clm_IPV6"].Value = ipv6;
                            dg_MainGrid.Rows[i].Cells["clm_MacAddress"].Value = sMacAddress;
                            dg_MainGrid.Rows[i].Cells["clm_OSName"].Value = osName;
                            resetStrings();
                        }
                        else
                        {
                            Ping ping = new Ping();
                            PingReply pingReply = ping.Send(lines[i]);
                            if (pingReply.Status == IPStatus.Success)
                            {
                                status = "Online";
                                getIP(lines[i]);
                                getMac(lines[i]);
                                getOSname(lines[i]);
                            }
                            else
                            {
                                status = "offline";
                                try
                                {
                                    Rowhit = dg_MainGrid.Rows[i];
                                    Rowhit.DefaultCellStyle.ForeColor = Color.Red;
                                }
                                catch (Exception ex)
                                {
                                    // MessageBox.Show("Error changing forecolor \n"+ex.ToString());
                                }
                                getIP(lines[i]);
                            }
                            //adding row
                            dg_MainGrid.Rows.Add(lines[i], sMacAddress, osName, ipv4, ipv6, status);
                            resetStrings();
                        }
                    }
                    enableOptions();
                    lbl_DateTime.Text = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: possible wrong input: " + cname, "Wrong Hostname", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No inputs detected");
            }
            toolStripProgressBar1.Visible = false;
            lbl_scanstat.Text = "Done";

        }

        private void oSDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getOSname(cname);
            MessageBox.Show("Name:  " + OsDisplayName + "\nOS Version:  " + osVersion);
        }

      
        //export grid to excel
        public void exportToExcel()
        {
            try
            {
                dg_MainGrid.SelectAll();
                dg_MainGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                DataObject dataObj = dg_MainGrid.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
               // Excel.Range R = (Excel.Range)xlWorkSheet.Cells[1, 0];
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                Excel.Range BR = (Excel.Range)xlWorkSheet.Cells[1, 2];
                Excel.Range AR = (Excel.Range)xlWorkSheet.Cells[1, 3];
                Excel.Range DR = (Excel.Range)xlWorkSheet.Cells[1, 4];
                Excel.Range ER = (Excel.Range)xlWorkSheet.Cells[1, 5];
                Excel.Range FR = (Excel.Range)xlWorkSheet.Cells[1, 6];
                Excel.Range GR = (Excel.Range)xlWorkSheet.Cells[1, 7];
                Excel.Range date = (Excel.Range)xlWorkSheet.Cells[1, 9];
                date.Interior.Color = Color.Tomato;
                date.ColumnWidth = 30;
                //lWorkSheet.Cells[0, 1] = lbl_DateTime.Text;
                // CR.ColumnWidth = 40;
                AR.ColumnWidth = 20;
                AR.Interior.Color = Color.Black;
                AR.Font.FontStyle = FontStyle.Bold;
                AR.Font.Color = Color.White;
                BR.ColumnWidth = 30;
                BR.Interior.Color = Color.Black;
                BR.Font.FontStyle = FontStyle.Bold;
                BR.Font.Color = Color.White;
                DR.ColumnWidth = 16;
                DR.Interior.Color = Color.Black;
                DR.Font.FontStyle = FontStyle.Bold;
                DR.Font.Color = Color.White;
                CR.ColumnWidth = 25;
                ER.ColumnWidth = 30;
                ER.Interior.Color = Color.Black;
                ER.Font.FontStyle = FontStyle.Bold;
                ER.Font.Color = Color.White;
                FR.ColumnWidth = 20;
                FR.Interior.Color = Color.Black;
                FR.Font.FontStyle = FontStyle.Bold;
                FR.Font.Color = Color.White;
                GR.ColumnWidth = 20;
                GR.Interior.Color = Color.Black;
                GR.Font.FontStyle = FontStyle.Bold;
                GR.Font.Color = Color.White;
                //R.Select();
               // Clipboard.SetText("Scan Date:"+lbl_DateTime.Text);
               // xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
               
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                date.Select();
                Clipboard.SetText("Scan Date:" + lbl_DateTime.Text);
                xlWorkSheet.PasteSpecial(date, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        private void btnCMD_Click(object sender, EventArgs e)
        {
            enterCMD(cname);
        }
        //Enter CMD using PSEXEC
        public void enterCMD(String hostName)
        {
            try
            {
                int selectedrowindex = dg_MainGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dg_MainGrid.Rows[selectedrowindex];

                if (selectedrowindex >= 0)
                {
                    // ctm_dgOptions.Show(dg_MainGrid, new Point(e.X, e.Y));
                    cname = Convert.ToString(selectedRow.Cells[0].Value);
                    // MessageBox.Show(cname);
                    String ipconfig = @"/k cd c:\\Program Files\\NetConsoleAddin & psexec " + "\\\\" + hostName + " cmd";
                    // Clipboard.SetText("psexec \\\\"+cname+" cmd");

                    ProcessStartInfo pro = new ProcessStartInfo();

                    pro.Arguments = ipconfig;
                    pro.FileName = "cmd.exe";
                    // pro.Arguments = ipconfig;
                    Process proStart = new Process();
                    proStart.StartInfo = pro;
                    proStart.Start();
                    proStart.WaitForExit();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No seleted Row");

            }

        }

        private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enterCMD(cname);
        }

        private void btn_Shutdown_Click(object sender, EventArgs e)
        {
            ShutdownProcess(cname);
        }

        //Shutdown process
        public void ShutdownProcess(String hostName)
        {
            try
            {
                int selectedrowindex = dg_MainGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dg_MainGrid.Rows[selectedrowindex];

                if (selectedrowindex >= 0)
                {
                    cname = Convert.ToString(selectedRow.Cells[0].Value);
                    try
                    {
                        DialogResult res = MessageBox.Show("Are you sure you shutdown:" + cname, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (res == DialogResult.OK)
                        {
                            string shutdownString = @"/c shutdown /s /t 1 -f -m \\" + hostName;
                            ProcessStartInfo psiOpt = new ProcessStartInfo("cmd.exe", shutdownString);
                            psiOpt.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System);
                            psiOpt.WindowStyle = ProcessWindowStyle.Hidden;
                            psiOpt.RedirectStandardOutput = true;
                            psiOpt.UseShellExecute = false;
                            psiOpt.CreateNoWindow = true;
                            Process procCommand = Process.Start(psiOpt);
                            procCommand.WaitForExit();
                        }
                        if (res == DialogResult.Cancel)
                        {
                            MessageBox.Show("Shutdown canceled");
                            //Some task…  
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No seleted Row");

            }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            RestartProcess(cname);
        }
        //Restart code
        public void RestartProcess(String hostName)
        {

            try
            {
                int selectedrowindex = dg_MainGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dg_MainGrid.Rows[selectedrowindex];

                if (selectedrowindex >= 0)
                {
                    cname = Convert.ToString(selectedRow.Cells[0].Value);
                    try
                    {
                        DialogResult rst = MessageBox.Show("Are you sure you want to restart:" + cname, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (rst == DialogResult.OK)
                        {
                            string shutdownString = @"/c shutdown /r /f -m  \\" + hostName;
                            ProcessStartInfo psiOpt = new ProcessStartInfo("cmd.exe", shutdownString);
                            psiOpt.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.System);
                            psiOpt.WindowStyle = ProcessWindowStyle.Hidden;
                            psiOpt.RedirectStandardOutput = true;
                            psiOpt.UseShellExecute = false;
                            psiOpt.CreateNoWindow = true;
                            Process procCommand = Process.Start(psiOpt);
                            procCommand.WaitForExit();
                        }
                        else
                        {
                            MessageBox.Show("Reboot canceled");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No seleted Row");

            }




        }

       
        //RDP code
        public void RDPprocess(String hostName)
        {
            try
            {
                // getIP(hostName);
                int selectedrowindex = dg_MainGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dg_MainGrid.Rows[selectedrowindex];

                if (selectedrowindex >= 0)
                {
                    // ctm_dgOptions.Show(dg_MainGrid, new Point(e.X, e.Y));
                    ipv4 = Convert.ToString(selectedRow.Cells[0].Value);
                    // MessageBox.Show(cname);

                    Process rdcProcess = new Process();
                    rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
                    rdcProcess.StartInfo.Arguments = "/generic:TERMSRV/192.168.0.217 /user:" + "user" + " /pass:" + "Welcome01";
                    rdcProcess.Start();

                    rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe");
                    rdcProcess.StartInfo.Arguments = "/v " + ipv4; // ip or name of computer to connect
                    rdcProcess.Start();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No seleted Row");

            }
        }

      
        //Access Files
        public void AccessFiles(String hostName)
        {
            try
            {
                int selectedrowindex = dg_MainGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dg_MainGrid.Rows[selectedrowindex];

                if (selectedrowindex >= 0)
                {
                    // ctm_dgOptions.Show(dg_MainGrid, new Point(e.X, e.Y));
                    cname = Convert.ToString(selectedRow.Cells[0].Value);
                    String status = Convert.ToString(selectedRow.Cells[5].Value);
                    // MessageBox.Show(cname);
                    if (status == "Online")
                    {
                        ProcessStartInfo pro = new ProcessStartInfo();
                        pro.Arguments = "\\\\" + hostName + "\\c$";
                        pro.FileName = "explorer.exe";
                        Process proStart = new Process();
                        proStart.StartInfo = pro;
                        proStart.Start();
                    }
                    else
                    {
                        MessageBox.Show(hostName + "is offline");
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No seleted Row");

            }
        }

        private void fIlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessFiles(cname);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartProcess(cname);
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutdownProcess(cname);
        }

        private void rDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RDPprocess(cname);
        }

        private void scanPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

          //  Device_Details ddetails = new Device_Details();
          //  ddetails.selectedCompname = cname;
           // ddetails.Show();
        }

        private void btnPrograms_Click(object sender, EventArgs e)
        {
            GetApps();
        }
        //
        public void GetApps()
        {
            toolStripProgressBar1.Visible = true;
            lbl_scanstat.Text = "Retrieving Installed Apps.";
            lbl_scanstat.ForeColor = Color.Red;
         //   Installed_Programs_and_Softwares inst = new Installed_Programs_and_Softwares();
          //  inst.selectedCompname = cname;
          //  inst.Show();
            lbl_scanstat.Text = "Done";
            lbl_scanstat.ForeColor = Color.Green;
            toolStripProgressBar1.Visible = false;


        }

        private void List_Scan_Load(object sender, EventArgs e)
        {
            disableOptions();
            dg_MainGrid.Columns[0].DefaultCellStyle.ForeColor = Color.Blue;
            dg_MainGrid.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dg_MainGrid.Columns[2].DefaultCellStyle.ForeColor = Color.Blue;
            dg_MainGrid.Columns[3].DefaultCellStyle.ForeColor = Color.Blue;
            dg_MainGrid.Columns[4].DefaultCellStyle.ForeColor = Color.Blue;
            dg_MainGrid.Columns[5].DefaultCellStyle.ForeColor = Color.Blue;
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            exportToExcel();
        }

        private void btnPrograms_Click_1(object sender, EventArgs e)
        {
            lbl_scanstat.Text = "Retrieving Information from the device";
            lbl_scanstat.ForeColor = Color.Gold;
            Installed_Programs instPrograms = new Installed_Programs();
            instPrograms.selectedCompname = cname;
            instPrograms.Show();
            lbl_scanstat.Text = "Operation Done";
            lbl_scanstat.ForeColor = Color.Green;
        }

        private void btn_Files_Click_1(object sender, EventArgs e)
        {
            AccessFiles(cname);
        }

        private void btnRDP_Click_1(object sender, EventArgs e)
        {
            RDPprocess(cname);
        }

        private void btnCMD_Click_1(object sender, EventArgs e)
        {
            enterCMD(cname);
        }

        private void fIlesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccessFiles(cname);
        }

        private void viewInstalledAppsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lbl_scanstat.Text = "Retrieving Information from the device";
            lbl_scanstat.ForeColor = Color.Gold;
            Installed_Programs instPrograms = new Installed_Programs();
            instPrograms.selectedCompname = cname;
            instPrograms.Show();
            lbl_scanstat.Text = "Operation Done";
            lbl_scanstat.ForeColor = Color.Green;
        }

        private void scanPerformanceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Device_Health_Meter dvm = new Device_Health_Meter();
            dvm.selectedHost = cname;
            dvm.Show();
        }

        private void viewInstalledAppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetApps();
        }

      
        private void dg_MainGrid_RightClick(object sender, MouseEventArgs e)
        {

            int currentMouseOverRow = dg_MainGrid.HitTest(e.X, e.Y).RowIndex;
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    int selectedrowindex = dg_MainGrid.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dg_MainGrid.Rows[selectedrowindex];

                    if (selectedrowindex >= 0)
                    {
                        ctm_dgOptions.Show(dg_MainGrid, new Point(e.X, e.Y));
                        cname = Convert.ToString(selectedRow.Cells[0].Value);
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No seleted Row");

                }
            }
            else
            {
                try
                {
                    DataGridViewRow selectedRow = dg_MainGrid.Rows[currentMouseOverRow];
                    selectedRow.Selected = true;
                }
                catch { }

            }
        }

        public void getIP(String hostName)
        {
            try
            {
                IPAddress[] ipaddress = Dns.GetHostAddresses(hostName);
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                //IPV4
                foreach (IPAddress ip4 in ipaddress.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
                {
                    // Console.WriteLine(ip4.ToString());
                    ipv4 = ip4.ToString();
                }
                //IPV6

                foreach (IPAddress ip6 in ipaddress.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6))
                {
                    // Console.WriteLine(ip6.ToString());
                    ipv6 = ip6.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting IP for " + hostName);
            }
        }
        public void getMac(String hostName)
        {
            try
            {
                ManagementObjectSearcher query1;
                ManagementObjectCollection queryCollection1;
                ManagementScope RemoteConn;
                ConnectionOptions options =
                    new ConnectionOptions();
                ObjectQuery oQuery = new ObjectQuery("Select MacAddress,IPAddress from Win32_NetworkAdapterConfiguration where IPEnabled=TRUE");
                RemoteConn = new ManagementScope("\\\\" + hostName + "\\root\\cimv2", options);
                query1 = new ManagementObjectSearcher(RemoteConn, oQuery);
                queryCollection1 = query1.Get();

                foreach (ManagementObject mo in queryCollection1)
                {
                    int nrIP = ((System.Array)(mo["IPAddress"])).Length;

                    for (int c = 0; c < nrIP; c++)
                    {
                        sMacAddress = mo["MacAddress"].ToString();
                    }
                }
                // MessageBox.Show(sMacAddress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void getOSname(String hostName)
        {

            try
            {
                ConnectionOptions options1 =
                    new ConnectionOptions();
                ManagementScope scope =
                    new ManagementScope(
                    "\\\\" + hostName + "\\root\\cimv2", options1);
                scope.Connect();

                ObjectQuery query = new ObjectQuery(
                    "SELECT * FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(scope, query);
                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject m in queryCollection)
                {
                    String pcname = m["csname"].ToString();
                    String windows1 = m["WindowsDirectory"].ToString();
                    OsDisplayName = m["Caption"].ToString();
                    osName = OsDisplayName;
                    osVersion = m["Version"].ToString();
                    OSstring = m["Manufacturer"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please run this as administrator");
            }

        }
        public void resetStrings()
        {
            sMacAddress = "";
            osName = "";
            ipv4 = "";
            ipv6 = "";
            status = "";
        }
        public void disableOptions()
        {
            dg_MainGrid.Enabled = false;
            btnPrograms.Enabled = false;
            btnRDP.Enabled = false;
            btn_Restart.Enabled = false;
            btn_Shutdown.Enabled = false;
            btn_Files.Enabled = false;
            btnExport.Enabled = false;
            btn_Shutdown.Enabled = false;
            btnCMD.Enabled = false;
        }
        public void enableOptions()
        {
            btnPrograms.Enabled = true;
            btnRDP.Enabled = true;
            btn_Restart.Enabled = true;
            btn_Shutdown.Enabled = true;
            btn_Files.Enabled = true;
            btnExport.Enabled = true;
            btn_Shutdown.Enabled = true;
            btnCMD.Enabled = true;


        }
        private void WindowsReset()
        {
            mtxt_Hostnames.Text = null;
            txt_Lines.Text = null;
            lbl_scanstat.Text = "Waiting for inputs";
        }
    }
}
