using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eladadElrakamy
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin")
            {
                if(textBox2.Text == "admin")
                {
                    maintoolstrip.Visible = true;
                    loginPanel.Visible = false;
                    toolStripButton1.Visible = true;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            maintoolstrip.Visible = false;
            toolStripButton1.Visible = false;
            loginPanel.Visible = true;
        }
    }
}
