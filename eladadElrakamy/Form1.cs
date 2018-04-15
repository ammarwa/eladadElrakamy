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
            string query = "SELECT * FROM Users WHERE username='"+textBox1.Text+"' AND password='"+textBox2.Text+"'";
            if (textBox1.Text == "admin")
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
            projectReportsPanel.Visible = false;
            Refresh();
        }

        private void projectReportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectReportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adadDatabaseDataSet1);

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adadDatabaseDataSet1.projectReports' table. You can move, or remove it, as needed.
            this.projectReportsTableAdapter.Fill(this.adadDatabaseDataSet1.projectReports);

        }

        private void projectReportsMenuItem_Click(object sender, EventArgs e)
        {
            projectReportsPanel.Visible = true;
            Refresh();
        }
    }
}
