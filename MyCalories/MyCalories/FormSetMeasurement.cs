using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalories
{
    public partial class FormSetMeasurement : Form
    {
        User user;

        public FormSetMeasurement(User user)
        {
            InitializeComponent();
            this.user = user;
            Clear();
        }

        private void Clear()
        {
            tbActivities.Text = tbHeight.Text = tbWeight.Text = "";
        }

        private void FormSetMeasurement_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                user.Height = double.Parse(tbHeight.Text);
                user.Weight = double.Parse(tbWeight.Text);
                user.Activities = int.Parse(tbActivities.Text);

                MessageBox.Show("Update successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
