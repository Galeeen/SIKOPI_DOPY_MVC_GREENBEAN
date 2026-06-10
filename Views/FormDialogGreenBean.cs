using System;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC_GREENBEAN.Controllers;
using SIKOPI_DOPY_MVC_GREENBEAN.Models;
using SIKOPI_DOPY_MVC_GREENBEAN.Repositories;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Views
{
    public partial class FormDialogGreenBean : Form
    {
        private readonly RepositoriLookup _repositoriLookup;
        private readonly BahanBakuController _controller;
        private readonly long? _greenBeanId;

        public FormDialogGreenBean()
        {
            InitializeComponent();

            _repositoriLookup = new RepositoriLookup();
            _controller = new BahanBakuController();

            Load -= FormDialogGreenBean_Load;
            Load += FormDialogGreenBean_Load;

            btnSimpan.Click -= btnSimpan_Click;
            btnSimpan.Click += btnSimpan_Click;

            btnBatal.Click -= btnBatal_Click;
            btnBatal.Click += btnBatal_Click;
        }

        public FormDialogGreenBean(long greenBeanId) : this()
        {
            _greenBeanId = greenBeanId;
        }

        private void FormDialogGreenBean_Load(object? sender, EventArgs e)
        {
            try
            {
                LoadComboBox();

                if (_greenBeanId.HasValue)
                {
                    Text = "Edit Green Bean";
                    LoadDataEdit(_greenBeanId.Value);
                }
                else
                {
                    Text = "Tambah Green Bean";

                    txtNamaGreenBean.Text = string.Empty;
                    txtOrigin.Text = string.Empty;
                    txtStockKg.Text = "0";
                    txtPricePerKg.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat form.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoadComboBox()
        {
            cmbBeanType.DataSource = _repositoriLookup.AmbilBeanTypes();
            cmbBeanType.DisplayMember = "Name";
            cmbBeanType.ValueMember = "Id";
            cmbBeanType.SelectedIndex = -1;

            cmbProcessMethod.DataSource = _repositoriLookup.AmbilProcessMethods();
            cmbProcessMethod.DisplayMember = "Name";
            cmbProcessMethod.ValueMember = "Id";
            cmbProcessMethod.SelectedIndex = -1;

            cmbGrade.DataSource = _repositoriLookup.AmbilGrades();
            cmbGrade.DisplayMember = "Name";
            cmbGrade.ValueMember = "Id";
            cmbGrade.SelectedIndex = -1;
        }

        private void LoadDataEdit(long id)
        {
            GreenBean? greenBean = _controller.AmbilGreenBeanById(id);

            if (greenBean == null)
            {
                MessageBox.Show(
                    "Data green bean tidak ditemukan.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Close();
                return;
            }

            txtNamaGreenBean.Text = greenBean.Name;
            txtOrigin.Text = greenBean.Origin ?? string.Empty;

            cmbBeanType.SelectedValue = greenBean.BeanTypeId;

            if (greenBean.ProcessMethodId.HasValue)
            {
                cmbProcessMethod.SelectedValue = greenBean.ProcessMethodId.Value;
            }
            else
            {
                cmbProcessMethod.SelectedIndex = -1;
            }

            if (greenBean.GradeId.HasValue)
            {
                cmbGrade.SelectedValue = greenBean.GradeId.Value;
            }
            else
            {
                cmbGrade.SelectedIndex = -1;
            }

            txtStockKg.Text = greenBean.StockKg.ToString();
            txtPricePerKg.Text = greenBean.PricePerKg.ToString();
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNamaGreenBean.Text))
                {
                    MessageBox.Show(
                        "Nama green bean wajib diisi.",
                        "Validasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (cmbBeanType.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Jenis green bean wajib dipilih.",
                        "Validasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (!decimal.TryParse(txtStockKg.Text, out decimal stockKg))
                {
                    MessageBox.Show(
                        "Stok harus berupa angka.",
                        "Validasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (!decimal.TryParse(txtPricePerKg.Text, out decimal pricePerKg))
                {
                    MessageBox.Show(
                        "Harga harus berupa angka.",
                        "Validasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                GreenBean greenBean = new GreenBean
                {
                    Id = _greenBeanId ?? 0,
                    Name = txtNamaGreenBean.Text.Trim(),
                    Origin = string.IsNullOrWhiteSpace(txtOrigin.Text)
                        ? null
                        : txtOrigin.Text.Trim(),
                    BeanTypeId = Convert.ToInt64(cmbBeanType.SelectedValue),
                    ProcessMethodId = cmbProcessMethod.SelectedValue == null
                        ? null
                        : Convert.ToInt64(cmbProcessMethod.SelectedValue),
                    GradeId = cmbGrade.SelectedValue == null
                        ? null
                        : Convert.ToInt64(cmbGrade.SelectedValue),
                    StockKg = stockKg,
                    PricePerKg = pricePerKg
                };

                if (_greenBeanId.HasValue)
                {
                    _controller.UbahGreenBean(greenBean);

                    MessageBox.Show(
                        "Data green bean berhasil diubah.",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    _controller.TambahGreenBean(greenBean);

                    MessageBox.Show(
                        "Data green bean berhasil ditambahkan.",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBatal_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}