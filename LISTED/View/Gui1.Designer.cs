namespace Test_LISTED
{
    partial class Gui1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLable = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 59);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(344, 20);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(963, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(963, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open Calendar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(268, 184);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 388);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(963, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelLeft.Controls.Add(this.pnlNav);
            this.panelLeft.Controls.Add(this.btnCal);
            this.panelLeft.Controls.Add(this.btnAlarm);
            this.panelLeft.Controls.Add(this.btnTodo);
            this.panelLeft.Controls.Add(this.btnLogOut);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(186, 666);
            this.panelLeft.TabIndex = 5;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 2;
            // 
            // btnCal
            // 
            this.btnCal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCal.FlatAppearance.BorderSize = 0;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCal.ForeColor = System.Drawing.Color.Green;
            this.btnCal.Image = global::LISTED.Properties.Resources.calendar;
            this.btnCal.Location = new System.Drawing.Point(0, 340);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(186, 50);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "Calendar";
            this.btnCal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCal.UseVisualStyleBackColor = true;
            // 
            // btnAlarm
            // 
            this.btnAlarm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlarm.FlatAppearance.BorderSize = 0;
            this.btnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarm.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlarm.ForeColor = System.Drawing.Color.Green;
            this.btnAlarm.Image = global::LISTED.Properties.Resources.alarm_clock;
            this.btnAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlarm.Location = new System.Drawing.Point(0, 290);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(186, 50);
            this.btnAlarm.TabIndex = 1;
            this.btnAlarm.Text = "Alarm Clock";
            this.btnAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlarm.UseVisualStyleBackColor = true;
            // 
            // btnTodo
            // 
            this.btnTodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTodo.FlatAppearance.BorderSize = 0;
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTodo.ForeColor = System.Drawing.Color.Green;
            this.btnTodo.Image = global::LISTED.Properties.Resources.clipboard;
            this.btnTodo.Location = new System.Drawing.Point(0, 240);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(186, 50);
            this.btnTodo.TabIndex = 1;
            this.btnTodo.Text = "To Do!";
            this.btnTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTodo.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.Green;
            this.btnLogOut.Image = global::LISTED.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(0, 606);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(186, 60);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log out!";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Green;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 190);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userLable);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 190);
            this.panel1.TabIndex = 0;
            // 
            // userLable
            // 
            this.userLable.AutoSize = true;
            this.userLable.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLable.Location = new System.Drawing.Point(54, 119);
            this.userLable.Name = "userLable";
            this.userLable.Size = new System.Drawing.Size(74, 15);
            this.userLable.TabIndex = 1;
            this.userLable.Text = "User Name";
            this.userLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LISTED.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(54, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::LISTED.Properties.Resources.apple_touch_icon;
            this.logo.Location = new System.Drawing.Point(897, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(180, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Gui1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1076, 666);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gui1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTED";
            this.Load += new System.EventHandler(this.Gui1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label userLable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlNav;
    }
}

