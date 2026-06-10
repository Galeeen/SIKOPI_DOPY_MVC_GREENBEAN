using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC_GREENBEAN.Controllers;
using SIKOPI_DOPY_MVC_GREENBEAN.Views;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Views
{
    public partial class FormBahanBakuAdmin : Form
    {
        private readonly BahanBakuController _bahanBakuController;

        public FormBahanBakuAdmin()
        {
            InitializeComponent();

            _bahanBakuController = new BahanBakuController();

            Load -= FormBahanBakuAdmin_Load;
            Load += FormBahanBakuAdmin_Load;

            btnTambahGreenAdmin.Click -= btnTambahGreenAdmin_Click;
            btnTambahGreenAdmin.Click += btnTambahGreenAdmin_Click;

            dgvGreenAdmin.CellContentClick -= dgvGreenAdmin_CellContentClick;
            dgvGreenAdmin.CellContentClick += dgvGreenAdmin_CellContentClick;
        }

        private void FormBahanBakuAdmin_Load(object? sender, EventArgs e)
        {
            LoadDataGreenBean();
        }

        private void LoadDataGreenBean()
        {
            try
            {
                DataTable dataGreenBean = _bahanBakuController.AmbilSemuaGreenBean();

                dgvGreenAdmin.DataSource = dataGreenBean;

                AturTampilanGridGreenBean();
                TambahkanKolomAksiGreenBean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data green bean.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AturTampilanGridGreenBean()
        {
            dgvGreenAdmin.ReadOnly = true;
            dgvGreenAdmin.AllowUserToAddRows = false;
            dgvGreenAdmin.AllowUserToDeleteRows = false;
            dgvGreenAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGreenAdmin.MultiSelect = false;
            dgvGreenAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvGreenAdmin.Columns.Contains("id"))
            {
                dgvGreenAdmin.Columns["id"].Visible = false;
            }

            if (dgvGreenAdmin.Columns.Contains("nama"))
            {
                dgvGreenAdmin.Columns["nama"].HeaderText = "Nama Green Bean";
            }

            if (dgvGreenAdmin.Columns.Contains("origin"))
            {
                dgvGreenAdmin.Columns["origin"].HeaderText = "Origin";
            }

            if (dgvGreenAdmin.Columns.Contains("jenis_bean"))
            {
                dgvGreenAdmin.Columns["jenis_bean"].HeaderText = "Jenis Bean";
            }

            if (dgvGreenAdmin.Columns.Contains("metode_proses"))
            {
                dgvGreenAdmin.Columns["metode_proses"].HeaderText = "Metode Proses";
            }

            if (dgvGreenAdmin.Columns.Contains("grade"))
            {
                dgvGreenAdmin.Columns["grade"].HeaderText = "Grade";
            }

            if (dgvGreenAdmin.Columns.Contains("stock_kg"))
            {
                dgvGreenAdmin.Columns["stock_kg"].HeaderText = "Stok Kg";
            }

            if (dgvGreenAdmin.Columns.Contains("price_per_kg"))
            {
                dgvGreenAdmin.Columns["price_per_kg"].HeaderText = "Harga per Kg";
            }
        }

        private void TambahkanKolomAksiGreenBean()
        {
            if (dgvGreenAdmin.Columns.Contains("colEditGreen"))
            {
                dgvGreenAdmin.Columns.Remove("colEditGreen");
            }

            if (dgvGreenAdmin.Columns.Contains("colHapusGreen"))
            {
                dgvGreenAdmin.Columns.Remove("colHapusGreen");
            }

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.Name = "colEditGreen";
            colEdit.HeaderText = "Edit";
            colEdit.Text = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Width = 80;
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
            colHapus.Name = "colHapusGreen";
            colHapus.HeaderText = "Hapus";
            colHapus.Text = "Hapus";
            colHapus.UseColumnTextForButtonValue = true;
            colHapus.Width = 80;
            colHapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgvGreenAdmin.Columns.Add(colEdit);
            dgvGreenAdmin.Columns.Add(colHapus);

            colEdit.DisplayIndex = dgvGreenAdmin.Columns.Count - 2;
            colHapus.DisplayIndex = dgvGreenAdmin.Columns.Count - 1;
        }

        private void btnTambahGreenAdmin_Click(object? sender, EventArgs e)
        {
            using (FormDialogGreenBean formDialog = new FormDialogGreenBean())
            {
                DialogResult result = formDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadDataGreenBean();
                }
            }
        }

        private void dgvGreenAdmin_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex < 0)
            {
                return;
            }

            string namaKolom = dgvGreenAdmin.Columns[e.ColumnIndex].Name;

            if (namaKolom != "colEditGreen" && namaKolom != "colHapusGreen")
            {
                return;
            }

            object? nilaiId = dgvGreenAdmin.Rows[e.RowIndex].Cells["id"].Value;

            if (nilaiId == null || nilaiId == DBNull.Value)
            {
                MessageBox.Show(
                    "ID green bean tidak ditemukan.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            long id = Convert.ToInt64(nilaiId);

            if (namaKolom == "colEditGreen")
            {
                EditGreenBean(id);
            }
            else if (namaKolom == "colHapusGreen")
            {
                HapusGreenBean(id);
            }
        }

        private void EditGreenBean(long id)
        {
            using (FormDialogGreenBean formDialog = new FormDialogGreenBean(id))
            {
                DialogResult result = formDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadDataGreenBean();
                }
            }
        }

        private void HapusGreenBean(long id)
        {
            DialogResult konfirmasi = MessageBox.Show(
                "Apakah kamu yakin ingin menghapus data green bean ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _bahanBakuController.HapusGreenBean(id);

                MessageBox.Show(
                    "Data green bean berhasil dihapus.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadDataGreenBean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menghapus data green bean.\n\n" +
                    "Kemungkinan data ini sudah digunakan pada proses lain.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
  
        }
        private void tabBahanAdmin_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Kosongkan dulu jika belum digunakan.
        }
    }
}