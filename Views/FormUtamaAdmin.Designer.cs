namespace SIKOPI_DOPY_MVC_GREENBEAN.Views
{
    partial class FormUtamaAdmin
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
            panelSidebarAdmin = new Panel();
            btnKeluarAdmin = new Button();
            btnBahanBakuAdmin1 = new Button();
            btnDasboardAdmin1 = new Button();
            lblSelamatDatangAdmin = new Label();
            panelKontenAdmin = new Panel();
            lblJudulApp = new Label();
            panelSidebarAdmin.SuspendLayout();
            panelKontenAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebarAdmin
            // 
            panelSidebarAdmin.Controls.Add(btnKeluarAdmin);
            panelSidebarAdmin.Controls.Add(btnBahanBakuAdmin1);
            panelSidebarAdmin.Controls.Add(btnDasboardAdmin1);
            panelSidebarAdmin.Controls.Add(lblSelamatDatangAdmin);
            panelSidebarAdmin.Location = new Point(12, 12);
            panelSidebarAdmin.Name = "panelSidebarAdmin";
            panelSidebarAdmin.Size = new Size(172, 434);
            panelSidebarAdmin.TabIndex = 0;
            // 
            // btnKeluarAdmin
            // 
            btnKeluarAdmin.Location = new Point(10, 397);
            btnKeluarAdmin.Name = "btnKeluarAdmin";
            btnKeluarAdmin.Size = new Size(94, 29);
            btnKeluarAdmin.TabIndex = 4;
            btnKeluarAdmin.Text = "Logout";
            btnKeluarAdmin.UseVisualStyleBackColor = true;
            // 
            // btnBahanBakuAdmin1
            // 
            btnBahanBakuAdmin1.Location = new Point(10, 85);
            btnBahanBakuAdmin1.Name = "btnBahanBakuAdmin1";
            btnBahanBakuAdmin1.Size = new Size(94, 29);
            btnBahanBakuAdmin1.TabIndex = 3;
            btnBahanBakuAdmin1.Text = "Bahan Baku";
            btnBahanBakuAdmin1.UseVisualStyleBackColor = true;
            // 
            // btnDasboardAdmin1
            // 
            btnDasboardAdmin1.Location = new Point(10, 50);
            btnDasboardAdmin1.Name = "btnDasboardAdmin1";
            btnDasboardAdmin1.Size = new Size(94, 29);
            btnDasboardAdmin1.TabIndex = 2;
            btnDasboardAdmin1.Text = "Dashboard";
            btnDasboardAdmin1.UseVisualStyleBackColor = true;
            // 
            // lblSelamatDatangAdmin
            // 
            lblSelamatDatangAdmin.AutoSize = true;
            lblSelamatDatangAdmin.Location = new Point(3, 0);
            lblSelamatDatangAdmin.Name = "lblSelamatDatangAdmin";
            lblSelamatDatangAdmin.Size = new Size(92, 20);
            lblSelamatDatangAdmin.TabIndex = 1;
            lblSelamatDatangAdmin.Text = "Halo, Admin";
            // 
            // panelKontenAdmin
            // 
            panelKontenAdmin.Controls.Add(lblJudulApp);
            panelKontenAdmin.Location = new Point(204, 12);
            panelKontenAdmin.Name = "panelKontenAdmin";
            panelKontenAdmin.Size = new Size(1296, 398);
            panelKontenAdmin.TabIndex = 1;
            // 
            // lblJudulApp
            // 
            lblJudulApp.AutoSize = true;
            lblJudulApp.Location = new Point(14, 9);
            lblJudulApp.Name = "lblJudulApp";
            lblJudulApp.Size = new Size(94, 20);
            lblJudulApp.TabIndex = 0;
            lblJudulApp.Text = "SIKOPI DOPY";
            // 
            // FormUtamaAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1512, 450);
            Controls.Add(panelKontenAdmin);
            Controls.Add(panelSidebarAdmin);
            Name = "FormUtamaAdmin";
            Text = "FormUtamaAdmin";
            panelSidebarAdmin.ResumeLayout(false);
            panelSidebarAdmin.PerformLayout();
            panelKontenAdmin.ResumeLayout(false);
            panelKontenAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebarAdmin;
        private Button btnKeluarAdmin;
        private Button btnBahanBakuAdmin1;
        private Button btnDasboardAdmin1;
        private Label lblSelamatDatangAdmin;
        private Panel panelKontenAdmin;
        private Label lblJudulApp;
    }
}