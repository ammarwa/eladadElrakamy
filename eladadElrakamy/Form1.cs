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
            homePanel.Location = loginPanel.Location;
            projectReportsPanel.Location = loginPanel.Location;
            this.BackgroundImage = Properties.Resources.background;
        }

        public void HideAllPanels()
        {
            loginPanel.Visible = false;
            homePanel.Visible = false;
            projectReportsPanel.Visible = false;
            InventoryReportsPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Users WHERE username='"+textBox1.Text+"' AND password='"+textBox2.Text+"'";
            if (textBox1.Text == "admin")
            {
                if(textBox2.Text == "admin")
                {
                    HideAllPanels();
                    maintoolstrip.Visible = true;
                    toolStripButton1.Visible = true;
                    homePanel.Visible = true;
                    projectReportsBindingNavigator.Visible = true;
                    homePanel.BringToFront();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            maintoolstrip.Visible = false;
            toolStripButton1.Visible = false;
            loginPanel.Visible = true;
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
            // TODO: This line of code loads data into the 'adadDatabaseDataSet1.inventoryReports' table. You can move, or remove it, as needed.
            this.inventoryReportsTableAdapter.Fill(this.adadDatabaseDataSet1.inventoryReports);
            // TODO: This line of code loads data into the 'adadDatabaseDataSet1.projectReports' table. You can move, or remove it, as needed.
            this.projectReportsTableAdapter.Fill(this.adadDatabaseDataSet1.projectReports);

        }

        private void projectReportsMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            projectReportsPanel.Visible = true;
            projectReportsPanel.BringToFront();
            Refresh();
        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void تقاريرالمخزونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            maintoolstrip.Visible = true;
            toolStripButton1.Visible = true;
            InventoryReportsPanel.Visible = true;
            inventoryReportsDataGridView.
        }
    }
}
