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
    public partial class FormExercise : Form
    {
        private DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
        private DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        private int selected_id;

        public FormExercise()
        {
            InitializeComponent();
            Display();
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

        public void Clear()
        {
            tbBurnedCalories.Text = tbDescription.Text = tbDuration.Text = tbNama.Text = cbType.Text = "";
            btnAddExercise.Text = "Add";
        }

        public void ClearDGV()
        {
            this.dgvData.Columns.Clear();
        }

        private void Display()
        {
            ClearDGV();
            Workout.GetAllWorkouts(dgvData);
            GenerateButton();
        }

        private void FormExercise_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            Workout newWorkout;

            if (tbBurnedCalories.Text == "" ||
                tbDescription.Text == "" ||
                tbDuration.Text == "" ||
                tbNama.Text == "" ||
                cbType.Text == "")
            {
                MessageBox.Show("Fill out the blank textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
            else if (btnAddExercise.Text == "Add")
            {
                int id = 0;

                try {
                    if (dgvData.RowCount != 0)
                    {
                        id = int.Parse(dgvData.Rows[dgvData.Rows.Count - 1].Cells[0].Value.ToString());
                        id = id + 1;
                    }
                    else
                    {
                        id = 1;
                    }

                    newWorkout = new Workout(
                            id,
                            tbNama.Text,
                            tbDescription.Text,
                            double.Parse(tbBurnedCalories.Text),
                            int.Parse(tbDuration.Text),
                            cbType.Text
                        );

                    newWorkout.AddWorkout(newWorkout);
                    Clear();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (btnAddExercise.Text == "Update")
            {
                try
                {
                    int id = this.selected_id;

                    newWorkout = new Workout(
                            id,
                            tbNama.Text,
                            tbDescription.Text,
                            double.Parse(tbBurnedCalories.Text),
                            int.Parse(tbDuration.Text),
                            cbType.Text
                        );

                    newWorkout.EditWorkout(newWorkout, id);
                    Clear();
                    Display();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            //MessageBox.Show(dgvData.ColumnCount.ToString());
            //MessageBox.Show(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (e.ColumnIndex == dgvData.ColumnCount - 2)
            {
                try
                {
                    btnAddExercise.Text = "Update";
                    this.selected_id = int.Parse(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());
                    tbNama.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbDescription.Text = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbBurnedCalories.Text = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbDuration.Text = dgvData.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cbType.Text = dgvData.Rows[e.RowIndex].Cells[5].Value.ToString();

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
                            Workout.DeleteWorkout(deleted_id);
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
            Workout.SearchWorkout(tbSearch.Text, this.dgvData); 
        }
    }
}
