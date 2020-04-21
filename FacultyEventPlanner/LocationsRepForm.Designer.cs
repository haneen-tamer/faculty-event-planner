namespace FacultyEventPlanner
{
    partial class LocationsRepForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.CapTxt = new System.Windows.Forms.TextBox();
            this.generateRepBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Location = new System.Drawing.Point(12, 81);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(1062, 555);
            this.crv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Event Capacity";
            // 
            // CapTxt
            // 
            this.CapTxt.Location = new System.Drawing.Point(465, 30);
            this.CapTxt.Name = "CapTxt";
            this.CapTxt.Size = new System.Drawing.Size(187, 22);
            this.CapTxt.TabIndex = 9;
            // 
            // generateRepBtn
            // 
            this.generateRepBtn.Location = new System.Drawing.Point(795, 30);
            this.generateRepBtn.Name = "generateRepBtn";
            this.generateRepBtn.Size = new System.Drawing.Size(137, 37);
            this.generateRepBtn.TabIndex = 8;
            this.generateRepBtn.Text = "Generate Report";
            this.generateRepBtn.UseVisualStyleBackColor = true;
            this.generateRepBtn.Click += new System.EventHandler(this.generateRepBtn_Click);
            // 
            // LocationsRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CapTxt);
            this.Controls.Add(this.generateRepBtn);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.backButton);
            this.Name = "LocationsRepForm";
            this.Text = "LocationsRepForm";
            this.Load += new System.EventHandler(this.LocationsRepForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CapTxt;
        private System.Windows.Forms.Button generateRepBtn;
    }
}