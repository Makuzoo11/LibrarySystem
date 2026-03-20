namespace LibrarySystem
{
    partial class Borrower
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBorrowerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grid1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBorrowerID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();

            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBorrowerID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(40, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 200);
            this.groupBox1.Text = "Borrower Details";

            this.label1.Text = "Borrower ID";
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.AutoSize = true;

            this.label2.Text = "Name";
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.AutoSize = true;

            this.label3.Text = "Contact";
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.AutoSize = true;

            this.txtBorrowerID.Location = new System.Drawing.Point(100, 37);
            this.txtBorrowerID.Size = new System.Drawing.Size(180, 20);
            this.txtBorrowerID.Name = "txtBorrowerID";

            this.txtName.Location = new System.Drawing.Point(100, 72);
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.Name = "txtName";

            this.txtContact.Location = new System.Drawing.Point(100, 107);
            this.txtContact.Size = new System.Drawing.Size(180, 20);
            this.txtContact.Name = "txtContact";

            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(300, 35);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(385, 35);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnEdit.Text = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(300, 68);
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(385, 68);
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(300, 101);
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.grid1);
            this.groupBox2.Location = new System.Drawing.Point(40, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 320);
            this.groupBox2.Text = "Borrower Records";

            this.label4.Text = "Search";
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.AutoSize = true;

            this.txtSearch.Location = new System.Drawing.Point(65, 27);
            this.txtSearch.Size = new System.Drawing.Size(385, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.grid1.Location = new System.Drawing.Point(15, 60);
            this.grid1.Size = new System.Drawing.Size(435, 245);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.AllowUserToAddRows = false;
            this.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellClick);

            this.ClientSize = new System.Drawing.Size(556, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Text = "Borrower";
            this.Name = "Borrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}