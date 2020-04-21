namespace FacultyEventPlanner
{
    partial class EventsByDepForm
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
            this.stLbl = new System.Windows.Forms.Label();
            this.stTxt = new System.Windows.Forms.TextBox();
            this.generateRepBtn = new System.Windows.Forms.Button();
            this.etTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(0, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Location = new System.Drawing.Point(0, 90);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(1517, 653);
            this.crv.TabIndex = 2;
            // 
            // stLbl
            // 
            this.stLbl.AutoSize = true;
            this.stLbl.Location = new System.Drawing.Point(357, 30);
            this.stLbl.Name = "stLbl";
            this.stLbl.Size = new System.Drawing.Size(73, 17);
            this.stLbl.TabIndex = 3;
            this.stLbl.Text = "Start Time";
            // 
            // stTxt
            // 
            this.stTxt.Location = new System.Drawing.Point(450, 30);
            this.stTxt.Name = "stTxt";
            this.stTxt.Size = new System.Drawing.Size(170, 22);
            this.stTxt.TabIndex = 4;
            // 
            // generateRepBtn
            // 
            this.generateRepBtn.Location = new System.Drawing.Point(1159, 30);
            this.generateRepBtn.Name = "generateRepBtn";
            this.generateRepBtn.Size = new System.Drawing.Size(137, 37);
            this.generateRepBtn.TabIndex = 5;
            this.generateRepBtn.Text = "Generate Report";
            this.generateRepBtn.UseVisualStyleBackColor = true;
            this.generateRepBtn.Click += new System.EventHandler(this.generateRepBtn_Click);
            // 
            // etTxt
            // 
            this.etTxt.Location = new System.Drawing.Point(829, 30);
            this.etTxt.Name = "etTxt";
            this.etTxt.Size = new System.Drawing.Size(187, 22);
            this.etTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "End Time";
            // 
            // EventsByDepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 744);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etTxt);
            this.Controls.Add(this.generateRepBtn);
            this.Controls.Add(this.stTxt);
            this.Controls.Add(this.stLbl);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.backBtn);
            this.Name = "EventsByDepForm";
            this.Text = "EventsByDepForm";
            this.Load += new System.EventHandler(this.EventsByDepForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.Label stLbl;
        private System.Windows.Forms.TextBox stTxt;
        private System.Windows.Forms.Button generateRepBtn;
        private System.Windows.Forms.TextBox etTxt;
        private System.Windows.Forms.Label label1;
    }
}