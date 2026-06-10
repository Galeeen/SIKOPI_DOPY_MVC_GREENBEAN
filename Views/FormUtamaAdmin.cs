using SIKOPI_DOPY_MVC_GREENBEAN.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Views
{
    public partial class FormUtamaAdmin : Form
    {
        public FormUtamaAdmin()
        {
            InitializeComponent();

            Load -= FormUtamaAdmin_Load;
            Load += FormUtamaAdmin_Load;

            btnDasboardAdmin1.Click -= btnDasboardAdmin1_Click;
            btnDasboardAdmin1.Click += btnDasboardAdmin1_Click;

            btnBahanBakuAdmin1.Click -= btnBahanBakuAdmin1_Click;
            btnBahanBakuAdmin1.Click += btnBahanBakuAdmin1_Click;

            btnKeluarAdmin.Click -= btnKeluarAdmin_Click;
            btnKeluarAdmin.Click += btnKeluarAdmin_Click;
        }

        private void FormUtamaAdmin_Load(object? sender, EventArgs e)
        {
            lblSelamatDatangAdmin.Text = "Halo, Admin";

            TampilkanFormDiPanel(new FormDasboardAdmin());
        }

        private void TampilkanFormDiPanel(Form form)
        {
            panelKontenAdmin.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelKontenAdmin.Controls.Add(form);
            form.Show();
        }

        private void btnDasboardAdmin1_Click(object? sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormDasboardAdmin());
        }

        private void btnBahanBakuAdmin1_Click(object? sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormBahanBakuAdmin());
        }

        private void btnKeluarAdmin_Click(object? sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            Close();
        }
    }
}