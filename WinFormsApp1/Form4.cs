using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void 功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 類別管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void 資料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }
    }
}
