namespace FacultyEventPlanner
{
    partial class ViolationsRepForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.generateRepBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jobCB = new System.Windows.Forms.ComboBox();
            this.depCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Location = new System.Drawing.Point(2, 67);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(1162, 587);
            this.crv.TabIndex = 1;
            // 
            // generateRepBtn
            // 
            this.generateRepBtn.Location = new System.Drawing.Point(917, 21);
            this.generateRepBtn.Name = "generateRepBtn";
            this.generateRepBtn.Size = new System.Drawing.Size(137, 37);
            this.generateRepBtn.TabIndex = 9;
            this.generateRepBtn.Text = "Generate Report";
            this.generateRepBtn.UseVisualStyleBackColor = true;
            this.generateRepBtn.Click += new System.EventHandler(this.generateRepBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Department";
            // 
            // jobCB
            // 
            this.jobCB.FormattingEnabled = true;
            this.jobCB.Location = new System.Drawing.Point(290, 31);
            this.jobCB.Name = "jobCB";
            this.jobCB.Size = new System.Drawing.Size(229, 24);
            this.jobCB.TabIndex = 12;
            // 
            // depCB
            // 
            this.depCB.FormattingEnabled = true;
            this.depCB.Location = new System.Drawing.Point(641, 31);
            this.depCB.Name = "depCB";
            this.depCB.Size = new System.Drawing.Size(229, 24);
            this.depCB.TabIndex = 13;
            // 
            // ViolationsRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 666);
            this.Controls.Add(this.depCB);
            this.Controls.Add(this.jobCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateRepBtn);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.backBtn);
            this.Name = "ViolationsRepForm";
            this.Text = "ViolationsRepForm";
            this.Load += new System.EventHandler(this.ViolationsRepForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.Button generateRepBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox jobCB;
        private System.Windows.Forms.ComboBox depCB;
    }
}