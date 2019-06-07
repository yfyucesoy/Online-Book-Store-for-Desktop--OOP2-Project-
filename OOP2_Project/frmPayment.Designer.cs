namespace OOP2_Project
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.tlpPayment1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tlpPayment2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPayment3 = new System.Windows.Forms.TableLayoutPanel();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioCC = new System.Windows.Forms.RadioButton();
            this.tlpPayment4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCCInfo = new System.Windows.Forms.Label();
            this.mtxtCC = new System.Windows.Forms.MaskedTextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFatura = new System.Windows.Forms.Label();
            this.cmbInvoice = new System.Windows.Forms.ComboBox();
            this.tlpPayment1.SuspendLayout();
            this.tlpPayment2.SuspendLayout();
            this.tlpPayment3.SuspendLayout();
            this.tlpPayment4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPayment1
            // 
            this.tlpPayment1.BackColor = System.Drawing.Color.Khaki;
            this.tlpPayment1.ColumnCount = 1;
            this.tlpPayment1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPayment1.Controls.Add(this.lblInfo, 0, 0);
            this.tlpPayment1.Controls.Add(this.tlpPayment2, 0, 1);
            this.tlpPayment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPayment1.Location = new System.Drawing.Point(0, 0);
            this.tlpPayment1.Name = "tlpPayment1";
            this.tlpPayment1.RowCount = 3;
            this.tlpPayment1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpPayment1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpPayment1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPayment1.Size = new System.Drawing.Size(491, 462);
            this.tlpPayment1.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(3, 66);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(485, 22);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpPayment2
            // 
            this.tlpPayment2.BackColor = System.Drawing.Color.Khaki;
            this.tlpPayment2.ColumnCount = 3;
            this.tlpPayment2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPayment2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpPayment2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPayment2.Controls.Add(this.tlpPayment3, 1, 0);
            this.tlpPayment2.Controls.Add(this.tlpPayment4, 1, 1);
            this.tlpPayment2.Controls.Add(this.lblTotalPrice, 1, 2);
            this.tlpPayment2.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tlpPayment2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPayment2.Location = new System.Drawing.Point(3, 157);
            this.tlpPayment2.Name = "tlpPayment2";
            this.tlpPayment2.RowCount = 4;
            this.tlpPayment2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPayment2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPayment2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPayment2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPayment2.Size = new System.Drawing.Size(485, 281);
            this.tlpPayment2.TabIndex = 4;
            // 
            // tlpPayment3
            // 
            this.tlpPayment3.BackColor = System.Drawing.Color.Khaki;
            this.tlpPayment3.ColumnCount = 2;
            this.tlpPayment3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayment3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayment3.Controls.Add(this.radioCash, 1, 0);
            this.tlpPayment3.Controls.Add(this.radioCC, 0, 0);
            this.tlpPayment3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPayment3.Location = new System.Drawing.Point(51, 3);
            this.tlpPayment3.Name = "tlpPayment3";
            this.tlpPayment3.RowCount = 1;
            this.tlpPayment3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayment3.Size = new System.Drawing.Size(382, 64);
            this.tlpPayment3.TabIndex = 1;
            // 
            // radioCash
            // 
            this.radioCash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioCash.AutoSize = true;
            this.radioCash.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioCash.Location = new System.Drawing.Point(252, 3);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(68, 26);
            this.radioCash.TabIndex = 1;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Nakit";
            this.radioCash.UseVisualStyleBackColor = true;
            this.radioCash.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioCC
            // 
            this.radioCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioCC.AutoSize = true;
            this.radioCC.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioCC.Location = new System.Drawing.Point(40, 3);
            this.radioCC.Name = "radioCC";
            this.radioCC.Size = new System.Drawing.Size(110, 26);
            this.radioCC.TabIndex = 0;
            this.radioCC.TabStop = true;
            this.radioCC.Text = "Kredi Kartı";
            this.radioCC.UseVisualStyleBackColor = true;
            this.radioCC.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tlpPayment4
            // 
            this.tlpPayment4.ColumnCount = 1;
            this.tlpPayment4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayment4.Controls.Add(this.lblCCInfo, 0, 0);
            this.tlpPayment4.Controls.Add(this.mtxtCC, 0, 1);
            this.tlpPayment4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPayment4.Location = new System.Drawing.Point(51, 73);
            this.tlpPayment4.Name = "tlpPayment4";
            this.tlpPayment4.RowCount = 2;
            this.tlpPayment4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayment4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPayment4.Size = new System.Drawing.Size(382, 64);
            this.tlpPayment4.TabIndex = 2;
            this.tlpPayment4.Visible = false;
            // 
            // lblCCInfo
            // 
            this.lblCCInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCCInfo.AutoSize = true;
            this.lblCCInfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCCInfo.Location = new System.Drawing.Point(3, 5);
            this.lblCCInfo.Name = "lblCCInfo";
            this.lblCCInfo.Size = new System.Drawing.Size(230, 22);
            this.lblCCInfo.TabIndex = 3;
            this.lblCCInfo.Text = "Kredi Kartı Numarası Giriniz:";
            // 
            // mtxtCC
            // 
            this.mtxtCC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtxtCC.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtCC.Location = new System.Drawing.Point(3, 35);
            this.mtxtCC.Mask = "0000-0000-0000-0000";
            this.mtxtCC.Name = "mtxtCC";
            this.mtxtCC.Size = new System.Drawing.Size(190, 26);
            this.mtxtCC.TabIndex = 4;
            this.mtxtCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(433, 164);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 22);
            this.lblTotalPrice.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Controls.Add(this.btnOdeme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 213);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 65);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdeme.BackgroundImage")));
            this.btnOdeme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOdeme.FlatAppearance.BorderSize = 0;
            this.btnOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdeme.Location = new System.Drawing.Point(236, 3);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(143, 59);
            this.btnOdeme.TabIndex = 4;
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblFatura, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbInvoice, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(227, 59);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblFatura
            // 
            this.lblFatura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFatura.AutoSize = true;
            this.lblFatura.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFatura.Location = new System.Drawing.Point(3, 3);
            this.lblFatura.Name = "lblFatura";
            this.lblFatura.Size = new System.Drawing.Size(108, 22);
            this.lblFatura.TabIndex = 5;
            this.lblFatura.Text = "Fatura Bilgisi";
            // 
            // cmbInvoice
            // 
            this.cmbInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInvoice.FormattingEnabled = true;
            this.cmbInvoice.Items.AddRange(new object[] {
            "Faturamı e-posta adresime yolla",
            "Faturamı SMS olarak yolla"});
            this.cmbInvoice.Location = new System.Drawing.Point(3, 32);
            this.cmbInvoice.Name = "cmbInvoice";
            this.cmbInvoice.Size = new System.Drawing.Size(221, 21);
            this.cmbInvoice.TabIndex = 0;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 462);
            this.Controls.Add(this.tlpPayment1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Sayfası";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.tlpPayment1.ResumeLayout(false);
            this.tlpPayment1.PerformLayout();
            this.tlpPayment2.ResumeLayout(false);
            this.tlpPayment2.PerformLayout();
            this.tlpPayment3.ResumeLayout(false);
            this.tlpPayment3.PerformLayout();
            this.tlpPayment4.ResumeLayout(false);
            this.tlpPayment4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPayment1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel tlpPayment2;
        private System.Windows.Forms.RadioButton radioCC;
        private System.Windows.Forms.TableLayoutPanel tlpPayment3;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.TableLayoutPanel tlpPayment4;
        private System.Windows.Forms.Label lblCCInfo;
        private System.Windows.Forms.MaskedTextBox mtxtCC;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFatura;
        private System.Windows.Forms.ComboBox cmbInvoice;
    }
}