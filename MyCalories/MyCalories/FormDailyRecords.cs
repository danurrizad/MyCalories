using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalories
{

    public partial class FormDailyRecords : Form
    {
        private DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();

        public FormDailyRecords()
        {
            InitializeComponent();
            Display();
        }

        private void GenerateButton()
        {
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;

            dgvData.Columns.Add(btnDelete);
        }

        private void Display()
        {
            ClearDGV();
            DailyRecords.GetAllRecords(dgvData);
            GenerateButton();
        }

        public void ClearDGV()
        {
            this.dgvData.Columns.Clear();
        }

        private void FormDailyRecords_Load(object sender, EventArgs e)
        {
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DailyRecords.SearchRecord(tbSearch.Text, this.dgvData);
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            if(dgvData.Rows.Count == 0)
            {
                MessageBox.Show("The data is already empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show($"Are you want to delete all records ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        DailyRecords.ClearAllRecords(dgvData);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Display();
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == /*dgvData.ColumnCount - 1*/ 0)
            {
                try
                {
                    int deleted_id = int.Parse(dgvData.Rows[e.RowIndex].Cells[1].Value.ToString());

                    if (MessageBox.Show($"Are you want to delete record with id: {deleted_id.ToString()} ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            DailyRecords.DeleteRecord(deleted_id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        Display();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
