﻿namespace FacultyEventPlanner
{
    partial class AdminHome
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
            this.Add_Member_button = new System.Windows.Forms.Button();
            this.View_E_Button = new System.Windows.Forms.Button();
            this.View_V_Button = new System.Windows.Forms.Button();
            this.View_Jobs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title_ev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_ev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request_Statue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ls_start_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ls_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combo_Box_of_DEP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsByDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.violationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Member_button
            // 
            this.Add_Member_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_Member_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Member_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Member_button.Location = new System.Drawing.Point(108, 62);
            this.Add_Member_button.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Member_button.Name = "Add_Member_button";
            this.Add_Member_button.Size = new System.Drawing.Size(117, 52);
            this.Add_Member_button.TabIndex = 0;
            this.Add_Member_button.Text = "Add Member";
            this.Add_Member_button.UseVisualStyleBackColor = false;
            this.Add_Member_button.Click += new System.EventHandler(this.Add_Member_button_Click);
            // 
            // View_E_Button
            // 
            this.View_E_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.View_E_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_E_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.View_E_Button.Location = new System.Drawing.Point(413, 62);
            this.View_E_Button.Margin = new System.Windows.Forms.Padding(4);
            this.View_E_Button.Name = "View_E_Button";
            this.View_E_Button.Size = new System.Drawing.Size(134, 53);
            this.View_E_Button.TabIndex = 1;
            this.View_E_Button.Text = "View Event Request";
            this.View_E_Button.UseVisualStyleBackColor = false;
            this.View_E_Button.Click += new System.EventHandler(this.View_E_Button_Click);
            // 
            // View_V_Button
            // 
            this.View_V_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.View_V_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_V_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.View_V_Button.Location = new System.Drawing.Point(763, 62);
            this.View_V_Button.Margin = new System.Windows.Forms.Padding(4);
            this.View_V_Button.Name = "View_V_Button";
            this.View_V_Button.Size = new System.Drawing.Size(127, 52);
            this.View_V_Button.TabIndex = 2;
            this.View_V_Button.Text = "View Violations";
            this.View_V_Button.UseVisualStyleBackColor = false;
            this.View_V_Button.Click += new System.EventHandler(this.View_V_Button_Click);
            // 
            // View_Jobs
            // 
            this.View_Jobs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.View_Jobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Jobs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.View_Jobs.Location = new System.Drawing.Point(1072, 70);
            this.View_Jobs.Margin = new System.Windows.Forms.Padding(4);
            this.View_Jobs.Name = "View_Jobs";
            this.View_Jobs.Size = new System.Drawing.Size(116, 52);
            this.View_Jobs.TabIndex = 3;
            this.View_Jobs.Text = "View Jobs";
            this.View_Jobs.UseVisualStyleBackColor = false;
            this.View_Jobs.Click += new System.EventHandler(this.View_Jobs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title_ev,
            this.Description_ev,
            this.Capacity,
            this.Request_Statue,
            this.Ls_start_Time,
            this.Ls_Date,
            this.L_name});
            this.dataGridView1.Location = new System.Drawing.Point(36, 260);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(939, 298);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title_ev
            // 
            this.Title_ev.HeaderText = "Title";
            this.Title_ev.MinimumWidth = 6;
            this.Title_ev.Name = "Title_ev";
            this.Title_ev.ReadOnly = true;
            this.Title_ev.Width = 125;
            // 
            // Description_ev
            // 
            this.Description_ev.HeaderText = "Description";
            this.Description_ev.MinimumWidth = 6;
            this.Description_ev.Name = "Description_ev";
            this.Description_ev.ReadOnly = true;
            this.Description_ev.Width = 125;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capaicty";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Width = 125;
            // 
            // Request_Statue
            // 
            this.Request_Statue.HeaderText = "Request Statue";
            this.Request_Statue.MinimumWidth = 6;
            this.Request_Statue.Name = "Request_Statue";
            this.Request_Statue.ReadOnly = true;
            this.Request_Statue.Width = 125;
            // 
            // Ls_start_Time
            // 
            this.Ls_start_Time.HeaderText = "Start Time";
            this.Ls_start_Time.MinimumWidth = 6;
            this.Ls_start_Time.Name = "Ls_start_Time";
            this.Ls_start_Time.ReadOnly = true;
            this.Ls_start_Time.Width = 125;
            // 
            // Ls_Date
            // 
            this.Ls_Date.HeaderText = " Date";
            this.Ls_Date.MinimumWidth = 6;
            this.Ls_Date.Name = "Ls_Date";
            this.Ls_Date.ReadOnly = true;
            this.Ls_Date.Width = 125;
            // 
            // L_name
            // 
            this.L_name.HeaderText = "Location Name";
            this.L_name.MinimumWidth = 6;
            this.L_name.Name = "L_name";
            this.L_name.ReadOnly = true;
            this.L_name.Width = 125;
            // 
            // Combo_Box_of_DEP
            // 
            this.Combo_Box_of_DEP.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Combo_Box_of_DEP.FormattingEnabled = true;
            this.Combo_Box_of_DEP.Location = new System.Drawing.Point(763, 214);
            this.Combo_Box_of_DEP.Margin = new System.Windows.Forms.Padding(4);
            this.Combo_Box_of_DEP.Name = "Combo_Box_of_DEP";
            this.Combo_Box_of_DEP.Size = new System.Drawing.Size(208, 21);
            this.Combo_Box_of_DEP.TabIndex = 5;
            this.Combo_Box_of_DEP.SelectedIndexChanged += new System.EventHandler(this.Combo_Box_of_DEP_SelectedIndexChanged);
            this.Combo_Box_of_DEP.MouseLeave += new System.EventHandler(this.Combo_Box_of_DEP_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Departments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.viewJobsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsByDepartmentsToolStripMenuItem,
            this.violationsToolStripMenuItem,
            this.locationsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // eventsByDepartmentsToolStripMenuItem
            // 
            this.eventsByDepartmentsToolStripMenuItem.Name = "eventsByDepartmentsToolStripMenuItem";
            this.eventsByDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.eventsByDepartmentsToolStripMenuItem.Text = "EventsByDepartments";
            this.eventsByDepartmentsToolStripMenuItem.Click += new System.EventHandler(this.eventsByDepartmentsToolStripMenuItem_Click);
            // 
            // violationsToolStripMenuItem
            // 
            this.violationsToolStripMenuItem.Name = "violationsToolStripMenuItem";
            this.violationsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.violationsToolStripMenuItem.Text = "Violations";
            this.violationsToolStripMenuItem.Click += new System.EventHandler(this.violationsToolStripMenuItem_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.locationsToolStripMenuItem.Text = "Locations";
            this.locationsToolStripMenuItem.Click += new System.EventHandler(this.locationsToolStripMenuItem_Click);
            // 
            // viewJobsToolStripMenuItem
            // 
            this.viewJobsToolStripMenuItem.Name = "viewJobsToolStripMenuItem";
            this.viewJobsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewJobsToolStripMenuItem.Text = "View Jobs";
            this.viewJobsToolStripMenuItem.Click += new System.EventHandler(this.viewJobsToolStripMenuItem_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Combo_Box_of_DEP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.View_Jobs);
            this.Controls.Add(this.View_V_Button);
            this.Controls.Add(this.View_E_Button);
            this.Controls.Add(this.Add_Member_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_home);
            this.Load += new System.EventHandler(this.AdminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Member_button;
        private System.Windows.Forms.Button View_E_Button;
        private System.Windows.Forms.Button View_V_Button;
        private System.Windows.Forms.Button View_Jobs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Combo_Box_of_DEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title_ev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_ev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request_Statue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ls_start_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ls_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn L_name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsByDepartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem violationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewJobsToolStripMenuItem;
    }
}