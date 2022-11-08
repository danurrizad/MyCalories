namespace MyCalories
{
    partial class FormDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelNutriFact = new System.Windows.Forms.Panel();
            this.btnNutriFact = new System.Windows.Forms.Button();
            this.panelFoodEnConv = new System.Windows.Forms.Panel();
            this.btnFoodEnConv = new System.Windows.Forms.Button();
            this.panelBMR = new System.Windows.Forms.Panel();
            this.btnBMR = new System.Windows.Forms.Button();
            this.panelBMI = new System.Windows.Forms.Panel();
            this.btnBMI = new System.Windows.Forms.Button();
            this.panelDailyRecords = new System.Windows.Forms.Panel();
            this.btnDailyRecords = new System.Windows.Forms.Button();
            this.lblNamaUser = new System.Windows.Forms.Label();
            this.lblHalo = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelNutriFact.SuspendLayout();
            this.panelFoodEnConv.SuspendLayout();
            this.panelBMR.SuspendLayout();
            this.panelBMI.SuspendLayout();
            this.panelDailyRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogo);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.panelNutriFact);
            this.panel1.Controls.Add(this.panelFoodEnConv);
            this.panel1.Controls.Add(this.panelBMR);
            this.panel1.Controls.Add(this.panelBMI);
            this.panel1.Controls.Add(this.panelDailyRecords);
            this.panel1.Controls.Add(this.lblNamaUser);
            this.panel1.Controls.Add(this.lblHalo);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 1024);
            this.panel1.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Image = global::MyCalories.Properties.Resources.logo1;
            this.btnLogo.Location = new System.Drawing.Point(11, 19);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(83, 86);
            this.btnLogo.TabIndex = 15;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::MyCalories.Properties.Resources.logout;
            this.pictureBox7.Location = new System.Drawing.Point(37, 942);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 49);
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(89, 942);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 49);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelNutriFact
            // 
            this.panelNutriFact.Controls.Add(this.btnNutriFact);
            this.panelNutriFact.Location = new System.Drawing.Point(24, 665);
            this.panelNutriFact.Name = "panelNutriFact";
            this.panelNutriFact.Size = new System.Drawing.Size(321, 66);
            this.panelNutriFact.TabIndex = 11;
            // 
            // btnNutriFact
            // 
            this.btnNutriFact.BackColor = System.Drawing.Color.Transparent;
            this.btnNutriFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNutriFact.FlatAppearance.BorderSize = 0;
            this.btnNutriFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNutriFact.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNutriFact.Image = global::MyCalories.Properties.Resources.nutricion;
            this.btnNutriFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNutriFact.Location = new System.Drawing.Point(13, 3);
            this.btnNutriFact.Name = "btnNutriFact";
            this.btnNutriFact.Size = new System.Drawing.Size(290, 60);
            this.btnNutriFact.TabIndex = 7;
            this.btnNutriFact.Text = "Nutricion Facts List";
            this.btnNutriFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNutriFact.UseVisualStyleBackColor = false;
            this.btnNutriFact.Click += new System.EventHandler(this.btnNutriFact_Click);
            // 
            // panelFoodEnConv
            // 
            this.panelFoodEnConv.Controls.Add(this.btnFoodEnConv);
            this.panelFoodEnConv.Location = new System.Drawing.Point(24, 544);
            this.panelFoodEnConv.Name = "panelFoodEnConv";
            this.panelFoodEnConv.Size = new System.Drawing.Size(321, 73);
            this.panelFoodEnConv.TabIndex = 10;
            // 
            // btnFoodEnConv
            // 
            this.btnFoodEnConv.BackColor = System.Drawing.Color.Transparent;
            this.btnFoodEnConv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodEnConv.FlatAppearance.BorderSize = 0;
            this.btnFoodEnConv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodEnConv.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFoodEnConv.Image = global::MyCalories.Properties.Resources.calculate;
            this.btnFoodEnConv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodEnConv.Location = new System.Drawing.Point(13, 3);
            this.btnFoodEnConv.Name = "btnFoodEnConv";
            this.btnFoodEnConv.Size = new System.Drawing.Size(278, 67);
            this.btnFoodEnConv.TabIndex = 6;
            this.btnFoodEnConv.Text = "Food Energy Converter";
            this.btnFoodEnConv.UseVisualStyleBackColor = false;
            this.btnFoodEnConv.Click += new System.EventHandler(this.btnFoodEnConv_Click);
            // 
            // panelBMR
            // 
            this.panelBMR.Controls.Add(this.btnBMR);
            this.panelBMR.Location = new System.Drawing.Point(24, 426);
            this.panelBMR.Name = "panelBMR";
            this.panelBMR.Size = new System.Drawing.Size(321, 66);
            this.panelBMR.TabIndex = 9;
            // 
            // btnBMR
            // 
            this.btnBMR.BackColor = System.Drawing.Color.Transparent;
            this.btnBMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBMR.FlatAppearance.BorderSize = 0;
            this.btnBMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBMR.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBMR.Image = global::MyCalories.Properties.Resources.calculate;
            this.btnBMR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBMR.Location = new System.Drawing.Point(13, 3);
            this.btnBMR.Name = "btnBMR";
            this.btnBMR.Size = new System.Drawing.Size(290, 60);
            this.btnBMR.TabIndex = 5;
            this.btnBMR.Text = "Calculate BMR";
            this.btnBMR.UseVisualStyleBackColor = false;
            this.btnBMR.Click += new System.EventHandler(this.btnBMR_Click);
            // 
            // panelBMI
            // 
            this.panelBMI.Controls.Add(this.btnBMI);
            this.panelBMI.Location = new System.Drawing.Point(24, 307);
            this.panelBMI.Name = "panelBMI";
            this.panelBMI.Size = new System.Drawing.Size(321, 66);
            this.panelBMI.TabIndex = 9;
            // 
            // btnBMI
            // 
            this.btnBMI.BackColor = System.Drawing.Color.Transparent;
            this.btnBMI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBMI.FlatAppearance.BorderSize = 0;
            this.btnBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBMI.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBMI.Image = global::MyCalories.Properties.Resources.calculate2;
            this.btnBMI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBMI.Location = new System.Drawing.Point(13, 3);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(290, 60);
            this.btnBMI.TabIndex = 4;
            this.btnBMI.Text = "Calculate BMI";
            this.btnBMI.UseVisualStyleBackColor = false;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // panelDailyRecords
            // 
            this.panelDailyRecords.Controls.Add(this.btnDailyRecords);
            this.panelDailyRecords.Location = new System.Drawing.Point(24, 188);
            this.panelDailyRecords.Name = "panelDailyRecords";
            this.panelDailyRecords.Size = new System.Drawing.Size(321, 66);
            this.panelDailyRecords.TabIndex = 8;
            // 
            // btnDailyRecords
            // 
            this.btnDailyRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnDailyRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailyRecords.FlatAppearance.BorderSize = 0;
            this.btnDailyRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyRecords.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDailyRecords.Image = global::MyCalories.Properties.Resources.dailyrecord;
            this.btnDailyRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailyRecords.Location = new System.Drawing.Point(13, 3);
            this.btnDailyRecords.Name = "btnDailyRecords";
            this.btnDailyRecords.Size = new System.Drawing.Size(290, 60);
            this.btnDailyRecords.TabIndex = 3;
            this.btnDailyRecords.Text = "Daily Records";
            this.btnDailyRecords.UseVisualStyleBackColor = false;
            this.btnDailyRecords.Click += new System.EventHandler(this.btnDailyRecords_Click);
            // 
            // lblNamaUser
            // 
            this.lblNamaUser.AutoSize = true;
            this.lblNamaUser.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNamaUser.Location = new System.Drawing.Point(167, 47);
            this.lblNamaUser.Name = "lblNamaUser";
            this.lblNamaUser.Size = new System.Drawing.Size(170, 29);
            this.lblNamaUser.TabIndex = 2;
            this.lblNamaUser.Text = "<nama user>";
            // 
            // lblHalo
            // 
            this.lblHalo.AutoSize = true;
            this.lblHalo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHalo.Location = new System.Drawing.Point(98, 47);
            this.lblHalo.Name = "lblHalo";
            this.lblHalo.Size = new System.Drawing.Size(70, 27);
            this.lblHalo.TabIndex = 1;
            this.lblHalo.Text = "Halo,";
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormLoader.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormLoader.BackgroundImage = global::MyCalories.Properties.Resources.image_2;
            this.pnlFormLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFormLoader.Location = new System.Drawing.Point(367, -1);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1533, 1024);
            this.pnlFormLoader.TabIndex = 5;
            // 
            // FormHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyCalories.Properties.Resources.image_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFormLoader);
            this.DoubleBuffered = true;
            this.Name = "FormHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHomepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelNutriFact.ResumeLayout(false);
            this.panelFoodEnConv.ResumeLayout(false);
            this.panelBMR.ResumeLayout(false);
            this.panelBMI.ResumeLayout(false);
            this.panelDailyRecords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblHalo;
        private Button btnNutriFact;
        private Button btnFoodEnConv;
        private Button btnBMR;
        private Button btnBMI;
        private Button btnDailyRecords;
        private Label lblNamaUser;
        private Panel panelDailyRecords;
        private Panel panelBMI;
        private Panel panelBMR;
        private Panel panelNutriFact;
        private Panel panelFoodEnConv;
        private PictureBox pictureBox7;
        private Button btnLogout;
        private Panel pnlFormLoader;
        private Button btnLogo;
    }
}