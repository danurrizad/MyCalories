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
                user = new User(
                        user.ID,
                        user.Name,
                        user.Age,
                        user.Gender,
                        double.Parse(tbHeight.Text),
                        double.Parse(tbWeight.Text),
                        int.Parse(tbActivities.Text),
                        user.Roles,
                        user.Email,
                        user.Password
                    );

                user.EditUser(user, user.ID);
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
