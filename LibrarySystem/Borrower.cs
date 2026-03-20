using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibrarySystem
{
    public partial class Borrower : Form
    {
        private DataTable borrowersTable = new DataTable();
        private int editingRowIndex = -1;

        public Borrower()
        {
            InitializeComponent();
            InitializeBorrowersTable();
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void InitializeBorrowersTable()
        {
            borrowersTable.Columns.Add("Borrower ID", typeof(string));
            borrowersTable.Columns.Add("Name", typeof(string));
            borrowersTable.Columns.Add("Contact", typeof(string));
            grid1.DataSource = borrowersTable;
        }

        private void ClearFields()
        {
            txtBorrowerID.Clear();
            txtName.Clear();
            txtContact.Clear();
            txtBorrowerID.ReadOnly = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtBorrowerID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBorrowerID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            borrowersTable.Rows.Add(txtBorrowerID.Text.Trim(),
                txtName.Text.Trim(), txtContact.Text.Trim());
            ClearFields();
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            MessageBox.Show("Borrower saved!", "Success",
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
            txtBorrowerID.Text = borrowersTable.Rows[editingRowIndex]["Borrower ID"].ToString();
            txtName.Text = borrowersTable.Rows[editingRowIndex]["Name"].ToString();
            txtContact.Text = borrowersTable.Rows[editingRowIndex]["Contact"].ToString();
            txtBorrowerID.ReadOnly = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            borrowersTable.Rows[editingRowIndex]["Name"] = txtName.Text.Trim();
            borrowersTable.Rows[editingRowIndex]["Contact"] = txtContact.Text.Trim();
            ClearFields();
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            MessageBox.Show("Borrower updated!", "Success",
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
                borrowersTable.Rows[grid1.CurrentRow.Index].Delete();
                ClearFields();
                MessageBox.Show("Borrower deleted!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text.Trim();
            borrowersTable.DefaultView.RowFilter = string.IsNullOrEmpty(s) ? "" :
                $"[Borrower ID] LIKE '%{s}%' OR [Name] LIKE '%{s}%' OR [Contact] LIKE '%{s}%'";
        }

        private void grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBorrowerID.Text = grid1.Rows[e.RowIndex].Cells["Borrower ID"].Value?.ToString();
                txtName.Text = grid1.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                txtContact.Text = grid1.Rows[e.RowIndex].Cells["Contact"].Value?.ToString();
            }
        }
    }
}