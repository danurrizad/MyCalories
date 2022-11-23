namespace MyCalories
{
    partial class FormBMR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBMR));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCaloresperDay = new System.Windows.Forms.Label();
            this.lblBMR = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.lblCaloresperDay);
            this.panel1.Controls.Add(this.lblBMR);
            this.panel1.Location = new System.Drawing.Point(44, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 428);
            this.panel1.TabIndex = 0;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(106, 49);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(765, 60);
            this.lblDesc.TabIndex = 29;
            this.lblDesc.Text = resources.GetString("lblDesc.Text");
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaloresperDay
            // 
            this.lblCaloresperDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaloresperDay.BackColor = System.Drawing.Color.Transparent;
            this.lblCaloresperDay.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaloresperDay.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblCaloresperDay.Location = new System.Drawing.Point(348, 311);
            this.lblCaloresperDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaloresperDay.Name = "lblCaloresperDay";
            this.lblCaloresperDay.Size = new System.Drawing.Size(258, 47);
            this.lblCaloresperDay.TabIndex = 28;
            this.lblCaloresperDay.Text = "Calories/day";
            this.lblCaloresperDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBMR
            // 
            this.lblBMR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBMR.BackColor = System.Drawing.Color.Transparent;
            this.lblBMR.Font = new System.Drawing.Font("Segoe UI", 144F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBMR.ForeColor = System.Drawing.Color.Chocolate;
            this.lblBMR.Location = new System.Drawing.Point(2, 74);
            this.lblBMR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBMR.Name = "lblBMR";
            this.lblBMR.Size = new System.Drawing.Size(976, 254);
            this.lblBMR.TabIndex = 27;
            this.lblBMR.Text = "20.29";
            this.lblBMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(44, 31);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(335, 86);
            this.lblTitle2.TabIndex = 30;
            this.lblTitle2.Text = "Your BMR";
            // 
            // FormBMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MyCalories.Properties.Resources.image_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 614);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormBMR";
            this.Text = "Calculate your Body Mass Ratio here...";
            this.Load += new System.EventHandler(this.FormBMR_Load_1);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblBMR;
        private Label lblDesc;
        private Label lblCaloresperDay;
        private Label lblTitle2;
    }
}