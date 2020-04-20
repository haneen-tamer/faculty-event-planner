namespace FacultyEventPlanner
{
    partial class UserHome
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
            this.createEventBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myViolationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsDGV = new System.Windows.Forms.DataGridView();
            this.depComboBox = new System.Windows.Forms.ComboBox();
            this.depLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // createEventBtn
            // 
            this.createEventBtn.Location = new System.Drawing.Point(632, 49);
<<<<<<< HEAD
            this.createEventBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
            this.createEventBtn.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> f11a395cf0448e35bb7618ef4703be554d9e66d8
            this.createEventBtn.Name = "createEventBtn";
            this.createEventBtn.Size = new System.Drawing.Size(94, 39);
            this.createEventBtn.TabIndex = 0;
            this.createEventBtn.Text = "create event";
            this.createEventBtn.UseVisualStyleBackColor = true;
            this.createEventBtn.Click += new System.EventHandler(this.createEventBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.myEventsToolStripMenuItem,
            this.myRequestsToolStripMenuItem,
            this.myViolationsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
<<<<<<< HEAD
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
=======
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
>>>>>>> f11a395cf0448e35bb7618ef4703be554d9e66d8
            this.myAccountToolStripMenuItem.Text = "My account";
            // 
            // myEventsToolStripMenuItem
            // 
            this.myEventsToolStripMenuItem.Name = "myEventsToolStripMenuItem";
<<<<<<< HEAD
            this.myEventsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
=======
            this.myEventsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
>>>>>>> f11a395cf0448e35bb7618ef4703be554d9e66d8
            this.myEventsToolStripMenuItem.Text = "My events";
            this.myEventsToolStripMenuItem.Click += new System.EventHandler(this.myEventsToolStripMenuItem_Click);
            // 
            // myRequestsToolStripMenuItem
            // 
            this.myRequestsToolStripMenuItem.Name = "myRequestsToolStripMenuItem";
<<<<<<< HEAD
            this.myRequestsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
=======
            this.myRequestsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
>>>>>>> f11a395cf0448e35bb7618ef4703be554d9e66d8
            this.myRequestsToolStripMenuItem.Text = "My requests";
            // 
            // myViolationsToolStripMenuItem
            // 
            this.myViolationsToolStripMenuItem.Name = "myViolationsToolStripMenuItem";
<<<<<<< HEAD
            this.myViolationsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
=======
            this.myViolationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
>>>>>>> f11a395cf0448e35bb7618ef4703be554d9e66d8
            this.myViolationsToolStripMenuItem.Text = "My violations";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // eventsDGV
            // 
            this.eventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDGV.Location = new System.Drawing.Point(9, 221);
<<<<<<< HEAD
            this.eventsDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
            this.eventsDGV.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> f11a395cf0448e35bb7618ef4703be554d9e66d8
            this.eventsDGV.Name = "eventsDGV";
            this.eventsDGV.RowHeadersWidth = 51;
            this.eventsDGV.RowTemplate.Height = 24;
            this.eventsDGV.Size = new System.Drawing.Size(767, 351);
            this.eventsDGV.TabIndex = 2;
            this.eventsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventsDGV_CellContentClick);
            // 
            // depComboBox
            // 
            this.depComboBox.FormattingEnabled = true;
            this.depComboBox.Location = new System.Drawing.Point(535, 184);
<<<<<<< HEAD
            this.depComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
            this.depComboBox.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> f11a395cf0448e35bb7618ef4703be554d9e66d8
            this.depComboBox.Name = "depComboBox";
            this.depComboBox.Size = new System.Drawing.Size(242, 21);
            this.depComboBox.TabIndex = 3;
            this.depComboBox.SelectedIndexChanged += new System.EventHandler(this.depComboBox_SelectedIndexChanged);
            // 
            // depLbl
            // 
            this.depLbl.AutoSize = true;
            this.depLbl.Location = new System.Drawing.Point(416, 184);
            this.depLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depLbl.Name = "depLbl";
            this.depLbl.Size = new System.Drawing.Size(67, 13);
            this.depLbl.TabIndex = 4;
            this.depLbl.Text = "Departments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Events";
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depLbl);
            this.Controls.Add(this.depComboBox);
            this.Controls.Add(this.eventsDGV);
            this.Controls.Add(this.createEventBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
            this.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> f11a395cf0448e35bb7618ef4703be554d9e66d8
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserHome_FormClosed);
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createEventBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myViolationsToolStripMenuItem;
        private System.Windows.Forms.DataGridView eventsDGV;
        private System.Windows.Forms.ComboBox depComboBox;
        private System.Windows.Forms.Label depLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}