using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;

using System.IO;

namespace Network_Host_Console
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFoldersInTreeView(treeView1);

        }
        void LoadFoldersInTreeView(TreeView treeName)

        {

            treeName.BeginUpdate();

            treeName.Nodes.Add(System.Environment.MachineName.ToString());
            SetNode(treeName, @"C:\", "My Computer");
            //SetNode(treeName, @"E:\", "My Documents");

        }



        void SetNode(TreeView treeName, string root, string nodeText)

        {

            DirectoryInfo dirInfo = new DirectoryInfo(root);
            TreeNode node = new TreeNode();
            node.Text = nodeText;
            GetFolders(dirInfo, node);
            treeName.Nodes[0].Nodes.Add(node);
        }



        void GetFolders(DirectoryInfo d, TreeNode node)

        {
            try
            {
                DirectoryInfo[] dInfo = d.GetDirectories();

                if (dInfo.Length > 0)

                {
                    TreeNode treeNode = new TreeNode();
                   // TreeNode treeNode1 = new TreeNode();

                    foreach (DirectoryInfo driSub in dInfo)

                    {
                  // long totalSize = driSub..Sum(file => file.Length);
                        treeNode = node.Nodes.Add(driSub.Name);
                        GetFolders(driSub, treeNode);
                       // treeNode.Name = driSub.Name + "--" + totalSize.ToString() + "mb";

                    }
                }

            }

            catch { }



        }

        void GetFiles(DirectoryInfo d, TreeNode node)

        {
            FileInfo[] subfileInfo = d.GetFiles("*.*");
            if (subfileInfo.Length > 0)
            {
                for (int j = 0; j < subfileInfo.Length; j++)
                {

                    node.Nodes.Add(subfileInfo[j].Name);
                }

            }

        }


    }
}
