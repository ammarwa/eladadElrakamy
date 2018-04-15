namespace eladadElrakamy
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.maintoolstrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.تقاريرمشاريعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقاريرالمخزونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المخزونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المصروفاتالعامةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.شؤونالموظفينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرالشاملةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintoolstrip,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2160, 48);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // maintoolstrip
            // 
            this.maintoolstrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.maintoolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تقاريرمشاريعToolStripMenuItem,
            this.تقاريرالمخزونToolStripMenuItem,
            this.المخزونToolStripMenuItem,
            this.المصروفاتالعامةToolStripMenuItem,
            this.شؤونالموظفينToolStripMenuItem,
            this.التقاريرالشاملةToolStripMenuItem});
            this.maintoolstrip.Image = ((System.Drawing.Image)(resources.GetObject("maintoolstrip.Image")));
            this.maintoolstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maintoolstrip.Name = "maintoolstrip";
            this.maintoolstrip.Size = new System.Drawing.Size(149, 45);
            this.maintoolstrip.Text = "الخدمات";
            this.maintoolstrip.Visible = false;
            // 
            // تقاريرمشاريعToolStripMenuItem
            // 
            this.تقاريرمشاريعToolStripMenuItem.Name = "تقاريرمشاريعToolStripMenuItem";
            this.تقاريرمشاريعToolStripMenuItem.Size = new System.Drawing.Size(357, 46);
            this.تقاريرمشاريعToolStripMenuItem.Text = "تقارير مشاريع";
            // 
            // تقاريرالمخزونToolStripMenuItem
            // 
            this.تقاريرالمخزونToolStripMenuItem.Name = "تقاريرالمخزونToolStripMenuItem";
            this.تقاريرالمخزونToolStripMenuItem.Size = new System.Drawing.Size(357, 46);
            this.تقاريرالمخزونToolStripMenuItem.Text = "تقارير المخزون";
            // 
            // المخزونToolStripMenuItem
            // 
            this.المخزونToolStripMenuItem.Name = "المخزونToolStripMenuItem";
            this.المخزونToolStripMenuItem.Size = new System.Drawing.Size(357, 46);
            this.المخزونToolStripMenuItem.Text = "المخزون";
            // 
            // المصروفاتالعامةToolStripMenuItem
            // 
            this.المصروفاتالعامةToolStripMenuItem.Name = "المصروفاتالعامةToolStripMenuItem";
            this.المصروفاتالعامةToolStripMenuItem.Size = new System.Drawing.Size(357, 46);
            this.المصروفاتالعامةToolStripMenuItem.Text = "المصروفات العامة";
            // 
            // شؤونالموظفينToolStripMenuItem
            // 
            this.شؤونالموظفينToolStripMenuItem.Name = "شؤونالموظفينToolStripMenuItem";
            this.شؤونالموظفينToolStripMenuItem.Size = new System.Drawing.Size(357, 46);
            this.شؤونالموظفينToolStripMenuItem.Text = "شؤون الموظفين";
            // 
            // التقاريرالشاملةToolStripMenuItem
            // 
            this.التقاريرالشاملةToolStripMenuItem.Name = "التقاريرالشاملةToolStripMenuItem";
            this.التقاريرالشاملةToolStripMenuItem.Size = new System.Drawing.Size(357, 46);
            this.التقاريرالشاملةToolStripMenuItem.Text = "التقارير الشاملة";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "دخول";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة السر";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(689, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(237, 38);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(689, 511);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(237, 38);
            this.textBox2.TabIndex = 5;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(177, 45);
            this.toolStripButton1.Text = "تسجيل خروج";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2160, 936);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العداد الرقمي";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton maintoolstrip;
        private System.Windows.Forms.ToolStripMenuItem تقاريرمشاريعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تقاريرالمخزونToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المخزونToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المصروفاتالعامةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem شؤونالموظفينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem التقاريرالشاملةToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

