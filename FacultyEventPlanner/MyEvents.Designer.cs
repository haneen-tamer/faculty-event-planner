namespace FacultyEventPlanner
{
    partial class MyEvents
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
            this.label1 = new System.Windows.Forms.Label();
            this.eventsCLB = new System.Windows.Forms.CheckedListBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.Capacity = new System.Windows.Forms.Label();
            this.capTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.depCB = new System.Windows.Forms.ComboBox();
            this.locCB = new System.Windows.Forms.ComboBox();
            this.timeCB = new System.Windows.Forms.ComboBox();
            this.saveEditBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.eventsPanel = new System.Windows.Forms.Panel();
            this.editPanel.SuspendLayout();
            this.eventsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Events";
            // 
            // eventsCLB
            // 
            this.eventsCLB.FormattingEnabled = true;
            this.eventsCLB.Location = new System.Drawing.Point(14, 3);
            this.eventsCLB.Margin = new System.Windows.Forms.Padding(2);
            this.eventsCLB.Name = "eventsCLB";
            this.eventsCLB.Size = new System.Drawing.Size(510, 184);
            this.eventsCLB.TabIndex = 0;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(14, 227);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(141, 46);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(177, 227);
            this.delBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(141, 46);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.cancelBtn);
            this.editPanel.Controls.Add(this.saveEditBtn);
            this.editPanel.Controls.Add(this.timeCB);
            this.editPanel.Controls.Add(this.locCB);
            this.editPanel.Controls.Add(this.depCB);
            this.editPanel.Controls.Add(this.label7);
            this.editPanel.Controls.Add(this.Time);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.capTxt);
            this.editPanel.Controls.Add(this.Capacity);
            this.editPanel.Controls.Add(this.descriptionTxt);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Controls.Add(this.label4);
            this.editPanel.Controls.Add(this.titleTxt);
            this.editPanel.Location = new System.Drawing.Point(0, 3);
            this.editPanel.Margin = new System.Windows.Forms.Padding(2);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(717, 486);
            this.editPanel.TabIndex = 2;
            this.editPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(164, 31);
            this.titleTxt.Margin = new System.Windows.Forms.Padding(2);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.ReadOnly = true;
            this.titleTxt.Size = new System.Drawing.Size(350, 20);
            this.titleTxt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Event Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Description";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(164, 69);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(350, 20);
            this.descriptionTxt.TabIndex = 29;
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(52, 106);
            this.Capacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(48, 13);
            this.Capacity.TabIndex = 30;
            this.Capacity.Text = "Capacity";
            // 
            // capTxt
            // 
            this.capTxt.Location = new System.Drawing.Point(164, 106);
            this.capTxt.Margin = new System.Windows.Forms.Padding(2);
            this.capTxt.Name = "capTxt";
            this.capTxt.Size = new System.Drawing.Size(350, 20);
            this.capTxt.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Location";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(52, 181);
            this.Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 33;
            this.Time.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Department";
            // 
            // depCB
            // 
            this.depCB.FormattingEnabled = true;
            this.depCB.Location = new System.Drawing.Point(164, 227);
            this.depCB.Margin = new System.Windows.Forms.Padding(2);
            this.depCB.Name = "depCB";
            this.depCB.Size = new System.Drawing.Size(350, 21);
            this.depCB.TabIndex = 36;
            // 
            // locCB
            // 
            this.locCB.FormattingEnabled = true;
            this.locCB.Location = new System.Drawing.Point(164, 145);
            this.locCB.Margin = new System.Windows.Forms.Padding(2);
            this.locCB.Name = "locCB";
            this.locCB.Size = new System.Drawing.Size(350, 21);
            this.locCB.TabIndex = 38;
            this.locCB.SelectedIndexChanged += new System.EventHandler(this.locCB_SelectedIndexChanged);
            // 
            // timeCB
            // 
            this.timeCB.FormattingEnabled = true;
            this.timeCB.Location = new System.Drawing.Point(164, 181);
            this.timeCB.Margin = new System.Windows.Forms.Padding(2);
            this.timeCB.Name = "timeCB";
            this.timeCB.Size = new System.Drawing.Size(350, 21);
            this.timeCB.TabIndex = 39;
            this.timeCB.SelectedIndexChanged += new System.EventHandler(this.timeCB_SelectedIndexChanged);
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.Location = new System.Drawing.Point(354, 347);
            this.saveEditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Size = new System.Drawing.Size(160, 47);
            this.saveEditBtn.TabIndex = 40;
            this.saveEditBtn.Text = "save edit and send request";
            this.saveEditBtn.UseVisualStyleBackColor = true;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(164, 347);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 47);
            this.cancelBtn.TabIndex = 41;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // eventsPanel
            // 
            this.eventsPanel.Controls.Add(this.editPanel);
            this.eventsPanel.Controls.Add(this.button1);
            this.eventsPanel.Controls.Add(this.delBtn);
            this.eventsPanel.Controls.Add(this.editBtn);
            this.eventsPanel.Controls.Add(this.eventsCLB);
            this.eventsPanel.Location = new System.Drawing.Point(34, 58);
            this.eventsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(719, 486);
            this.eventsPanel.TabIndex = 1;
            // 
            // MyEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 571);
            this.Controls.Add(this.eventsPanel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MyEvents";
            this.Text = "MyEvents";
            this.Load += new System.EventHandler(this.MyEvents_Load);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.eventsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox eventsCLB;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveEditBtn;
        private System.Windows.Forms.ComboBox timeCB;
        private System.Windows.Forms.ComboBox locCB;
        private System.Windows.Forms.ComboBox depCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capTxt;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Panel eventsPanel;
    }
}