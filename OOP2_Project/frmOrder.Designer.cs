namespace OOP2_Project
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.splitter = new System.Windows.Forms.Splitter();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnSepet = new System.Windows.Forms.Button();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMagazine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMusicCD = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpCart5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrdNo2 = new System.Windows.Forms.Label();
            this.lblPrdName2 = new System.Windows.Forms.Label();
            this.lblPrdPrice2 = new System.Windows.Forms.Label();
            this.lblPrdNo1 = new System.Windows.Forms.Label();
            this.lblPrdName1 = new System.Windows.Forms.Label();
            this.lblPrdPrice1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tlpCart4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tlpCart3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tlpCart1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCart2 = new System.Windows.Forms.TableLayoutPanel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tlpCart5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tlpCart4.SuspendLayout();
            this.tlpCart3.SuspendLayout();
            this.tlpCart1.SuspendLayout();
            this.tlpCart2.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter.Location = new System.Drawing.Point(135, 3);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(1, 32);
            this.splitter.TabIndex = 5;
            this.splitter.TabStop = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(1076, 614);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 22);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSepet
            // 
            this.btnSepet.BackColor = System.Drawing.Color.Khaki;
            this.btnSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSepet.FlatAppearance.BorderSize = 0;
            this.btnSepet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSepet.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSepet.Location = new System.Drawing.Point(3, 3);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(126, 32);
            this.btnSepet.TabIndex = 4;
            this.btnSepet.Text = "CART";
            this.btnSepet.UseVisualStyleBackColor = false;
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // tsmMenu
            // 
            this.tsmMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBook,
            this.tsmMagazine,
            this.tsmMusicCD});
            this.tsmMenu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsmMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(103, 40);
            this.tsmMenu.Text = "Categories";
            // 
            // tsmBook
            // 
            this.tsmBook.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmBook.Image")));
            this.tsmBook.Name = "tsmBook";
            this.tsmBook.Size = new System.Drawing.Size(180, 26);
            this.tsmBook.Text = "BOOK";
            this.tsmBook.Click += new System.EventHandler(this.tsmBook_Click);
            // 
            // tsmMagazine
            // 
            this.tsmMagazine.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmMagazine.Image = ((System.Drawing.Image)(resources.GetObject("tsmMagazine.Image")));
            this.tsmMagazine.Name = "tsmMagazine";
            this.tsmMagazine.Size = new System.Drawing.Size(180, 26);
            this.tsmMagazine.Text = "MAGAZINE";
            this.tsmMagazine.Click += new System.EventHandler(this.tsmMagazine_Click);
            // 
            // tsmMusicCD
            // 
            this.tsmMusicCD.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmMusicCD.Image = ((System.Drawing.Image)(resources.GetObject("tsmMusicCD.Image")));
            this.tsmMusicCD.Name = "tsmMusicCD";
            this.tsmMusicCD.Size = new System.Drawing.Size(180, 26);
            this.tsmMusicCD.Text = "MUSIC CD";
            this.tsmMusicCD.Click += new System.EventHandler(this.tsmMusicCD_Click);
            // 
            // tlpCart5
            // 
            this.tlpCart5.ColumnCount = 5;
            this.tlpCart5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCart5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 512F));
            this.tlpCart5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tlpCart5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tlpCart5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpCart5.Controls.Add(this.lblPrdNo2, 0, 2);
            this.tlpCart5.Controls.Add(this.lblPrdName2, 1, 2);
            this.tlpCart5.Controls.Add(this.lblPrdPrice2, 4, 2);
            this.tlpCart5.Controls.Add(this.lblPrdNo1, 0, 1);
            this.tlpCart5.Controls.Add(this.lblPrdName1, 1, 1);
            this.tlpCart5.Controls.Add(this.lblPrdPrice1, 2, 1);
            this.tlpCart5.Controls.Add(this.btnRemove, 4, 1);
            this.tlpCart5.Controls.Add(this.lblDurum, 3, 1);
            this.tlpCart5.Controls.Add(this.label1, 0, 0);
            this.tlpCart5.Controls.Add(this.label2, 1, 0);
            this.tlpCart5.Controls.Add(this.label3, 2, 0);
            this.tlpCart5.Controls.Add(this.label4, 3, 0);
            this.tlpCart5.Controls.Add(this.label5, 4, 0);
            this.tlpCart5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCart5.Location = new System.Drawing.Point(3, 103);
            this.tlpCart5.Name = "tlpCart5";
            this.tlpCart5.RowCount = 3;
            this.tlpCart5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCart5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.91566F));
            this.tlpCart5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.08434F));
            this.tlpCart5.Size = new System.Drawing.Size(1073, 499);
            this.tlpCart5.TabIndex = 1;
            // 
            // lblPrdNo2
            // 
            this.lblPrdNo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrdNo2.AutoSize = true;
            this.lblPrdNo2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrdNo2.Location = new System.Drawing.Point(3, 381);
            this.lblPrdNo2.Name = "lblPrdNo2";
            this.lblPrdNo2.Size = new System.Drawing.Size(73, 24);
            this.lblPrdNo2.TabIndex = 7;
            // 
            // lblPrdName2
            // 
            this.lblPrdName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrdName2.AutoSize = true;
            this.lblPrdName2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrdName2.Location = new System.Drawing.Point(82, 381);
            this.lblPrdName2.Name = "lblPrdName2";
            this.lblPrdName2.Size = new System.Drawing.Size(506, 24);
            this.lblPrdName2.TabIndex = 9;
            // 
            // lblPrdPrice2
            // 
            this.lblPrdPrice2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrdPrice2.AutoSize = true;
            this.lblPrdPrice2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrdPrice2.Location = new System.Drawing.Point(1015, 381);
            this.lblPrdPrice2.Name = "lblPrdPrice2";
            this.lblPrdPrice2.Size = new System.Drawing.Size(55, 24);
            this.lblPrdPrice2.TabIndex = 11;
            this.lblPrdPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrdNo1
            // 
            this.lblPrdNo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrdNo1.AutoSize = true;
            this.lblPrdNo1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrdNo1.Location = new System.Drawing.Point(3, 151);
            this.lblPrdNo1.Name = "lblPrdNo1";
            this.lblPrdNo1.Size = new System.Drawing.Size(73, 24);
            this.lblPrdNo1.TabIndex = 0;
            // 
            // lblPrdName1
            // 
            this.lblPrdName1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrdName1.AutoSize = true;
            this.lblPrdName1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrdName1.Location = new System.Drawing.Point(82, 151);
            this.lblPrdName1.Name = "lblPrdName1";
            this.lblPrdName1.Size = new System.Drawing.Size(506, 24);
            this.lblPrdName1.TabIndex = 2;
            // 
            // lblPrdPrice1
            // 
            this.lblPrdPrice1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrdPrice1.AutoSize = true;
            this.lblPrdPrice1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrdPrice1.Location = new System.Drawing.Point(723, 151);
            this.lblPrdPrice1.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.lblPrdPrice1.Name = "lblPrdPrice1";
            this.lblPrdPrice1.Size = new System.Drawing.Size(0, 24);
            this.lblPrdPrice1.TabIndex = 4;
            this.lblPrdPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(1026, 147);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(44, 32);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDurum.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(776, 40);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(233, 247);
            this.lblDurum.TabIndex = 39;
            this.lblDurum.Text = "Status:\r\n\r\n\r\nYour order is preparing...\r\n";
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDurum.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 40);
            this.label1.TabIndex = 40;
            this.label1.Text = "Order No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(82, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 40);
            this.label2.TabIndex = 41;
            this.label2.Text = "Content";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(594, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 40);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(776, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 40);
            this.label4.TabIndex = 43;
            this.label4.Text = "Delivery Information";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1015, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 40);
            this.label5.TabIndex = 44;
            this.label5.Text = "Cancel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoggedUser.Location = new System.Drawing.Point(30, 64);
            this.lblLoggedUser.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(0, 22);
            this.lblLoggedUser.TabIndex = 2;
            this.lblLoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(431, 3);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(101, 32);
            this.btnAra.TabIndex = 2;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // picSearch
            // 
            this.picSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSearch.BackgroundImage")));
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSearch.Location = new System.Drawing.Point(3, 3);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(43, 32);
            this.picSearch.TabIndex = 3;
            this.picSearch.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(90, 38);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // tlpCart4
            // 
            this.tlpCart4.ColumnCount = 3;
            this.tlpCart4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.83871F));
            this.tlpCart4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.16129F));
            this.tlpCart4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlpCart4.Controls.Add(this.splitter, 0, 0);
            this.tlpCart4.Controls.Add(this.btnSepet, 0, 0);
            this.tlpCart4.Controls.Add(this.btnLogOut, 2, 0);
            this.tlpCart4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCart4.Location = new System.Drawing.Point(755, 3);
            this.tlpCart4.Name = "tlpCart4";
            this.tlpCart4.RowCount = 1;
            this.tlpCart4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCart4.Size = new System.Drawing.Size(315, 38);
            this.tlpCart4.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Location = new System.Drawing.Point(142, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(170, 32);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "EXIT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tlpCart3
            // 
            this.tlpCart3.BackColor = System.Drawing.SystemColors.Window;
            this.tlpCart3.ColumnCount = 3;
            this.tlpCart3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.56463F));
            this.tlpCart3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.43537F));
            this.tlpCart3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpCart3.Controls.Add(this.txtSearch, 1, 0);
            this.tlpCart3.Controls.Add(this.btnAra, 2, 0);
            this.tlpCart3.Controls.Add(this.picSearch, 0, 0);
            this.tlpCart3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCart3.Location = new System.Drawing.Point(214, 3);
            this.tlpCart3.Name = "tlpCart3";
            this.tlpCart3.RowCount = 1;
            this.tlpCart3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCart3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCart3.Size = new System.Drawing.Size(535, 38);
            this.tlpCart3.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(52, 8);
            this.txtSearch.MaxLength = 200;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(373, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // tlpCart1
            // 
            this.tlpCart1.ColumnCount = 1;
            this.tlpCart1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCart1.Controls.Add(this.tlpCart2, 0, 0);
            this.tlpCart1.Controls.Add(this.lblLoggedUser, 0, 1);
            this.tlpCart1.Controls.Add(this.tlpCart5, 0, 2);
            this.tlpCart1.Controls.Add(this.lblTotalPrice, 0, 3);
            this.tlpCart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCart1.Location = new System.Drawing.Point(0, 0);
            this.tlpCart1.Name = "tlpCart1";
            this.tlpCart1.RowCount = 5;
            this.tlpCart1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCart1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCart1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCart1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCart1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpCart1.Size = new System.Drawing.Size(1079, 705);
            this.tlpCart1.TabIndex = 2;
            // 
            // tlpCart2
            // 
            this.tlpCart2.ColumnCount = 4;
            this.tlpCart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpCart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80075F));
            this.tlpCart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.55866F));
            this.tlpCart2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.79516F));
            this.tlpCart2.Controls.Add(this.tlpCart3, 2, 0);
            this.tlpCart2.Controls.Add(this.msMenu, 1, 0);
            this.tlpCart2.Controls.Add(this.picLogo, 0, 0);
            this.tlpCart2.Controls.Add(this.tlpCart4, 3, 0);
            this.tlpCart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCart2.Location = new System.Drawing.Point(3, 3);
            this.tlpCart2.Name = "tlpCart2";
            this.tlpCart2.RowCount = 1;
            this.tlpCart2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCart2.Size = new System.Drawing.Size(1073, 44);
            this.tlpCart2.TabIndex = 0;
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.Khaki;
            this.msMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msMenu.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu});
            this.msMenu.Location = new System.Drawing.Point(96, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(115, 44);
            this.msMenu.TabIndex = 2;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1079, 705);
            this.Controls.Add(this.tlpCart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişlerim";
            this.Activated += new System.EventHandler(this.frmOrder_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrder_FormClosed);
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.tlpCart5.ResumeLayout(false);
            this.tlpCart5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tlpCart4.ResumeLayout(false);
            this.tlpCart3.ResumeLayout(false);
            this.tlpCart3.PerformLayout();
            this.tlpCart1.ResumeLayout(false);
            this.tlpCart1.PerformLayout();
            this.tlpCart2.ResumeLayout(false);
            this.tlpCart2.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmBook;
        private System.Windows.Forms.ToolStripMenuItem tsmMagazine;
        private System.Windows.Forms.ToolStripMenuItem tsmMusicCD;
        private System.Windows.Forms.TableLayoutPanel tlpCart5;
        private System.Windows.Forms.Label lblPrdNo2;
        private System.Windows.Forms.Label lblPrdName2;
        private System.Windows.Forms.Label lblPrdPrice2;
        private System.Windows.Forms.Label lblPrdNo1;
        private System.Windows.Forms.Label lblPrdName1;
        private System.Windows.Forms.Label lblPrdPrice1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TableLayoutPanel tlpCart4;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TableLayoutPanel tlpCart3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tlpCart1;
        private System.Windows.Forms.TableLayoutPanel tlpCart2;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}