using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            var x = new Class1();
            
        }

        private void button1_Click( object sender, EventArgs e )
        {
            var x = new ProjectRootDirectoryManager();

            var treeNode = new TreeNode("");
            treeNode.Tag = null;
            
            treeView1.Nodes.Add(treeNode);

            treeNode.Nodes.Add("");
        }
    }
}
