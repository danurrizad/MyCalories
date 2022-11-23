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
    public partial class FormNutriFacts : Form
    {
        private DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
        private DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        private int selected_id;

        public FormNutriFacts()
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
            tbCalories.Text = tbCarbohydrate.Text = tbDescription.Text = tbFat.Text = tbNama.Text = tbPortion.Text = tbSearch.Text = tbProtein.Text = "";
            btnAddFood.Text = "Add";
        }

        public void ClearDGV()
        {
            this.dgvData.Columns.Clear();
        }

        private void Display()
        {
            ClearDGV();
            Food.GetAllFoods(dgvData);
            GenerateButton();
        }

        private void FormNutriFacts_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Food newFood;

            if (tbCalories.Text == "" ||
                tbCarbohydrate.Text == "" ||
                tbDescription.Text == "" ||
                tbFat.Text == "" ||
                tbNama.Text == "" ||
                tbPortion.Text == "" ||
                tbProtein .Text == "")
            {
                MessageBox.Show("Fill out the blank textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
            else if (btnAddFood.Text == "Add")
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

                    newFood = new Food(
                            id,
                            tbNama.Text,
                            tbDescription.Text,
                            double.Parse(tbCalories.Text),
                            double.Parse(tbPortion.Text),
                            double.Parse(tbCarbohydrate.Text),
                            double.Parse(tbProtein.Text),
                            double.Parse(tbFat.Text)
                            );

                    newFood.AddFood(newFood);
                    Clear();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (btnAddFood.Text == "Update")
            {
                try
                {
                    int id = this.selected_id;

                    newFood = new Food(
                            id,
                            tbNama.Text,
                            tbDescription.Text,
                            double.Parse(tbCalories.Text),
                            double.Parse(tbPortion.Text),
                            double.Parse(tbCarbohydrate.Text),
                            double.Parse(tbProtein.Text),
                            double.Parse(tbFat.Text)
                            );

                    newFood.EditFood(newFood, id);
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

            if (e.ColumnIndex == dgvData.ColumnCount - 2)
            {
                try
                {
                    btnAddFood.Text = "Update";
                    this.selected_id = int.Parse(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());
                    tbNama.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbDescription.Text = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbCalories.Text = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tbPortion.Text = dgvData.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tbCarbohydrate.Text = dgvData.Rows[e.RowIndex].Cells[5].Value.ToString();
                    tbProtein.Text = dgvData.Rows[e.RowIndex].Cells[6].Value.ToString();
                    tbFat.Text = dgvData.Rows[e.RowIndex].Cells[7].Value.ToString();

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
                            Food.DeleteFood(deleted_id);
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
            Food.SearchFood(tbSearch.Text, this.dgvData);
        }
    }
}
