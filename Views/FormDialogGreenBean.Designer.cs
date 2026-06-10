namespace SIKOPI_DOPY_MVC_GREENBEAN.Views
{
    partial class FormDialogGreenBean
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
            label1 = new Label();
            txtNamaGreenBean = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtOrigin = new TextBox();
            cmbBeanType = new ComboBox();
            cmbProcessMethod = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmbGrade = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtStockKg = new TextBox();
            txtPricePerKg = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama Green Bean";
            // 
            // txtNamaGreenBean
            // 
            txtNamaGreenBean.Location = new Point(30, 32);
            txtNamaGreenBean.Name = "txtNamaGreenBean";
            txtNamaGreenBean.Size = new Size(125, 27);
            txtNamaGreenBean.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 63);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 2;
            label2.Text = "Asal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 123);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 3;
            label3.Text = "Jenis";
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(30, 86);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(125, 27);
            txtOrigin.TabIndex = 5;
            // 
            // cmbBeanType
            // 
            cmbBeanType.FormattingEnabled = true;
            cmbBeanType.Location = new Point(30, 146);
            cmbBeanType.Name = "cmbBeanType";
            cmbBeanType.Size = new Size(151, 28);
            cmbBeanType.TabIndex = 6;
            // 
            // cmbProcessMethod
            // 
            cmbProcessMethod.FormattingEnabled = true;
            cmbProcessMethod.Location = new Point(30, 208);
            cmbProcessMethod.Name = "cmbProcessMethod";
            cmbProcessMethod.Size = new Size(151, 28);
            cmbProcessMethod.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 185);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 4;
            label4.Text = "Metode Proses";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 245);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 8;
            label5.Text = "Kualitas";
            // 
            // cmbGrade
            // 
            cmbGrade.FormattingEnabled = true;
            cmbGrade.Location = new Point(30, 268);
            cmbGrade.Name = "cmbGrade";
            cmbGrade.Size = new Size(151, 28);
            cmbGrade.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 306);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 10;
            label6.Text = "Stok";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 367);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 11;
            label7.Text = "Harga";
            // 
            // txtStockKg
            // 
            txtStockKg.Location = new Point(34, 329);
            txtStockKg.Name = "txtStockKg";
            txtStockKg.Size = new Size(125, 27);
            txtStockKg.TabIndex = 12;
            // 
            // txtPricePerKg
            // 
            txtPricePerKg.Location = new Point(34, 390);
            txtPricePerKg.Name = "txtPricePerKg";
            txtPricePerKg.Size = new Size(125, 27);
            txtPricePerKg.TabIndex = 13;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(576, 492);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 14;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(87, 492);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 15;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // FormDialogGreenBean
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtPricePerKg);
            Controls.Add(txtStockKg);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbGrade);
            Controls.Add(label5);
            Controls.Add(cmbProcessMethod);
            Controls.Add(cmbBeanType);
            Controls.Add(txtOrigin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNamaGreenBean);
            Controls.Add(label1);
            Name = "FormDialogGreenBean";
            Text = "FormDialogGreenBean";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNamaGreenBean;
        private Label label2;
        private Label label3;
        private TextBox txtOrigin;
        private ComboBox cmbBeanType;
        private ComboBox cmbProcessMethod;
        private Label label4;
        private Label label5;
        private ComboBox cmbGrade;
        private Label label6;
        private Label label7;
        private TextBox txtStockKg;
        private TextBox txtPricePerKg;
        private Button btnSimpan;
        private Button btnBatal;
    }
}