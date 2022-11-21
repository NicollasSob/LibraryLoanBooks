namespace LibraryLoanBooks
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.tabPageAuthor = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPagePublishingCompany = new System.Windows.Forms.TabPage();
            this.tabPageTheme = new System.Windows.Forms.TabPage();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.tabPageCient = new System.Windows.Forms.TabPage();
            this.groupBoxSearchAuthor = new System.Windows.Forms.GroupBox();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.cmbAuthorNationalitySearch = new System.Windows.Forms.ComboBox();
            this.txtAuthorNameSearch = new System.Windows.Forms.TextBox();
            this.lblAuthorNationalitySearch = new System.Windows.Forms.Label();
            this.lblAuthorNameSearch = new System.Windows.Forms.Label();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.pnlPublishingCompany = new System.Windows.Forms.Panel();
            this.btnDeletePublishingCompany = new System.Windows.Forms.Button();
            this.btnEditPublishingCompany = new System.Windows.Forms.Button();
            this.btnNewPublishingCompany = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxSearchPublshingCompany = new System.Windows.Forms.GroupBox();
            this.btnSearchPublishingCompany = new System.Windows.Forms.Button();
            this.cmbPublishingCompanyNationalitySearch = new System.Windows.Forms.ComboBox();
            this.txtPublishingCompanyNameSearch = new System.Windows.Forms.TextBox();
            this.lblPublishingCompanyNationalitySearch = new System.Windows.Forms.Label();
            this.lblPublishingCompanyNameSearch = new System.Windows.Forms.Label();
            this.dataGridPublishingCompany = new System.Windows.Forms.DataGridView();
            this.pnlTheme = new System.Windows.Forms.Panel();
            this.dataGridViewTheme = new System.Windows.Forms.DataGridView();
            this.btnDeleteTheme = new System.Windows.Forms.Button();
            this.btnEditTheme = new System.Windows.Forms.Button();
            this.btnNewTheme = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBoxSearchTheme = new System.Windows.Forms.GroupBox();
            this.btnSearchTheme = new System.Windows.Forms.Button();
            this.txtThemeSearch = new System.Windows.Forms.TextBox();
            this.lblSearchTheme = new System.Windows.Forms.Label();
            this.tabPrincipal.SuspendLayout();
            this.tabPageAuthor.SuspendLayout();
            this.tabPagePublishingCompany.SuspendLayout();
            this.tabPageTheme.SuspendLayout();
            this.groupBoxSearchAuthor.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            this.pnlPublishingCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSearchPublshingCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublishingCompany)).BeginInit();
            this.pnlTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBoxSearchTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPagePrincipal);
            this.tabPrincipal.Controls.Add(this.tabPageAuthor);
            this.tabPrincipal.Controls.Add(this.tabPagePublishingCompany);
            this.tabPrincipal.Controls.Add(this.tabPageTheme);
            this.tabPrincipal.Controls.Add(this.tabPageBook);
            this.tabPrincipal.Controls.Add(this.tabPageCient);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1214, 711);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 24);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(1315, 566);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Principal";
            this.tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // tabPageAuthor
            // 
            this.tabPageAuthor.Controls.Add(this.pnlAuthor);
            this.tabPageAuthor.Controls.Add(this.groupBoxSearchAuthor);
            this.tabPageAuthor.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuthor.Name = "tabPageAuthor";
            this.tabPageAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthor.Size = new System.Drawing.Size(1206, 683);
            this.tabPageAuthor.TabIndex = 1;
            this.tabPageAuthor.Text = "Autores";
            this.tabPageAuthor.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPagePublishingCompany
            // 
            this.tabPagePublishingCompany.Controls.Add(this.pnlPublishingCompany);
            this.tabPagePublishingCompany.Controls.Add(this.groupBoxSearchPublshingCompany);
            this.tabPagePublishingCompany.Location = new System.Drawing.Point(4, 24);
            this.tabPagePublishingCompany.Name = "tabPagePublishingCompany";
            this.tabPagePublishingCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublishingCompany.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePublishingCompany.TabIndex = 2;
            this.tabPagePublishingCompany.Text = "Editoras";
            this.tabPagePublishingCompany.UseVisualStyleBackColor = true;
            // 
            // tabPageTheme
            // 
            this.tabPageTheme.Controls.Add(this.pnlTheme);
            this.tabPageTheme.Controls.Add(this.groupBoxSearchTheme);
            this.tabPageTheme.Location = new System.Drawing.Point(4, 24);
            this.tabPageTheme.Name = "tabPageTheme";
            this.tabPageTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheme.Size = new System.Drawing.Size(1206, 683);
            this.tabPageTheme.TabIndex = 3;
            this.tabPageTheme.Text = "Temas";
            this.tabPageTheme.UseVisualStyleBackColor = true;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Location = new System.Drawing.Point(4, 24);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(1315, 566);
            this.tabPageBook.TabIndex = 4;
            this.tabPageBook.Text = "Livros";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // tabPageCient
            // 
            this.tabPageCient.Location = new System.Drawing.Point(4, 24);
            this.tabPageCient.Name = "tabPageCient";
            this.tabPageCient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCient.Size = new System.Drawing.Size(1315, 566);
            this.tabPageCient.TabIndex = 5;
            this.tabPageCient.Text = "Clientes";
            this.tabPageCient.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchAuthor
            // 
            this.groupBoxSearchAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchAuthor.Controls.Add(this.btnSearchAuthor);
            this.groupBoxSearchAuthor.Controls.Add(this.cmbAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.txtAuthorNameSearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNameSearch);
            this.groupBoxSearchAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAuthor.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSearchAuthor.Name = "groupBoxSearchAuthor";
            this.groupBoxSearchAuthor.Size = new System.Drawing.Size(1190, 123);
            this.groupBoxSearchAuthor.TabIndex = 5;
            this.groupBoxSearchAuthor.TabStop = false;
            this.groupBoxSearchAuthor.Text = "Consulta";
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchAuthor.BackgroundImage")));
            this.btnSearchAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAuthor.Location = new System.Drawing.Point(310, 43);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnSearchAuthor.TabIndex = 9;
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // cmbAuthorNationalitySearch
            // 
            this.cmbAuthorNationalitySearch.FormattingEnabled = true;
            this.cmbAuthorNationalitySearch.Location = new System.Drawing.Point(161, 55);
            this.cmbAuthorNationalitySearch.Name = "cmbAuthorNationalitySearch";
            this.cmbAuthorNationalitySearch.Size = new System.Drawing.Size(134, 29);
            this.cmbAuthorNationalitySearch.TabIndex = 8;
            // 
            // txtAuthorNameSearch
            // 
            this.txtAuthorNameSearch.Location = new System.Drawing.Point(6, 55);
            this.txtAuthorNameSearch.Name = "txtAuthorNameSearch";
            this.txtAuthorNameSearch.Size = new System.Drawing.Size(143, 29);
            this.txtAuthorNameSearch.TabIndex = 7;
            // 
            // lblAuthorNationalitySearch
            // 
            this.lblAuthorNationalitySearch.AutoSize = true;
            this.lblAuthorNationalitySearch.Location = new System.Drawing.Point(161, 31);
            this.lblAuthorNationalitySearch.Name = "lblAuthorNationalitySearch";
            this.lblAuthorNationalitySearch.Size = new System.Drawing.Size(122, 21);
            this.lblAuthorNationalitySearch.TabIndex = 6;
            this.lblAuthorNationalitySearch.Text = "Nacionalidade";
            // 
            // lblAuthorNameSearch
            // 
            this.lblAuthorNameSearch.AutoSize = true;
            this.lblAuthorNameSearch.Location = new System.Drawing.Point(6, 31);
            this.lblAuthorNameSearch.Name = "lblAuthorNameSearch";
            this.lblAuthorNameSearch.Size = new System.Drawing.Size(128, 21);
            this.lblAuthorNameSearch.TabIndex = 5;
            this.lblAuthorNameSearch.Text = "Nome do Autor";
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuthor.BackColor = System.Drawing.Color.LightCoral;
            this.pnlAuthor.Controls.Add(this.btnDeleteAuthor);
            this.pnlAuthor.Controls.Add(this.btnEditAuthor);
            this.pnlAuthor.Controls.Add(this.btnNewAuthor);
            this.pnlAuthor.Controls.Add(this.dataGridViewAuthor);
            this.pnlAuthor.Location = new System.Drawing.Point(3, 132);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(1190, 530);
            this.pnlAuthor.TabIndex = 6;
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(0, 118);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.RowTemplate.Height = 25;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(1190, 412);
            this.dataGridViewAuthor.TabIndex = 0;
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewAuthor.BackgroundImage")));
            this.btnNewAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewAuthor.Location = new System.Drawing.Point(3, 4);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnNewAuthor.TabIndex = 1;
            this.btnNewAuthor.UseVisualStyleBackColor = true;
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditAuthor.BackgroundImage")));
            this.btnEditAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAuthor.Location = new System.Drawing.Point(59, 4);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnEditAuthor.TabIndex = 2;
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAuthor.BackgroundImage")));
            this.btnDeleteAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(115, 4);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteAuthor.TabIndex = 3;
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            // 
            // pnlPublishingCompany
            // 
            this.pnlPublishingCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPublishingCompany.BackColor = System.Drawing.Color.LightCoral;
            this.pnlPublishingCompany.Controls.Add(this.dataGridPublishingCompany);
            this.pnlPublishingCompany.Controls.Add(this.btnDeletePublishingCompany);
            this.pnlPublishingCompany.Controls.Add(this.btnEditPublishingCompany);
            this.pnlPublishingCompany.Controls.Add(this.btnNewPublishingCompany);
            this.pnlPublishingCompany.Controls.Add(this.dataGridView1);
            this.pnlPublishingCompany.Location = new System.Drawing.Point(8, 141);
            this.pnlPublishingCompany.Name = "pnlPublishingCompany";
            this.pnlPublishingCompany.Size = new System.Drawing.Size(1190, 530);
            this.pnlPublishingCompany.TabIndex = 8;
            // 
            // btnDeletePublishingCompany
            // 
            this.btnDeletePublishingCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePublishingCompany.BackgroundImage")));
            this.btnDeletePublishingCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePublishingCompany.Location = new System.Drawing.Point(115, 4);
            this.btnDeletePublishingCompany.Name = "btnDeletePublishingCompany";
            this.btnDeletePublishingCompany.Size = new System.Drawing.Size(50, 50);
            this.btnDeletePublishingCompany.TabIndex = 3;
            this.btnDeletePublishingCompany.UseVisualStyleBackColor = true;
            // 
            // btnEditPublishingCompany
            // 
            this.btnEditPublishingCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditPublishingCompany.BackgroundImage")));
            this.btnEditPublishingCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPublishingCompany.Location = new System.Drawing.Point(59, 4);
            this.btnEditPublishingCompany.Name = "btnEditPublishingCompany";
            this.btnEditPublishingCompany.Size = new System.Drawing.Size(50, 50);
            this.btnEditPublishingCompany.TabIndex = 2;
            this.btnEditPublishingCompany.UseVisualStyleBackColor = true;
            // 
            // btnNewPublishingCompany
            // 
            this.btnNewPublishingCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewPublishingCompany.BackgroundImage")));
            this.btnNewPublishingCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPublishingCompany.Location = new System.Drawing.Point(3, 4);
            this.btnNewPublishingCompany.Name = "btnNewPublishingCompany";
            this.btnNewPublishingCompany.Size = new System.Drawing.Size(50, 50);
            this.btnNewPublishingCompany.TabIndex = 1;
            this.btnNewPublishingCompany.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 548);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(2180, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxSearchPublshingCompany
            // 
            this.groupBoxSearchPublshingCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchPublshingCompany.Controls.Add(this.btnSearchPublishingCompany);
            this.groupBoxSearchPublshingCompany.Controls.Add(this.cmbPublishingCompanyNationalitySearch);
            this.groupBoxSearchPublshingCompany.Controls.Add(this.txtPublishingCompanyNameSearch);
            this.groupBoxSearchPublshingCompany.Controls.Add(this.lblPublishingCompanyNationalitySearch);
            this.groupBoxSearchPublshingCompany.Controls.Add(this.lblPublishingCompanyNameSearch);
            this.groupBoxSearchPublshingCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchPublshingCompany.Location = new System.Drawing.Point(8, 12);
            this.groupBoxSearchPublshingCompany.Name = "groupBoxSearchPublshingCompany";
            this.groupBoxSearchPublshingCompany.Size = new System.Drawing.Size(1190, 123);
            this.groupBoxSearchPublshingCompany.TabIndex = 7;
            this.groupBoxSearchPublshingCompany.TabStop = false;
            this.groupBoxSearchPublshingCompany.Text = "Consulta";
            // 
            // btnSearchPublishingCompany
            // 
            this.btnSearchPublishingCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPublishingCompany.BackgroundImage")));
            this.btnSearchPublishingCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchPublishingCompany.Location = new System.Drawing.Point(310, 43);
            this.btnSearchPublishingCompany.Name = "btnSearchPublishingCompany";
            this.btnSearchPublishingCompany.Size = new System.Drawing.Size(50, 50);
            this.btnSearchPublishingCompany.TabIndex = 9;
            this.btnSearchPublishingCompany.UseVisualStyleBackColor = true;
            // 
            // cmbPublishingCompanyNationalitySearch
            // 
            this.cmbPublishingCompanyNationalitySearch.FormattingEnabled = true;
            this.cmbPublishingCompanyNationalitySearch.Location = new System.Drawing.Point(161, 55);
            this.cmbPublishingCompanyNationalitySearch.Name = "cmbPublishingCompanyNationalitySearch";
            this.cmbPublishingCompanyNationalitySearch.Size = new System.Drawing.Size(134, 29);
            this.cmbPublishingCompanyNationalitySearch.TabIndex = 8;
            // 
            // txtPublishingCompanyNameSearch
            // 
            this.txtPublishingCompanyNameSearch.Location = new System.Drawing.Point(6, 55);
            this.txtPublishingCompanyNameSearch.Name = "txtPublishingCompanyNameSearch";
            this.txtPublishingCompanyNameSearch.Size = new System.Drawing.Size(143, 29);
            this.txtPublishingCompanyNameSearch.TabIndex = 7;
            // 
            // lblPublishingCompanyNationalitySearch
            // 
            this.lblPublishingCompanyNationalitySearch.AutoSize = true;
            this.lblPublishingCompanyNationalitySearch.Location = new System.Drawing.Point(161, 31);
            this.lblPublishingCompanyNationalitySearch.Name = "lblPublishingCompanyNationalitySearch";
            this.lblPublishingCompanyNationalitySearch.Size = new System.Drawing.Size(132, 21);
            this.lblPublishingCompanyNationalitySearch.TabIndex = 6;
            this.lblPublishingCompanyNationalitySearch.Text = "Local da Editora";
            // 
            // lblPublishingCompanyNameSearch
            // 
            this.lblPublishingCompanyNameSearch.AutoSize = true;
            this.lblPublishingCompanyNameSearch.Location = new System.Drawing.Point(6, 31);
            this.lblPublishingCompanyNameSearch.Name = "lblPublishingCompanyNameSearch";
            this.lblPublishingCompanyNameSearch.Size = new System.Drawing.Size(139, 21);
            this.lblPublishingCompanyNameSearch.TabIndex = 5;
            this.lblPublishingCompanyNameSearch.Text = "Nome da Editora";
            // 
            // dataGridPublishingCompany
            // 
            this.dataGridPublishingCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPublishingCompany.Location = new System.Drawing.Point(0, 142);
            this.dataGridPublishingCompany.Name = "dataGridPublishingCompany";
            this.dataGridPublishingCompany.RowTemplate.Height = 25;
            this.dataGridPublishingCompany.Size = new System.Drawing.Size(1190, 385);
            this.dataGridPublishingCompany.TabIndex = 4;
            // 
            // pnlTheme
            // 
            this.pnlTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTheme.BackColor = System.Drawing.Color.LightCoral;
            this.pnlTheme.Controls.Add(this.dataGridViewTheme);
            this.pnlTheme.Controls.Add(this.btnDeleteTheme);
            this.pnlTheme.Controls.Add(this.btnEditTheme);
            this.pnlTheme.Controls.Add(this.btnNewTheme);
            this.pnlTheme.Controls.Add(this.dataGridView3);
            this.pnlTheme.Location = new System.Drawing.Point(8, 141);
            this.pnlTheme.Name = "pnlTheme";
            this.pnlTheme.Size = new System.Drawing.Size(1190, 530);
            this.pnlTheme.TabIndex = 10;
            // 
            // dataGridViewTheme
            // 
            this.dataGridViewTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheme.Location = new System.Drawing.Point(0, 142);
            this.dataGridViewTheme.Name = "dataGridViewTheme";
            this.dataGridViewTheme.RowTemplate.Height = 25;
            this.dataGridViewTheme.Size = new System.Drawing.Size(1190, 385);
            this.dataGridViewTheme.TabIndex = 4;
            // 
            // btnDeleteTheme
            // 
            this.btnDeleteTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteTheme.BackgroundImage")));
            this.btnDeleteTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTheme.Location = new System.Drawing.Point(115, 4);
            this.btnDeleteTheme.Name = "btnDeleteTheme";
            this.btnDeleteTheme.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteTheme.TabIndex = 3;
            this.btnDeleteTheme.UseVisualStyleBackColor = true;
            // 
            // btnEditTheme
            // 
            this.btnEditTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditTheme.BackgroundImage")));
            this.btnEditTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditTheme.Location = new System.Drawing.Point(59, 4);
            this.btnEditTheme.Name = "btnEditTheme";
            this.btnEditTheme.Size = new System.Drawing.Size(50, 50);
            this.btnEditTheme.TabIndex = 2;
            this.btnEditTheme.UseVisualStyleBackColor = true;
            // 
            // btnNewTheme
            // 
            this.btnNewTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewTheme.BackgroundImage")));
            this.btnNewTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewTheme.Location = new System.Drawing.Point(3, 4);
            this.btnNewTheme.Name = "btnNewTheme";
            this.btnNewTheme.Size = new System.Drawing.Size(50, 50);
            this.btnNewTheme.TabIndex = 1;
            this.btnNewTheme.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 978);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(3170, 412);
            this.dataGridView3.TabIndex = 0;
            // 
            // groupBoxSearchTheme
            // 
            this.groupBoxSearchTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchTheme.Controls.Add(this.btnSearchTheme);
            this.groupBoxSearchTheme.Controls.Add(this.txtThemeSearch);
            this.groupBoxSearchTheme.Controls.Add(this.lblSearchTheme);
            this.groupBoxSearchTheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchTheme.Location = new System.Drawing.Point(8, 12);
            this.groupBoxSearchTheme.Name = "groupBoxSearchTheme";
            this.groupBoxSearchTheme.Size = new System.Drawing.Size(1190, 123);
            this.groupBoxSearchTheme.TabIndex = 9;
            this.groupBoxSearchTheme.TabStop = false;
            this.groupBoxSearchTheme.Text = "Consulta";
            // 
            // btnSearchTheme
            // 
            this.btnSearchTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchTheme.BackgroundImage")));
            this.btnSearchTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchTheme.Location = new System.Drawing.Point(168, 43);
            this.btnSearchTheme.Name = "btnSearchTheme";
            this.btnSearchTheme.Size = new System.Drawing.Size(50, 50);
            this.btnSearchTheme.TabIndex = 9;
            this.btnSearchTheme.UseVisualStyleBackColor = true;
            // 
            // txtThemeSearch
            // 
            this.txtThemeSearch.Location = new System.Drawing.Point(6, 55);
            this.txtThemeSearch.Name = "txtThemeSearch";
            this.txtThemeSearch.Size = new System.Drawing.Size(143, 29);
            this.txtThemeSearch.TabIndex = 7;
            // 
            // lblSearchTheme
            // 
            this.lblSearchTheme.AutoSize = true;
            this.lblSearchTheme.Location = new System.Drawing.Point(6, 31);
            this.lblSearchTheme.Name = "lblSearchTheme";
            this.lblSearchTheme.Size = new System.Drawing.Size(139, 21);
            this.lblSearchTheme.TabIndex = 5;
            this.lblSearchTheme.Text = "Nome da Editora";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 711);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageAuthor.ResumeLayout(false);
            this.tabPagePublishingCompany.ResumeLayout(false);
            this.tabPageTheme.ResumeLayout(false);
            this.groupBoxSearchAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.PerformLayout();
            this.pnlAuthor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            this.pnlPublishingCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSearchPublshingCompany.ResumeLayout(false);
            this.groupBoxSearchPublshingCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPublishingCompany)).EndInit();
            this.pnlTheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBoxSearchTheme.ResumeLayout(false);
            this.groupBoxSearchTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabPagePrincipal;
        private TabPage tabPageAuthor;
        private Panel pnlAuthor;
        private Button btnDeleteAuthor;
        private Button btnEditAuthor;
        private Button btnNewAuthor;
        private DataGridView dataGridViewAuthor;
        private GroupBox groupBoxSearchAuthor;
        private Button btnSearchAuthor;
        private ComboBox cmbAuthorNationalitySearch;
        private TextBox txtAuthorNameSearch;
        private Label lblAuthorNationalitySearch;
        private Label lblAuthorNameSearch;
        private TabPage tabPagePublishingCompany;
        private Panel pnlPublishingCompany;
        private DataGridView dataGridPublishingCompany;
        private Button btnDeletePublishingCompany;
        private Button btnEditPublishingCompany;
        private Button btnNewPublishingCompany;
        private DataGridView dataGridView1;
        private GroupBox groupBoxSearchPublshingCompany;
        private Button btnSearchPublishingCompany;
        private ComboBox cmbPublishingCompanyNationalitySearch;
        private TextBox txtPublishingCompanyNameSearch;
        private Label lblPublishingCompanyNationalitySearch;
        private Label lblPublishingCompanyNameSearch;
        private TabPage tabPageTheme;
        private Panel pnlTheme;
        private DataGridView dataGridViewTheme;
        private Button btnDeleteTheme;
        private Button btnEditTheme;
        private Button btnNewTheme;
        private DataGridView dataGridView3;
        private GroupBox groupBoxSearchTheme;
        private Button btnSearchTheme;
        private TextBox txtThemeSearch;
        private Label lblSearchTheme;
        private TabPage tabPageBook;
        private TabPage tabPageCient;
        private StatusStrip statusStrip1;
    }
}