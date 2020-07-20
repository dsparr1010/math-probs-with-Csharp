namespace MathProblemsExercise
{
    partial class FrmMathProblems
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
            this.BtnFindVol1 = new System.Windows.Forms.Button();
            this.BtnSellingPrice = new System.Windows.Forms.Button();
            this.BtnEmpPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFindVol1
            // 
            this.BtnFindVol1.Location = new System.Drawing.Point(55, 49);
            this.BtnFindVol1.Name = "BtnFindVol1";
            this.BtnFindVol1.Size = new System.Drawing.Size(163, 42);
            this.BtnFindVol1.TabIndex = 0;
            this.BtnFindVol1.Text = "Find Volume";
            this.BtnFindVol1.UseVisualStyleBackColor = true;
            this.BtnFindVol1.Click += new System.EventHandler(this.BtnFindVol1_Click);
            // 
            // BtnSellingPrice
            // 
            this.BtnSellingPrice.Location = new System.Drawing.Point(55, 133);
            this.BtnSellingPrice.Name = "BtnSellingPrice";
            this.BtnSellingPrice.Size = new System.Drawing.Size(163, 43);
            this.BtnSellingPrice.TabIndex = 1;
            this.BtnSellingPrice.Text = "Determine Selling Price Markup";
            this.BtnSellingPrice.UseVisualStyleBackColor = true;
            this.BtnSellingPrice.Click += new System.EventHandler(this.BtnSellingPrice_Click);
            // 
            // BtnEmpPay
            // 
            this.BtnEmpPay.Location = new System.Drawing.Point(55, 223);
            this.BtnEmpPay.Name = "BtnEmpPay";
            this.BtnEmpPay.Size = new System.Drawing.Size(163, 43);
            this.BtnEmpPay.TabIndex = 2;
            this.BtnEmpPay.Text = "Find Employee\'s Pay";
            this.BtnEmpPay.UseVisualStyleBackColor = true;
            this.BtnEmpPay.Click += new System.EventHandler(this.BtnEmpPay_Click);
            // 
            // FrmMathProblems
            // 
            this.ClientSize = new System.Drawing.Size(747, 468);
            this.Controls.Add(this.BtnEmpPay);
            this.Controls.Add(this.BtnSellingPrice);
            this.Controls.Add(this.BtnFindVol1);
            this.Name = "FrmMathProblems";
            this.Text = "Solving Math Problems with C#";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFindVol;
        private System.Windows.Forms.Button BtnFindVol1;
        private System.Windows.Forms.Button BtnSellingPrice;
        private System.Windows.Forms.Button BtnEmpPay;
    }
}

