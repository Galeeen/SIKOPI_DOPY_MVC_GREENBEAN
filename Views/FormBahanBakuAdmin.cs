using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Views
{
    public partial class FormBahanBakuAdmin : Form
    {
        public FormBahanBakuAdmin()
        {
            InitializeComponent();

            Load -= FormBahanBakuAdmin_Load;
            Load += FormBahanBakuAdmin_Load;

            btnTambahGreenAdmin.Click -= btnTambahGreenAdmin_Click;
            btnTambahGreenAdmin.Click += btnTambahGreenAdmin_Click;
        }

        private void FormBahanBakuAdmin_Load(object? sender, EventArgs e)
        {
            btnTambahGreenAdmin.Visible = true;
            btnTambahGreenAdmin.Enabled = true;
            btnTambahGreenAdmin.BringToFront();
        }

        private void btnTambahGreenAdmin_Click(object? sender, EventArgs e)
        {
            FormDialogGreenBean form = new FormDialogGreenBean();
            form.ShowDialog();
        }

        private void tabBahanAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Untuk sekarang dikosongkan dulu.
        }
    }
}
