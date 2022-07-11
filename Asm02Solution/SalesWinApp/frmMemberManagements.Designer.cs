
namespace MyStoreWinApp
{
    partial class frmMemberManagements
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
            this.cboSearchCountry = new System.Windows.Forms.ComboBox();
            this.cboSearchCity = new System.Windows.Forms.ComboBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSearchCountry
            // 
            this.cboSearchCountry.FormattingEnabled = true;
            this.cboSearchCountry.Items.AddRange(new object[] {
            "All country",
            "United State",
            "Viet Nam",
            "America",
            "United Kingdom",
            "United State",
            "Viet Nam",
            "America",
            "United Kingdom"});
            this.cboSearchCountry.Location = new System.Drawing.Point(320, 120);
            this.cboSearchCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSearchCountry.Name = "cboSearchCountry";
            this.cboSearchCountry.Size = new System.Drawing.Size(103, 23);
            this.cboSearchCountry.TabIndex = 49;
            this.cboSearchCountry.Text = "Country";
            // 
            // cboSearchCity
            // 
            this.cboSearchCity.FormattingEnabled = true;
            this.cboSearchCity.Items.AddRange(new object[] {
            "All city",
            "Ho Chi Minh",
            "Da Nang",
            "Ha Noi",
            "Phu Quoc",
            "Vung Tau",
            "Ho Chi Minh",
            "Da Nang",
            "Ha Noi",
            "Phu Quoc",
            "Vung Tau"});
            this.cboSearchCity.Location = new System.Drawing.Point(432, 120);
            this.cboSearchCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSearchCity.Name = "cboSearchCity";
            this.cboSearchCity.Size = new System.Drawing.Size(104, 23);
            this.cboSearchCity.TabIndex = 50;
            this.cboSearchCity.Text = "City";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(8, 16);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(18, 15);
            this.lbMemberID.TabIndex = 25;
            this.lbMemberID.Text = "ID";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(8, 80);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 28;
            this.lbPassword.Text = "Password";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(8, 48);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(39, 15);
            this.lbMemberName.TabIndex = 27;
            this.lbMemberName.Text = "Name";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(352, 48);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 36;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(352, 80);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 37;
            this.lbCity.Text = "City";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(352, 16);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(408, 8);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 23);
            this.txtEmail.TabIndex = 38;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(72, 8);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(216, 23);
            this.txtMemberID.TabIndex = 32;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(72, 40);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(216, 23);
            this.txtMemberName.TabIndex = 33;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(72, 72);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(214, 23);
            this.txtPassword.TabIndex = 34;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "HCM",
            "Da Nang",
            "Ha Noi",
            "Phu Quoc",
            "Vung Tau"});
            this.cboCity.Location = new System.Drawing.Point(408, 72);
            this.cboCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(219, 23);
            this.cboCity.TabIndex = 45;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(184, 120);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 22);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(96, 120);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 22);
            this.btnNew.TabIndex = 47;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(8, 120);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 22);
            this.btnLoad.TabIndex = 46;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(272, 424);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 22);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(8, 184);
            this.dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(616, 232);
            this.dgvMemberList.TabIndex = 55;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(168, 152);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Member";
            this.txtSearch.Size = new System.Drawing.Size(368, 23);
            this.txtSearch.TabIndex = 53;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(544, 152);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Viet Nam",
            "America",
            "United State",
            "United Kingdom"});
            this.cboCountry.Location = new System.Drawing.Point(408, 40);
            this.cboCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(219, 23);
            this.cboCountry.TabIndex = 44;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(544, 120);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(82, 22);
            this.btnFind.TabIndex = 51;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(72, 160);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(86, 15);
            this.lbSearch.TabIndex = 57;
            this.lbSearch.Text = "Input ID/Name";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(408, 40);
            this.txtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(203, 23);
            this.txtRequiredDate.TabIndex = 58;
            // 
            // frmMemberManagements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cboSearchCity);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.cboSearchCountry);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbMemberID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMemberManagements";
            this.Text = "Member Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMemberManagements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearchCountry;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboSearchCity;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtRequiredDate;
    }
}

