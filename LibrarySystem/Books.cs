using System;
using System.Data;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Books : Form
    {
        private DataTable booksTable = new DataTable();
        private int editingRowIndex = -1;

        public Books()
        {
            InitializeComponent();
            InitializeBooksTable();
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void InitializeBooksTable()
        {
            booksTable.Columns.Add("Book ID", typeof(string));
            booksTable.Columns.Add("Title", typeof(string));
            booksTable.Columns.Add("Author", typeof(string));
            grid1.DataSource = booksTable;
        }

        private void ClearFields()
        {
            txtBookID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtBookID.ReadOnly = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtBookID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text) ||
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            booksTable.Rows.Add(txtBookID.Text.Trim(),
                txtTitle.Text.Trim(), txtAuthor.Text.Trim());
            ClearFields();
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            MessageBox.Show("Book saved!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grid1.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            editingRowIndex = grid1.CurrentRow.Index;
            txtBookID.Text = booksTable.Rows[editingRowIndex]["Book ID"].ToString();
            txtTitle.Text = booksTable.Rows[editingRowIndex]["Title"].ToString();
            txtAuthor.Text = booksTable.Rows[editingRowIndex]["Author"].ToString();
            txtBookID.ReadOnly = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            booksTable.Rows[editingRowIndex]["Title"] = txtTitle.Text.Trim();
            booksTable.Rows[editingRowIndex]["Author"] = txtAuthor.Text.Trim();
            ClearFields();
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            MessageBox.Show("Book updated!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid1.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show("Are you sure?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                booksTable.Rows[grid1.CurrentRow.Index].Delete();
                ClearFields();
                MessageBox.Show("Book deleted!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text.Trim();
            booksTable.DefaultView.RowFilter = string.IsNullOrEmpty(s) ? "" :
                "[Book ID] LIKE '%" + s + "%' OR [Title] LIKE '%" + s + "%' OR [Author] LIKE '%" + s + "%'";
        }

        private void grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBookID.Text = grid1.Rows[e.RowIndex].Cells["Book ID"].Value?.ToString();
                txtTitle.Text = grid1.Rows[e.RowIndex].Cells["Title"].Value?.ToString();
                txtAuthor.Text = grid1.Rows[e.RowIndex].Cells["Author"].Value?.ToString();
            }
        }
    }
}