namespace MyCalories
{
    partial class FormHome
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
            this.panelWorkouts = new System.Windows.Forms.Panel();
            this.panelRecentWorkouts = new System.Windows.Forms.Panel();
            this.lblWorkoutCals = new System.Windows.Forms.Label();
            this.lblRecentWorkout = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWorkoutToday = new System.Windows.Forms.Label();
            this.panelGoals = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGoals = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGoalsRemain = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.linkLabelGoals = new System.Windows.Forms.LinkLabel();
            this.panelWorkouts.SuspendLayout();
            this.panelRecentWorkouts.SuspendLayout();
            this.panelGoals.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWorkouts
            // 
            this.panelWorkouts.AutoSize = true;
            this.panelWorkouts.BackColor = System.Drawing.Color.White;
            this.panelWorkouts.Controls.Add(this.panelRecentWorkouts);
            this.panelWorkouts.Controls.Add(this.label10);
            this.panelWorkouts.Controls.Add(this.label9);
            this.panelWorkouts.Controls.Add(this.lblWorkoutToday);
            this.panelWorkouts.Location = new System.Drawing.Point(733, 460);
            this.panelWorkouts.Name = "panelWorkouts";
            this.panelWorkouts.Size = new System.Drawing.Size(483, 383);
            this.panelWorkouts.TabIndex = 15;
            // 
            // panelRecentWorkouts
            // 
            this.panelRecentWorkouts.Controls.Add(this.lblWorkoutCals);
            this.panelRecentWorkouts.Controls.Add(this.lblRecentWorkout);
            this.panelRecentWorkouts.Location = new System.Drawing.Point(33, 240);
            this.panelRecentWorkouts.Name = "panelRecentWorkouts";
            this.panelRecentWorkouts.Size = new System.Drawing.Size(423, 103);
            this.panelRecentWorkouts.TabIndex = 6;
            // 
            // lblWorkoutCals
            // 
            this.lblWorkoutCals.AutoSize = true;
            this.lblWorkoutCals.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkoutCals.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWorkoutCals.Image = global::MyCalories.Properties.Resources.cals;
            this.lblWorkoutCals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWorkoutCals.Location = new System.Drawing.Point(27, 45);
            this.lblWorkoutCals.Name = "lblWorkoutCals";
            this.lblWorkoutCals.Size = new System.Drawing.Size(118, 27);
            this.lblWorkoutCals.TabIndex = 9;
            this.lblWorkoutCals.Text = "     12 cals";
            this.lblWorkoutCals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecentWorkout
            // 
            this.lblRecentWorkout.AutoSize = true;
            this.lblRecentWorkout.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentWorkout.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecentWorkout.Location = new System.Drawing.Point(24, 16);
            this.lblRecentWorkout.Name = "lblRecentWorkout";
            this.lblRecentWorkout.Size = new System.Drawing.Size(142, 29);
            this.lblRecentWorkout.TabIndex = 8;
            this.lblRecentWorkout.Text = "Sit-up (15x)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(56, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "Recent workout(s)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(51, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 33);
            this.label9.TabIndex = 5;
            this.label9.Text = "Workout(s) today";
            // 
            // lblWorkoutToday
            // 
            this.lblWorkoutToday.AutoSize = true;
            this.lblWorkoutToday.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkoutToday.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWorkoutToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(116)))), ((int)(((byte)(37)))));
            this.lblWorkoutToday.Location = new System.Drawing.Point(32, 27);
            this.lblWorkoutToday.Name = "lblWorkoutToday";
            this.lblWorkoutToday.Size = new System.Drawing.Size(103, 117);
            this.lblWorkoutToday.TabIndex = 4;
            this.lblWorkoutToday.Text = "0";
            // 
            // panelGoals
            // 
            this.panelGoals.AutoSize = true;
            this.panelGoals.BackColor = System.Drawing.Color.White;
            this.panelGoals.Controls.Add(this.label8);
            this.panelGoals.Controls.Add(this.lblGoals);
            this.panelGoals.Controls.Add(this.label7);
            this.panelGoals.Controls.Add(this.lblGoalsRemain);
            this.panelGoals.Controls.Add(this.label5);
            this.panelGoals.Controls.Add(this.label2);
            this.panelGoals.Controls.Add(this.label1);
            this.panelGoals.Location = new System.Drawing.Point(141, 460);
            this.panelGoals.MaximumSize = new System.Drawing.Size(930, 766);
            this.panelGoals.Name = "panelGoals";
            this.panelGoals.Size = new System.Drawing.Size(483, 383);
            this.panelGoals.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(116)))), ((int)(((byte)(37)))));
            this.label8.Location = new System.Drawing.Point(231, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 50);
            this.label8.TabIndex = 7;
            this.label8.Text = "cals";
            // 
            // lblGoals
            // 
            this.lblGoals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoals.AutoSize = true;
            this.lblGoals.BackColor = System.Drawing.Color.Transparent;
            this.lblGoals.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGoals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(116)))), ((int)(((byte)(37)))));
            this.lblGoals.Location = new System.Drawing.Point(212, 307);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(119, 29);
            this.lblGoals.TabIndex = 5;
            this.lblGoals.Text = "1892 cals";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(415, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "Remaining = Goal - Food + Exercise";
            // 
            // lblGoalsRemain
            // 
            this.lblGoalsRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoalsRemain.AutoSize = true;
            this.lblGoalsRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblGoalsRemain.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGoalsRemain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(116)))), ((int)(((byte)(37)))));
            this.lblGoalsRemain.Location = new System.Drawing.Point(3, 52);
            this.lblGoalsRemain.Name = "lblGoalsRemain";
            this.lblGoalsRemain.Size = new System.Drawing.Size(262, 117);
            this.lblGoalsRemain.TabIndex = 3;
            this.lblGoalsRemain.Text = "1892";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Your goals is";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remaining";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your goals is";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(129, 143);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(608, 117);
            this.lblTitle2.TabIndex = 11;
            this.lblTitle2.Text = "MyCalories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(150, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Want to trace your daily calories?";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(141, 78);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(438, 59);
            this.lblTitle1.TabIndex = 10;
            this.lblTitle1.Text = "Welcome Back to";
            // 
            // linkLabelGoals
            // 
            this.linkLabelGoals.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.linkLabelGoals.AutoSize = true;
            this.linkLabelGoals.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelGoals.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGoals.LinkColor = System.Drawing.Color.White;
            this.linkLabelGoals.Location = new System.Drawing.Point(588, 289);
            this.linkLabelGoals.Name = "linkLabelGoals";
            this.linkLabelGoals.Size = new System.Drawing.Size(257, 32);
            this.linkLabelGoals.TabIndex = 13;
            this.linkLabelGoals.TabStop = true;
            this.linkLabelGoals.Text = "Set your goals here";
            this.linkLabelGoals.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoals_LinkClicked);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyCalories.Properties.Resources.image_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1533, 1024);
            this.Controls.Add(this.panelWorkouts);
            this.Controls.Add(this.panelGoals);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.linkLabelGoals);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panelWorkouts.ResumeLayout(false);
            this.panelWorkouts.PerformLayout();
            this.panelRecentWorkouts.ResumeLayout(false);
            this.panelRecentWorkouts.PerformLayout();
            this.panelGoals.ResumeLayout(false);
            this.panelGoals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelWorkouts;
        private Panel panelRecentWorkouts;
        private Label lblWorkoutCals;
        private Label lblRecentWorkout;
        private Label label10;
        private Label label9;
        private Label lblWorkoutToday;
        private Panel panelGoals;
        private Label label8;
        private Label lblGoals;
        private Label label7;
        private Label lblGoalsRemain;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label lblTitle2;
        private Label label3;
        private Label lblTitle1;
        private LinkLabel linkLabelGoals;
    }
}