namespace MyCalories
{
    partial class FormExercise
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
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pnlType = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDuration = new System.Windows.Forms.Panel();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBurnedCalories = new System.Windows.Forms.Panel();
            this.tbBurnedCalories = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.pnlNama = new System.Windows.Forms.Panel();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panelForm.SuspendLayout();
            this.pnlType.SuspendLayout();
            this.pnlDuration.SuspendLayout();
            this.pnlBurnedCalories.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.pnlNama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(50, 29);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(161, 50);
            this.lblTitle2.TabIndex = 7;
            this.lblTitle2.Text = "Exercise";
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelForm.Controls.Add(this.pnlType);
            this.panelForm.Controls.Add(this.pnlDuration);
            this.panelForm.Controls.Add(this.pnlBurnedCalories);
            this.panelForm.Controls.Add(this.pnlDescription);
            this.panelForm.Controls.Add(this.pnlNama);
            this.panelForm.Controls.Add(this.btnClear);
            this.panelForm.Controls.Add(this.btnAddExercise);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Location = new System.Drawing.Point(660, -4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(415, 639);
            this.panelForm.TabIndex = 8;
            // 
            // pnlType
            // 
            this.pnlType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlType.Controls.Add(this.cbType);
            this.pnlType.Controls.Add(this.label5);
            this.pnlType.Location = new System.Drawing.Point(32, 424);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(352, 45);
            this.pnlType.TabIndex = 37;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.SystemColors.Control;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Cardiovascular",
            "Strength",
            "Workout Routines"});
            this.cbType.Location = new System.Drawing.Point(0, 22);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(352, 23);
            this.cbType.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Type";
            // 
            // pnlDuration
            // 
            this.pnlDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDuration.Controls.Add(this.tbDuration);
            this.pnlDuration.Controls.Add(this.label4);
            this.pnlDuration.Location = new System.Drawing.Point(32, 355);
            this.pnlDuration.Name = "pnlDuration";
            this.pnlDuration.Size = new System.Drawing.Size(352, 45);
            this.pnlDuration.TabIndex = 37;
            // 
            // tbDuration
            // 
            this.tbDuration.BackColor = System.Drawing.SystemColors.Control;
            this.tbDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDuration.Location = new System.Drawing.Point(0, 18);
            this.tbDuration.Multiline = true;
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.PlaceholderText = "Input the exercise duration (in minutes)";
            this.tbDuration.Size = new System.Drawing.Size(352, 27);
            this.tbDuration.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Duration";
            // 
            // pnlBurnedCalories
            // 
            this.pnlBurnedCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBurnedCalories.Controls.Add(this.tbBurnedCalories);
            this.pnlBurnedCalories.Controls.Add(this.label2);
            this.pnlBurnedCalories.Location = new System.Drawing.Point(32, 286);
            this.pnlBurnedCalories.Name = "pnlBurnedCalories";
            this.pnlBurnedCalories.Size = new System.Drawing.Size(352, 45);
            this.pnlBurnedCalories.TabIndex = 36;
            // 
            // tbBurnedCalories
            // 
            this.tbBurnedCalories.BackColor = System.Drawing.SystemColors.Control;
            this.tbBurnedCalories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBurnedCalories.Location = new System.Drawing.Point(0, 18);
            this.tbBurnedCalories.Multiline = true;
            this.tbBurnedCalories.Name = "tbBurnedCalories";
            this.tbBurnedCalories.PlaceholderText = "Input burned calories here";
            this.tbBurnedCalories.Size = new System.Drawing.Size(352, 27);
            this.tbBurnedCalories.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Burned Calories";
            // 
            // pnlDescription
            // 
            this.pnlDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDescription.Controls.Add(this.tbDescription);
            this.pnlDescription.Controls.Add(this.lblNama);
            this.pnlDescription.Location = new System.Drawing.Point(32, 217);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(352, 45);
            this.pnlDescription.TabIndex = 35;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Location = new System.Drawing.Point(0, 18);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "Input your food desc here";
            this.tbDescription.Size = new System.Drawing.Size(352, 27);
            this.tbDescription.TabIndex = 13;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.BackColor = System.Drawing.Color.Transparent;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNama.Location = new System.Drawing.Point(0, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(68, 15);
            this.lblNama.TabIndex = 15;
            this.lblNama.Text = "Description";
            // 
            // pnlNama
            // 
            this.pnlNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNama.Controls.Add(this.tbNama);
            this.pnlNama.Controls.Add(this.label3);
            this.pnlNama.Location = new System.Drawing.Point(32, 148);
            this.pnlNama.Name = "pnlNama";
            this.pnlNama.Size = new System.Drawing.Size(352, 45);
            this.pnlNama.TabIndex = 34;
            // 
            // tbNama
            // 
            this.tbNama.BackColor = System.Drawing.SystemColors.Control;
            this.tbNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNama.Location = new System.Drawing.Point(0, 18);
            this.tbNama.Multiline = true;
            this.tbNama.Name = "tbNama";
            this.tbNama.PlaceholderText = "Input your name here";
            this.tbNama.Size = new System.Drawing.Size(352, 27);
            this.tbNama.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nama";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(304, 545);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 37);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddExercise.BackColor = System.Drawing.Color.Chocolate;
            this.btnAddExercise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExercise.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddExercise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddExercise.Location = new System.Drawing.Point(30, 545);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(268, 37);
            this.btnAddExercise.TabIndex = 23;
            this.btnAddExercise.Text = "Add";
            this.btnAddExercise.UseVisualStyleBackColor = false;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(117, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Exercise Form";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(260, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Search Here";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Location = new System.Drawing.Point(347, 62);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "Search by exercise name";
            this.tbSearch.Size = new System.Drawing.Size(286, 23);
            this.tbSearch.TabIndex = 26;
            this.tbSearch.WordWrap = false;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvData.Location = new System.Drawing.Point(50, 102);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(583, 476);
            this.dgvData.TabIndex = 25;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // FormExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyCalories.Properties.Resources.image_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 614);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.lblTitle2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormExercise";
            this.Text = "FormFoodEnConv";
            this.Load += new System.EventHandler(this.FormExercise_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            this.pnlDuration.ResumeLayout(false);
            this.pnlDuration.PerformLayout();
            this.pnlBurnedCalories.ResumeLayout(false);
            this.pnlBurnedCalories.PerformLayout();
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.pnlNama.ResumeLayout(false);
            this.pnlNama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle2;
        private Panel panelForm;
        private Label label9;
        private TextBox tbSearch;
        private DataGridView dgvData;
        private Label label1;
        private Button btnClear;
        private Button btnAddExercise;
        private Panel pnlType;
        private Label label5;
        private Panel pnlDuration;
        private TextBox tbDuration;
        private Label label4;
        private Panel pnlBurnedCalories;
        private TextBox tbBurnedCalories;
        private Label label2;
        private Panel pnlDescription;
        private TextBox tbDescription;
        private Label lblNama;
        private Panel pnlNama;
        private TextBox tbNama;
        private Label label3;
        private ComboBox cbType;
    }
}