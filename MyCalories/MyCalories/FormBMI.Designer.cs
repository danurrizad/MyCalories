namespace MyCalories
{
    partial class FormBMI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblBMICategory = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(40, 25);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(313, 86);
            this.lblTitle2.TabIndex = 6;
            this.lblTitle2.Text = "Your BMI";
            // 
            // lblBMI
            // 
            this.lblBMI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBMI.AutoSize = true;
            this.lblBMI.BackColor = System.Drawing.Color.Transparent;
            this.lblBMI.Font = new System.Drawing.Font("Segoe UI", 128.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBMI.ForeColor = System.Drawing.Color.Chocolate;
            this.lblBMI.Location = new System.Drawing.Point(215, 93);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(533, 227);
            this.lblBMI.TabIndex = 8;
            this.lblBMI.Text = "20.29";
            this.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMICategory
            // 
            this.lblBMICategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBMICategory.BackColor = System.Drawing.Color.Transparent;
            this.lblBMICategory.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBMICategory.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblBMICategory.Location = new System.Drawing.Point(373, 72);
            this.lblBMICategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBMICategory.Name = "lblBMICategory";
            this.lblBMICategory.Size = new System.Drawing.Size(214, 47);
            this.lblBMICategory.TabIndex = 25;
            this.lblBMICategory.Text = "Overweight";
            this.lblBMICategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAdvice
            // 
            this.lblAdvice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdvice.ForeColor = System.Drawing.Color.Black;
            this.lblAdvice.Location = new System.Drawing.Point(419, 340);
            this.lblAdvice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(121, 25);
            this.lblAdvice.TabIndex = 26;
            this.lblAdvice.Text = "Lorem ipsum";
            this.lblAdvice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.Controls.Add(this.lblAdvice);
            this.pnlData.Controls.Add(this.lblBMICategory);
            this.pnlData.Controls.Add(this.lblBMI);
            this.pnlData.Location = new System.Drawing.Point(57, 134);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(952, 428);
            this.pnlData.TabIndex = 7;
            // 
            // FormBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MyCalories.Properties.Resources.image_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 614);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.lblTitle2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBMI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormBMI_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle2;
        private Label lblBMI;
        private Label lblBMICategory;
        private Label lblAdvice;
        private Panel pnlData;
    }
}