using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalories
{
    public partial class FormUser : Form
    {
        private DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
        private DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        private int selected_id;

        public FormUser()
        {
            InitializeComponent();
            Display();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panelForm = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlRoles = new System.Windows.Forms.Panel();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlHealthStatus = new System.Windows.Forms.Panel();
            this.cbHealthStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlWeight = new System.Windows.Forms.Panel();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlHeight = new System.Windows.Forms.Panel();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlAge = new System.Windows.Forms.Panel();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNama = new System.Windows.Forms.Panel();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panelForm.SuspendLayout();
            this.pnlRoles.SuspendLayout();
            this.pnlHealthStatus.SuspendLayout();
            this.pnlWeight.SuspendLayout();
            this.pnlHeight.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.pnlAge.SuspendLayout();
            this.pnlNama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(48, 23);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(116, 50);
            this.lblTitle2.TabIndex = 9;
            this.lblTitle2.Text = "Users";
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
            this.dgvData.Location = new System.Drawing.Point(48, 86);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(527, 466);
            this.dgvData.TabIndex = 10;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelForm.Controls.Add(this.button2);
            this.panelForm.Controls.Add(this.btnAddUser);
            this.panelForm.Controls.Add(this.pnlRoles);
            this.panelForm.Controls.Add(this.pnlHealthStatus);
            this.panelForm.Controls.Add(this.pnlWeight);
            this.panelForm.Controls.Add(this.pnlHeight);
            this.panelForm.Controls.Add(this.pnlGender);
            this.panelForm.Controls.Add(this.pnlAge);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.pnlNama);
            this.panelForm.Location = new System.Drawing.Point(626, -5);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(415, 639);
            this.panelForm.TabIndex = 11;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(298, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BackColor = System.Drawing.Color.Chocolate;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.Location = new System.Drawing.Point(26, 520);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(266, 37);
            this.btnAddUser.TabIndex = 16;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pnlRoles
            // 
            this.pnlRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoles.Controls.Add(this.cbRoles);
            this.pnlRoles.Controls.Add(this.label8);
            this.pnlRoles.Location = new System.Drawing.Point(26, 428);
            this.pnlRoles.Name = "pnlRoles";
            this.pnlRoles.Size = new System.Drawing.Size(352, 45);
            this.pnlRoles.TabIndex = 21;
            // 
            // cbRoles
            // 
            this.cbRoles.BackColor = System.Drawing.SystemColors.Control;
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoles.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbRoles.Location = new System.Drawing.Point(0, 22);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(352, 23);
            this.cbRoles.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Roles";
            // 
            // pnlHealthStatus
            // 
            this.pnlHealthStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHealthStatus.Controls.Add(this.cbHealthStatus);
            this.pnlHealthStatus.Controls.Add(this.label7);
            this.pnlHealthStatus.Location = new System.Drawing.Point(26, 377);
            this.pnlHealthStatus.Name = "pnlHealthStatus";
            this.pnlHealthStatus.Size = new System.Drawing.Size(352, 45);
            this.pnlHealthStatus.TabIndex = 20;
            // 
            // cbHealthStatus
            // 
            this.cbHealthStatus.BackColor = System.Drawing.SystemColors.Control;
            this.cbHealthStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHealthStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHealthStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbHealthStatus.FormattingEnabled = true;
            this.cbHealthStatus.Items.AddRange(new object[] {
            "Excellent",
            "Average",
            "Poor"});
            this.cbHealthStatus.Location = new System.Drawing.Point(0, 22);
            this.cbHealthStatus.Name = "cbHealthStatus";
            this.cbHealthStatus.Size = new System.Drawing.Size(352, 23);
            this.cbHealthStatus.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Health Status";
            // 
            // pnlWeight
            // 
            this.pnlWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWeight.Controls.Add(this.tbWeight);
            this.pnlWeight.Controls.Add(this.label6);
            this.pnlWeight.Location = new System.Drawing.Point(26, 326);
            this.pnlWeight.Name = "pnlWeight";
            this.pnlWeight.Size = new System.Drawing.Size(352, 45);
            this.pnlWeight.TabIndex = 19;
            // 
            // tbWeight
            // 
            this.tbWeight.BackColor = System.Drawing.SystemColors.Control;
            this.tbWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbWeight.Location = new System.Drawing.Point(0, 18);
            this.tbWeight.Multiline = true;
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.PlaceholderText = "Input your height in (kg)";
            this.tbWeight.Size = new System.Drawing.Size(352, 27);
            this.tbWeight.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Weight";
            // 
            // pnlHeight
            // 
            this.pnlHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeight.Controls.Add(this.tbHeight);
            this.pnlHeight.Controls.Add(this.label5);
            this.pnlHeight.Location = new System.Drawing.Point(26, 275);
            this.pnlHeight.Name = "pnlHeight";
            this.pnlHeight.Size = new System.Drawing.Size(352, 45);
            this.pnlHeight.TabIndex = 18;
            // 
            // tbHeight
            // 
            this.tbHeight.BackColor = System.Drawing.SystemColors.Control;
            this.tbHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHeight.Location = new System.Drawing.Point(0, 18);
            this.tbHeight.Multiline = true;
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.PlaceholderText = "Input your height in (cm)";
            this.tbHeight.Size = new System.Drawing.Size(352, 27);
            this.tbHeight.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Height";
            // 
            // pnlGender
            // 
            this.pnlGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGender.Controls.Add(this.cbGender);
            this.pnlGender.Controls.Add(this.label4);
            this.pnlGender.Location = new System.Drawing.Point(26, 224);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(352, 45);
            this.pnlGender.TabIndex = 17;
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.SystemColors.Control;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGender.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cbGender.Location = new System.Drawing.Point(0, 22);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(352, 23);
            this.cbGender.Sorted = true;
            this.cbGender.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gender";
            // 
            // pnlAge
            // 
            this.pnlAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAge.Controls.Add(this.tbAge);
            this.pnlAge.Controls.Add(this.label3);
            this.pnlAge.Location = new System.Drawing.Point(26, 173);
            this.pnlAge.Name = "pnlAge";
            this.pnlAge.Size = new System.Drawing.Size(352, 45);
            this.pnlAge.TabIndex = 16;
            // 
            // tbAge
            // 
            this.tbAge.BackColor = System.Drawing.SystemColors.Control;
            this.tbAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAge.Location = new System.Drawing.Point(0, 18);
            this.tbAge.Multiline = true;
            this.tbAge.Name = "tbAge";
            this.tbAge.PlaceholderText = "Input your age here";
            this.tbAge.Size = new System.Drawing.Size(352, 27);
            this.tbAge.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Age";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(136, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Form";
            // 
            // pnlNama
            // 
            this.pnlNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNama.Controls.Add(this.tbNama);
            this.pnlNama.Controls.Add(this.label2);
            this.pnlNama.Location = new System.Drawing.Point(26, 122);
            this.pnlNama.Name = "pnlNama";
            this.pnlNama.Size = new System.Drawing.Size(352, 45);
            this.pnlNama.TabIndex = 14;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(MyCalories.User);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(MyCalories.User);
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataSource = typeof(MyCalories.User);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Location = new System.Drawing.Point(289, 42);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "Search by name or gender";
            this.tbSearch.Size = new System.Drawing.Size(286, 23);
            this.tbSearch.TabIndex = 23;
            this.tbSearch.WordWrap = false;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(203, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Search Here";
            // 
            // FormUser
            // 
            this.BackgroundImage = global::MyCalories.Properties.Resources.image_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 604);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblTitle2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.pnlRoles.ResumeLayout(false);
            this.pnlRoles.PerformLayout();
            this.pnlHealthStatus.ResumeLayout(false);
            this.pnlHealthStatus.PerformLayout();
            this.pnlWeight.ResumeLayout(false);
            this.pnlWeight.PerformLayout();
            this.pnlHeight.ResumeLayout(false);
            this.pnlHeight.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.pnlAge.ResumeLayout(false);
            this.pnlAge.PerformLayout();
            this.pnlNama.ResumeLayout(false);
            this.pnlNama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GenerateButton()
        {
            
            this.btnUpdate.HeaderText = "Update";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseColumnTextForButtonValue = true;

            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;

            dgvData.Columns.Add(btnUpdate);
            dgvData.Columns.Add(btnDelete);
        }

        private void Display()
        {
            ClearDGV();
            GetData.ShowData("select * from users", dgvData);
            GenerateButton();
        }

        public void Clear()
        {
            tbAge.Text = cbGender.Text = cbHealthStatus.Text = tbWeight.Text = tbHeight.Text = tbNama.Text = cbRoles.Text = "";
            btnAddUser.Text = "Add";
        }

        public void ClearDGV()
        {
            this.dgvData.Columns.Clear();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User newUser;

            if (tbAge.Text == "" ||
                cbGender.Text == "" ||
                cbHealthStatus.Text == "" ||
                tbHeight.Text == "" ||
                tbWeight.Text == "" ||
                tbNama.Text == "" ||
                cbRoles.Text == "")
            {
                MessageBox.Show("Fill out the blank textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
            else if (btnAddUser.Text == "Add")
            {
                int id = 0;

                try
                {
                    if (dgvData.RowCount != 0)
                    {
                        id = int.Parse(dgvData.Rows[dgvData.Rows.Count - 1].Cells[0].Value.ToString());
                        id = id + 1;
                    }
                    else
                    {
                        id = 1;
                    }

                    newUser = new User(id,
                        tbNama.Text,
                        int.Parse(tbAge.Text),
                        cbGender.Text,
                        double.Parse(tbHeight.Text),
                        double.Parse(tbWeight.Text),
                        cbHealthStatus.Text,
                        cbRoles.Text);

                    newUser.AddUser(newUser);
                    Clear();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (btnAddUser.Text == "Update")
            {
                try
                {
                    int id = this.selected_id;

                    newUser = new User(id,
                        tbNama.Text,
                        int.Parse(tbAge.Text),
                        cbGender.Text,
                        double.Parse(tbHeight.Text),
                        double.Parse(tbWeight.Text),
                        cbHealthStatus.Text,
                        cbRoles.Text);

                    newUser.EditUser(newUser, id);
                    Clear();
                    Display();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            //MessageBox.Show(dgvData.Rows[e.RowIndex].Cells[2].Value.ToString());

            if (e.ColumnIndex == dgvData.ColumnCount - 2)
            {
                try
                {
                    btnAddUser.Text = "Update";
                    this.selected_id = int.Parse(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());
                    tbNama.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbAge.Text = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbGender.Text = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbHeight.Text = dgvData.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbWeight.Text = dgvData.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cbHealthStatus.Text = dgvData.Rows[e.RowIndex].Cells[6].Value.ToString();
                    cbRoles.Text = dgvData.Rows[e.RowIndex].Cells[7].Value.ToString();

                    tbNama.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.ColumnIndex == dgvData.ColumnCount - 1)
            {
                try
                {
                    int deleted_id = int.Parse(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());
                    string deleted_name = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();

                    if (MessageBox.Show($"Are you want to delete {deleted_name} ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            User.DeleteUser(deleted_id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        Clear();
                        Display();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            User.SearchUser(tbSearch.Text, this.dgvData);
        }
    }
}
