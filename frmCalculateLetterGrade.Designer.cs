namespace CalculateLetterGrade
{
    partial class frmCalculateLetterGrade
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
            this.txtNumericGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.btnCalculateLetterGrade = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeric Grade";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumericGrade
            // 
            this.txtNumericGrade.Location = new System.Drawing.Point(209, 63);
            this.txtNumericGrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumericGrade.Name = "txtNumericGrade";
            this.txtNumericGrade.Size = new System.Drawing.Size(68, 20);
            this.txtNumericGrade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Letter Grade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetterGrade.Location = new System.Drawing.Point(209, 108);
            this.lblLetterGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(68, 20);
            this.lblLetterGrade.TabIndex = 3;
            // 
            // btnCalculateLetterGrade
            // 
            this.btnCalculateLetterGrade.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculateLetterGrade.Location = new System.Drawing.Point(75, 159);
            this.btnCalculateLetterGrade.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateLetterGrade.Name = "btnCalculateLetterGrade";
            this.btnCalculateLetterGrade.Size = new System.Drawing.Size(75, 60);
            this.btnCalculateLetterGrade.TabIndex = 2;
            this.btnCalculateLetterGrade.Text = "&Calculate Letter Grade";
            this.btnCalculateLetterGrade.UseVisualStyleBackColor = true;
            this.btnCalculateLetterGrade.Click += new System.EventHandler(this.btnCalculateLetterGrade_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(202, 159);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCalculateLetterGrade
            // 
            this.AcceptButton = this.btnCalculateLetterGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(351, 292);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateLetterGrade);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumericGrade);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCalculateLetterGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumericGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLetterGrade;
        private System.Windows.Forms.Button btnCalculateLetterGrade;
        private System.Windows.Forms.Button btnExit;
    }
}

