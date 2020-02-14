using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Host_Console
{
    public partial class Installed_Programs : Form
    {
        public string selectedCompname { get; set; }
        private bool mouseDown;
        private Point lastLocation;
        public Installed_Programs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }
        public void LoadAll()
        {
            label1.Text = "RESULT:";
            txt_hostname.Text = selectedCompname;
            //MessageBox.Show(selectedCompname);
            lstDisplaySoftware.View = View.Details;
            lstDisplaySoftware.GridLines = true;
            lstDisplaySoftware.FullRowSelect = true;
            lstDisplaySoftware.LabelWrap = true;
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {

                            var displayName = sk.GetValue("DisplayName");
                            var size = sk.GetValue("EstimatedSize");
                            var version = sk.GetValue("Version");

                            ListViewItem item;
                            if (displayName != null)
                            {
                                if (size != null)
                                {
                                    item = new ListViewItem(new string[] {displayName.ToString(),
                                                       size.ToString(), version.ToString()});
                                }
                                else
                                {
                                    item = new ListViewItem(new string[] { displayName.ToString(), "", version.ToString() });
                                }
                                lstDisplaySoftware.Items.Add(item);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Problem on retrieving desired data", "Error occured");
                        }
                    }

                }

            }
            String itemsCount = lstDisplaySoftware.Items.Count.ToString();
            label1.Text += " (" + itemsCount + ")";
            lstDisplaySoftware.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstDisplaySoftware.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void getApps()
        {

            try
            {
                txt_hostname.Text = selectedCompname;
                //MessageBox.Show(selectedCompname);
                lstDisplaySoftware.View = View.Details;
                lstDisplaySoftware.GridLines = true;
                lstDisplaySoftware.FullRowSelect = true;
                lstDisplaySoftware.LabelWrap = true;
                ConnectionOptions options =new ConnectionOptions();
                ManagementScope scope =new ManagementScope("\\\\" + selectedCompname + "\\root\\cimv2", options);
                scope.Connect();
                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_Product");
                ManagementObjectSearcher searcher =new ManagementObjectSearcher(scope, query);
                ManagementObjectCollection queryCollection = searcher.Get();

                foreach (ManagementObject m in queryCollection)
                {/*
                        String pcname = m["csname"].ToString();
                        String windows1 = m["WindowsDirectory"].ToString();
                        String OS1 = m["Caption"].ToString();
                        String OSver1 = m["Version"].ToString();
                        String manufacturerOS1 = m["Manufacturer"].ToString();
                        MessageBox.Show("HOSTNAME::::" + pcname + "\n WINDOWS::::" + windows1 + "\n OPERATING SYSTEM" + OS1 + "\n VERSION::::" + OSver1 + "\n Manufacturer::::" + manufacturerOS1);
                   */
                    try
                    {
                        ListViewItem item1;
                        var newDate = DateTime.ParseExact(m["InstallDate"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
                        item1 = new ListViewItem(new string[] { m["Name"].ToString(), newDate.ToString(), m["Version"].ToString(), });
                        lstDisplaySoftware.Items.Add(item1);
                    }
                    catch (Exception ex)
                    {

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please run this as administrator");
            }
            String itemsCount = lstDisplaySoftware.Items.Count.ToString();
            label1.Text += " (" + itemsCount + ")";
            lstDisplaySoftware.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstDisplaySoftware.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Installed_Programs_Load(object sender, EventArgs e)
        {
            getApps();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Loading ...";
            if (txt_Search.Text != "")
            {
                for (int i = lstDisplaySoftware.Items.Count - 1; i >= 0; i--)
                {
                    var item = lstDisplaySoftware.Items[i];
                    if (item.Text.ToLower().Contains(txt_Search.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        item.BackColor = default;//SystemColors.Desktop;
                        item.ForeColor = default; // SystemColors.ControlDark;
                        lstDisplaySoftware.Items.Remove(item);
                    }
                }
                if (lstDisplaySoftware.SelectedItems.Count == 1)
                {
                    lstDisplaySoftware.Focus();
                }

                //  lstDisplayHardware.
            }
            else
            {
                getApps();
                //LoadAll();
                for (int i = lstDisplaySoftware.Items.Count - 1; i >= 0; i--)
                {
                    var item = lstDisplaySoftware.Items[i];
                    item.BackColor = SystemColors.Control;
                    item.ForeColor = SystemColors.WindowText;
                }
            }
            // LoadContacts();

            label1.Text = "RESULT: (" + lstDisplaySoftware.Items.Count.ToString() + ")";
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

        private void button1_Click(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
            try 
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
           
                int i = 1;
                int i2 = 2;
                ws.Cells[1, 1] = "Name";
                ws.Cells[1, 2] = "Install Date";
                ws.Cells[1, 3] = "Version";
                ws.Cells[1, 5] = lbldate.Text;
                ws.Range["E1"].Interior.Color = Color.Tomato;
                ws.Range["A1, B1,C1"].Interior.Color = System.Drawing.Color.Black;
                ws.Range["A1, B1,C1"].Font.Color = System.Drawing.Color.White;
                ws.Range["A1"].ColumnWidth = 70;
                ws.Range["B1"].ColumnWidth = 20;
                ws.Range["E1"].ColumnWidth = 20;
                ws.Range["C1"].ColumnWidth = 20;

                foreach (ListViewItem lvi in lstDisplaySoftware.Items)
                {
                    i = 1;
                    foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                    {
                        ws.Cells[i2, i] = lvs.Text;
                        i++;
                    }
                   
                    i2++;
                }
            } catch (Exception ex) { }
        }
    }
}
