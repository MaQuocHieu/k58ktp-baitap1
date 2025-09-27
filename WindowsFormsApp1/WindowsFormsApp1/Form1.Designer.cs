namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(80, 20);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 20);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(80, 50);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(80, 80);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(80, 120);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(100, 23);
            this.btnPredict.Text = "Du doan";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.Text = "Ket qua...";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Ung dung du doan ngay sinh";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
