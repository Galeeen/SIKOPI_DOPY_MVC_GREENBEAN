namespace SIKOPI_DOPY_MVC_GREENBEAN.Views
{
    partial class FormBahanBakuAdmin
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
            lblJudul = new Panel();
            btnTambahGreenAdmin = new Button();
            tabBahanAdmin = new TabControl();
            tabGreenAdmin = new TabPage();
            dgvGreenAdmin = new DataGridView();
            tabRoastAdmin = new TabPage();
            dgvRoastAdmin = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            lblJudul.SuspendLayout();
            tabBahanAdmin.SuspendLayout();
            tabGreenAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGreenAdmin).BeginInit();
            tabRoastAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoastAdmin).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.Controls.Add(btnTambahGreenAdmin);
            lblJudul.Controls.Add(tabBahanAdmin);
            lblJudul.Controls.Add(label2);
            lblJudul.Controls.Add(label1);
            lblJudul.Location = new Point(12, 2);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(1569, 442);
            lblJudul.TabIndex = 2;
            // 
            // btnTambahGreenAdmin
            // 
            btnTambahGreenAdmin.Location = new Point(13, 112);
            btnTambahGreenAdmin.Name = "btnTambahGreenAdmin";
            btnTambahGreenAdmin.Size = new Size(168, 29);
            btnTambahGreenAdmin.TabIndex = 3;
            btnTambahGreenAdmin.Text = "+ Tambah Green Bean";
            btnTambahGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // tabBahanAdmin
            // 
            tabBahanAdmin.Controls.Add(tabGreenAdmin);
            tabBahanAdmin.Controls.Add(tabRoastAdmin);
            tabBahanAdmin.Location = new Point(3, 172);
            tabBahanAdmin.Name = "tabBahanAdmin";
            tabBahanAdmin.SelectedIndex = 0;
            tabBahanAdmin.Size = new Size(1496, 267);
            tabBahanAdmin.TabIndex = 4;
            tabBahanAdmin.SelectedIndexChanged += tabBahanAdmin_SelectedIndexChanged;
            // 
            // tabGreenAdmin
            // 
            tabGreenAdmin.Controls.Add(dgvGreenAdmin);
            tabGreenAdmin.Location = new Point(4, 29);
            tabGreenAdmin.Name = "tabGreenAdmin";
            tabGreenAdmin.Padding = new Padding(3);
            tabGreenAdmin.Size = new Size(1488, 234);
            tabGreenAdmin.TabIndex = 0;
            tabGreenAdmin.Text = "Green Bean";
            tabGreenAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvGreenAdmin
            // 
            dgvGreenAdmin.AllowUserToAddRows = false;
            dgvGreenAdmin.AllowUserToDeleteRows = false;
            dgvGreenAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGreenAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGreenAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGreenAdmin.Dock = DockStyle.Fill;
            dgvGreenAdmin.Location = new Point(3, 3);
            dgvGreenAdmin.Name = "dgvGreenAdmin";
            dgvGreenAdmin.ReadOnly = true;
            dgvGreenAdmin.RowHeadersWidth = 51;
            dgvGreenAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGreenAdmin.Size = new Size(1482, 228);
            dgvGreenAdmin.TabIndex = 0;
            // 
            // tabRoastAdmin
            // 
            tabRoastAdmin.Controls.Add(dgvRoastAdmin);
            tabRoastAdmin.Location = new Point(4, 29);
            tabRoastAdmin.Name = "tabRoastAdmin";
            tabRoastAdmin.Padding = new Padding(3);
            tabRoastAdmin.Size = new Size(1488, 234);
            tabRoastAdmin.TabIndex = 1;
            tabRoastAdmin.Text = "Roast Bean";
            tabRoastAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvRoastAdmin
            // 
            dgvRoastAdmin.AllowUserToAddRows = false;
            dgvRoastAdmin.AllowUserToDeleteRows = false;
            dgvRoastAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoastAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoastAdmin.Dock = DockStyle.Fill;
            dgvRoastAdmin.Location = new Point(3, 3);
            dgvRoastAdmin.Name = "dgvRoastAdmin";
            dgvRoastAdmin.ReadOnly = true;
            dgvRoastAdmin.RowHeadersWidth = 51;
            dgvRoastAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastAdmin.Size = new Size(1482, 228);
            dgvRoastAdmin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 39);
            label2.Name = "label2";
            label2.Size = new Size(269, 20);
            label2.TabIndex = 1;
            label2.Text = "Kelola stok Green Bean dan Roast Bean";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Bahan Baku";
            // 
            // FormBahanBakuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 528);
            Controls.Add(lblJudul);
            Name = "FormBahanBakuAdmin";
            Text = "FormBahanBakuAdmin";
            lblJudul.ResumeLayout(false);
            lblJudul.PerformLayout();
            tabBahanAdmin.ResumeLayout(false);
            tabGreenAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGreenAdmin).EndInit();
            tabRoastAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoastAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel lblJudul;
        private Label label2;
        private Label label1;
        private Button btnTambahGreenAdmin;
        private TabControl tabBahanAdmin;
        private TabPage tabGreenAdmin;
        private TabPage tabRoastAdmin;
        private DataGridView dgvGreenAdmin;
        private DataGridView dgvRoastAdmin;
    }
}