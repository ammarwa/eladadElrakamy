using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;

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
            InventoryPanel.Visible = false;
            SpentReportPanel.Visible = false;
            WorkersPanel.Visible = false;
            FinalReportsPanel.Visible = false;
            printToolStripButton.Visible = false;
            projectSpentPanel.Visible = false;
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
                    projectReportsBindingNavigator.Visible = false;
                    homePanel.BringToFront();
                    printToolStripButton.Visible = false;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            maintoolstrip.Visible = false;
            toolStripButton1.Visible = false;
            printToolStripButton.Visible = false;
            projectReportsBindingNavigator.Visible = false;
            loginPanel.Visible = true;
        }

        private void projectReportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectReportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adadDatabaseDataSet1);

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adadDatabaseDataSet1.projectSpent' table. You can move, or remove it, as needed.
            this.projectSpentTableAdapter.Fill(this.adadDatabaseDataSet1.projectSpent);
            // TODO: This line of code loads data into the 'adadDatabaseDataSet1.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.adadDatabaseDataSet1.Workers);
            // TODO: This line of code loads data into the 'adadDatabaseDataSet1.spentReport' table. You can move, or remove it, as needed.
            this.spentReportTableAdapter.Fill(this.adadDatabaseDataSet1.spentReport);
            // TODO: This line of code loads data into the 'adadDatabaseDataSet1.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.adadDatabaseDataSet1.Inventory);
            // TODO: This line of code loads data into the 'adadDatabaseDataSet1.inventoryReports' table. You can move, or remove it, as needed.
            this.inventoryReportsTableAdapter.Fill(this.adadDatabaseDataSet1.inventoryReports);
            // TODO: This line of code loads data into the 'adadDatabaseDataSet1.projectReports' table. You can move, or remove it, as needed.
            this.projectReportsTableAdapter.Fill(this.adadDatabaseDataSet1.projectReports);

        }

        private void projectReportsMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            this.projectReportsTableAdapter.Fill(this.adadDatabaseDataSet1.projectReports);
            projectReportsPanel.Visible = true;
            projectReportsBindingNavigator.Visible = false;
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
            projectReportsBindingNavigator.Visible = false;
            this.inventoryReportsTableAdapter.Fill(this.adadDatabaseDataSet1.inventoryReports);
            InventoryReportsPanel.Visible = true;
        }

        private void المخزونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            this.inventoryTableAdapter.Fill(this.adadDatabaseDataSet1.Inventory);
            InventoryPanel.Visible = true;
        }

        private void المصروفاتالعامةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            this.spentReportTableAdapter.Fill(this.adadDatabaseDataSet1.spentReport);
            SpentReportPanel.Visible = true;
        }

        private void شؤونالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
                HideAllPanels();
            this.workersTableAdapter.Fill(this.adadDatabaseDataSet1.Workers);
            WorkersPanel.Visible = true;
        }

        private void incomeGetBtn_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT dbo.getIncome()";
            com.Connection = con;
            incomeLbl.Text = com.ExecuteScalar().ToString();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT dbo.getSpent()";
            com.Connection = con;
            spentLbl.Text = com.ExecuteScalar().ToString();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT dbo.getRestIncome()";
            com.Connection = con;
            restIncomeLbl.Text = com.ExecuteScalar().ToString();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT dbo.getSpentVAT()";
            com.Connection = con;
            VATIN.Text = com.ExecuteScalar().ToString();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT dbo.getTakenVAT()";
            com.Connection = con;
            VATOut.Text = com.ExecuteScalar().ToString();
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT dbo.getRestVAT()";
            com.Connection = con;
            RestVAT.Text = com.ExecuteScalar().ToString();
            con.Close();
        }

        private void التقاريرالشاملةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            FinalReportsPanel.Visible = true;
            printToolStripButton.Visible = true;
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = true;
            app.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateNormal;

            Microsoft.Office.Interop.Word.Document document = app.Documents.Add();


            Microsoft.Office.Interop.Word.Paragraph paragraph;
            paragraph = document.Paragraphs.Add();
            paragraph.Range.Text = "ضريبة مدخلات: " + VATIN.Text + "\n   ضريبة مخرجات: " + VATOut.Text + "\n   الضريبة المستحقة: " + RestVAT.Text;
            
            document.SaveAs();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(sRID.Text);
            string desc = sRdesc.Text;
            string price = sRvalue.Text;

            string stmt = "INSERT INTO spentReport (id, description, value) VALUES(@id , @desc , @price)";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@desc", SqlDbType.VarChar, 100);
                com.Parameters.Add("@price", SqlDbType.Money);

                com.Parameters["@id"].Value = id;
                com.Parameters["@desc"].Value = desc;
                com.Parameters["@price"].Value = price;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.spentReportTableAdapter.Fill(this.adadDatabaseDataSet1.spentReport);
            } catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox2.Text);
            string desc = descriptionTextBox2.Text;
            string price = valueTextBox1.Text;

            string stmt = "UPDATE spentReport SET description = @desc, value = @price WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@desc", SqlDbType.VarChar, 100);
                com.Parameters.Add("@price", SqlDbType.Money);

                com.Parameters["@id"].Value = id;
                com.Parameters["@desc"].Value = desc;
                com.Parameters["@price"].Value = price;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.spentReportTableAdapter.Fill(this.adadDatabaseDataSet1.spentReport);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(invIDADD.Text);
            string desc = invDescADD.Text;
            string price = invPriceADD.Text;
            string qty = invQtyADD.Text;
            string notes = invNotesADD.Text;

            string stmt = "INSERT INTO Inventory (id, description, price, notes, Quantity) VALUES(@id , @desc , @price, @notes, @qty)";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@desc", SqlDbType.VarChar, 100);
                com.Parameters.Add("@price", SqlDbType.Money);
                com.Parameters.Add("@qty", SqlDbType.Int);
                com.Parameters.Add("@notes", SqlDbType.VarChar, 100);

                com.Parameters["@id"].Value = id;
                com.Parameters["@desc"].Value = desc;
                com.Parameters["@price"].Value = price;
                com.Parameters["@qty"].Value = qty;
                com.Parameters["@notes"].Value = notes;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.inventoryTableAdapter.Fill(this.adadDatabaseDataSet1.Inventory);
                this.inventoryReportsTableAdapter.Fill(this.adadDatabaseDataSet1.inventoryReports);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox1.Text);
            string desc = descriptionTextBox1.Text;
            string price = priceTextBox1.Text;
            string qty = quantityTextBox.Text;
            string notes = notesTextBox1.Text;

            string stmt = "UPDATE Inventory SET description = @desc, price = @price, Quantity = @qty, notes = @notes WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@desc", SqlDbType.VarChar, 100);
                com.Parameters.Add("@price", SqlDbType.Money);
                com.Parameters.Add("@qty", SqlDbType.Int);
                com.Parameters.Add("@notes", SqlDbType.VarChar, 100);

                com.Parameters["@id"].Value = id;
                com.Parameters["@desc"].Value = desc;
                com.Parameters["@price"].Value = price;
                com.Parameters["@qty"].Value = qty;
                com.Parameters["@notes"].Value = notes;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.inventoryTableAdapter.Fill(this.adadDatabaseDataSet1.Inventory);
                this.inventoryReportsTableAdapter.Fill(this.adadDatabaseDataSet1.inventoryReports);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox4.Text);
            int invID = Convert.ToInt32(invIDTextBox.Text);
            string discount = discountTextBox.Text;
            string qty = qtyTextBox.Text;
            string notes = notesTextBox.Text;
            string sentto = senttoTextBox1.Text;

            string stmt = "UPDATE inventoryReports SET invID = @invID, discount = @discount, qty = @qty, notes = @notes, sentto = @sentto WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@invID", SqlDbType.Int);
                com.Parameters.Add("@discount", SqlDbType.Money);
                com.Parameters.Add("@qty", SqlDbType.Int);
                com.Parameters.Add("@notes", SqlDbType.VarChar, 100);
                com.Parameters.Add("@sentto", SqlDbType.VarChar, 100);

                com.Parameters["@id"].Value = id;
                com.Parameters["@invID"].Value = invID;
                com.Parameters["@discount"].Value = discount;
                com.Parameters["@qty"].Value = qty;
                com.Parameters["@notes"].Value = notes;
                com.Parameters["@sentto"].Value = sentto;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.inventoryTableAdapter.Fill(this.adadDatabaseDataSet1.Inventory);
                this.inventoryReportsTableAdapter.Fill(this.adadDatabaseDataSet1.inventoryReports);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(invRIDADD.Text);
            int invID = Convert.ToInt32(invRinvIDADD.Text);
            string discount = invRDiscountADD.Text;
            string qty = invRQtyADD.Text;
            string notes = invRNotesADD.Text;
            string sentto = invRSenttoADD.Text;

            string stmt = "INSERT INTO inventoryReports (id, invID, discount, notes, qty, sentto) VALUES(@id , @invID , @discount, @notes, @qty, @sentto)";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@invID", SqlDbType.Int);
                com.Parameters.Add("@discount", SqlDbType.Money);
                com.Parameters.Add("@qty", SqlDbType.Int);
                com.Parameters.Add("@notes", SqlDbType.VarChar, 100);
                com.Parameters.Add("@sentto", SqlDbType.VarChar, 100);

                com.Parameters["@id"].Value = id;
                com.Parameters["@invID"].Value = invID;
                com.Parameters["@discount"].Value = discount;
                com.Parameters["@qty"].Value = qty;
                com.Parameters["@notes"].Value = notes;
                com.Parameters["@sentto"].Value = sentto;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.inventoryTableAdapter.Fill(this.adadDatabaseDataSet1.Inventory);
                this.inventoryReportsTableAdapter.Fill(this.adadDatabaseDataSet1.inventoryReports);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(wIDADD.Text);
            string Name = wNameADD.Text;
            string Nationality = wNationalityADD.Text;
            string IqamaNo = wIqamaNOADD.Text;
            string IqamaExpiry = wIqamaEXPADD.Text;
            string salary = wSalaryADD.Text;
            string allowances = wallowADD.Text;
            string deduct = wDeductADD.Text;

            string stmt = "INSERT INTO Workers (id, Name, Nationality, IqamaNo, IqamaExpiry, salary, allowances, deduct) VALUES(@id, @Name, @Nationality, @IqamaNo, @IqamaExpiry, @salary, @allowances, @deduct)";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@Name", SqlDbType.VarChar, 100);
                com.Parameters.Add("@Nationality", SqlDbType.VarChar, 100);
                com.Parameters.Add("@IqamaNo", SqlDbType.VarChar, 100);
                com.Parameters.Add("@IqamaExpiry", SqlDbType.VarChar, 100);
                com.Parameters.Add("@salary", SqlDbType.VarChar, 100);
                com.Parameters.Add("@allowances", SqlDbType.VarChar, 100);
                com.Parameters.Add("@deduct", SqlDbType.VarChar, 100);

                com.Parameters["@id"].Value = id;
                com.Parameters["@Name"].Value = Name;
                com.Parameters["@Nationality"].Value = Nationality;
                com.Parameters["@IqamaNo"].Value = IqamaNo;
                com.Parameters["@IqamaExpiry"].Value = IqamaExpiry;
                com.Parameters["@salary"].Value = salary;
                com.Parameters["@allowances"].Value = allowances;
                com.Parameters["@deduct"].Value = deduct;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.workersTableAdapter.Fill(this.adadDatabaseDataSet1.Workers);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox3.Text);
            string Name = nameTextBox.Text;
            string Nationality = nationalityTextBox.Text;
            string IqamaNo = iqamaNoTextBox.Text;
            string IqamaExpiry = iqamaExpiryTextBox.Text;
            string salary = salaryTextBox.Text;
            string allowances = allowancesTextBox.Text;
            string deduct = deductTextBox.Text;

            string stmt = "UPDATE Workers SET Name = @Name, Nationality = @Nationality, IqamaNo = @IqamaNo, IqamaExpiry = @IqamaExpiry, salary = @salary, allowances = @allowances, deduct = @deduct WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@Name", SqlDbType.VarChar, 100);
                com.Parameters.Add("@Nationality", SqlDbType.VarChar, 100);
                com.Parameters.Add("@IqamaNo", SqlDbType.VarChar, 100);
                com.Parameters.Add("@IqamaExpiry", SqlDbType.VarChar, 100);
                com.Parameters.Add("@salary", SqlDbType.VarChar, 100);
                com.Parameters.Add("@allowances", SqlDbType.VarChar, 100);
                com.Parameters.Add("@deduct", SqlDbType.VarChar, 100);

                com.Parameters["@id"].Value = id;
                com.Parameters["@Name"].Value = Name;
                com.Parameters["@Nationality"].Value = Nationality;
                com.Parameters["@IqamaNo"].Value = IqamaNo;
                com.Parameters["@IqamaExpiry"].Value = IqamaExpiry;
                com.Parameters["@salary"].Value = salary;
                com.Parameters["@allowances"].Value = allowances;
                com.Parameters["@deduct"].Value = deduct;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.workersTableAdapter.Fill(this.adadDatabaseDataSet1.Workers);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(pSIDADD.Text);
            int projectID = Convert.ToInt32(pSpIDADD.Text);
            string description = pSDescADD.Text;
            string value = pSValueADD.Text;

            string stmt = "INSERT INTO projectSpent (id, projectID, description, value) VALUES(@id, @projectID, @description, @value)";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@projectID", SqlDbType.Int);
                com.Parameters.Add("@description", SqlDbType.VarChar, 100);
                com.Parameters.Add("@value", SqlDbType.Money);

                com.Parameters["@id"].Value = id;
                com.Parameters["@projectID"].Value = projectID;
                com.Parameters["@description"].Value = description;
                com.Parameters["@value"].Value = value;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.projectReportsTableAdapter.Fill(this.adadDatabaseDataSet1.projectReports);
                this.projectSpentTableAdapter.Fill(this.adadDatabaseDataSet1.projectSpent);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox5.Text);
            int projectID = Convert.ToInt32(projectIDTextBox.Text);
            string description = descriptionTextBox3.Text;
            string value = valueTextBox2.Text;

            string stmt = "UPDATE projectSpent SET projectID = @projectID, description = @description, value = @value WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@projectID", SqlDbType.Int);
                com.Parameters.Add("@description", SqlDbType.VarChar, 100);
                com.Parameters.Add("@value", SqlDbType.Money);

                com.Parameters["@id"].Value = id;
                com.Parameters["@projectID"].Value = projectID;
                com.Parameters["@description"].Value = description;
                com.Parameters["@value"].Value = value;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.projectReportsTableAdapter.Fill(this.adadDatabaseDataSet1.projectReports);
                this.projectSpentTableAdapter.Fill(this.adadDatabaseDataSet1.projectSpent);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(pRIDADD.Text);
            string description = pRDescADD.Text;
            string value = pRValueADD.Text;
            string sentto = pRNotesADD.Text;

            string stmt = "INSERT INTO projectReports (id, description, value, sentto) VALUES(@id, @description, @value, @sentto)";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@description", SqlDbType.VarChar, 100);
                com.Parameters.Add("@value", SqlDbType.Money);
                com.Parameters.Add("@sentto", SqlDbType.VarChar, 100);

                com.Parameters["@id"].Value = id;
                com.Parameters["@description"].Value = description;
                com.Parameters["@value"].Value = value;
                com.Parameters["@sentto"].Value = sentto;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.projectReportsTableAdapter.Fill(this.adadDatabaseDataSet1.projectReports);
                this.projectSpentTableAdapter.Fill(this.adadDatabaseDataSet1.projectSpent);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string description = descriptionTextBox.Text;
            string value = valueTextBox.Text;
            string sentto = senttoTextBox.Text;

            string stmt = "UPDATE projectReports SET description = @description, value = @value, sentto = @sentto WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);
                com.Parameters.Add("@description", SqlDbType.VarChar, 100);
                com.Parameters.Add("@value", SqlDbType.Money);
                com.Parameters.Add("@sentto", SqlDbType.VarChar, 100);

                com.Parameters["@id"].Value = id;
                com.Parameters["@description"].Value = description;
                com.Parameters["@value"].Value = value;
                com.Parameters["@sentto"].Value = sentto;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.projectReportsTableAdapter.Fill(this.adadDatabaseDataSet1.projectReports);
                this.projectSpentTableAdapter.Fill(this.adadDatabaseDataSet1.projectSpent);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void مصروفاتالمشاريعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            this.projectSpentTableAdapter.Fill(this.adadDatabaseDataSet1.projectSpent);
            projectSpentPanel.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox3.Text);

            string stmt = "DELETE FROM Workers WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);

                com.Parameters["@id"].Value = id;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.workersTableAdapter.Fill(this.adadDatabaseDataSet1.Workers);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);

            string stmt = "DELETE FROM projectReports WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);

                com.Parameters["@id"].Value = id;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.projectReportsTableAdapter.Fill(this.adadDatabaseDataSet1.projectReports);
                this.projectSpentTableAdapter.Fill(this.adadDatabaseDataSet1.projectSpent);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox5.Text);

            string stmt = "DELETE FROM projectSpent WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);

                com.Parameters["@id"].Value = id;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.projectReportsTableAdapter.Fill(this.adadDatabaseDataSet1.projectReports);
                this.projectSpentTableAdapter.Fill(this.adadDatabaseDataSet1.projectSpent);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void projectSpentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox1.Text);

            string stmt = "DELETE FROM Inventory WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);

                com.Parameters["@id"].Value = id;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.inventoryTableAdapter.Fill(this.adadDatabaseDataSet1.Inventory);
                this.inventoryReportsTableAdapter.Fill(this.adadDatabaseDataSet1.inventoryReports);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox4.Text);
            int invID = Convert.ToInt32(invIDTextBox.Text);

            string stmt = "DELETE FROM inventoryReports WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);

                com.Parameters["@id"].Value = id;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.inventoryTableAdapter.Fill(this.adadDatabaseDataSet1.Inventory);
                this.inventoryReportsTableAdapter.Fill(this.adadDatabaseDataSet1.inventoryReports);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox2.Text);

            string stmt = "DELETE FROM spentReport WHERE id = @id;";

            try
            {
                string connectionString = Properties.Settings.Default.adadDatabaseConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand com = new SqlCommand(stmt, con);
                com.Parameters.Add("@id", SqlDbType.Int);

                com.Parameters["@id"].Value = id;

                Console.WriteLine(com.ExecuteNonQuery());
                Console.WriteLine("Inserting Data Successfully");
                con.Close();
                this.spentReportTableAdapter.Fill(this.adadDatabaseDataSet1.spentReport);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception Occre while creating table:" + exp.Message + "\t" + exp.GetType());
            }
        }
    }
}
