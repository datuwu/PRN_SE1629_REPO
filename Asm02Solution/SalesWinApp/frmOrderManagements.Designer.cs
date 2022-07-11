
namespace SalesWinApp
{
    partial class frmOrderManagements
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
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.txtToNum = new System.Windows.Forms.TextBox();
            this.lbReport = new System.Windows.Forms.Label();
            this.txtFromNum = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(408, 72);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(219, 23);
            this.txtFreight.TabIndex = 63;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(408, 40);
            this.txtShippedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(219, 23);
            this.txtShippedDate.TabIndex = 62;
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(8, 184);
            this.dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMemberList.MultiSelect = false;
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(616, 256);
            this.dgvMemberList.TabIndex = 61;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(8, 120);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 22);
            this.btnLoad.TabIndex = 60;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(96, 120);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 22);
            this.btnNew.TabIndex = 59;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(184, 120);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 22);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(80, 72);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(216, 23);
            this.txtOrderDate.TabIndex = 57;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(80, 40);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(216, 23);
            this.txtMemberID.TabIndex = 56;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(80, 8);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(216, 23);
            this.txtOrderID.TabIndex = 55;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(408, 8);
            this.txtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(219, 23);
            this.txtRequiredDate.TabIndex = 54;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(320, 16);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(81, 15);
            this.lbRequiredDate.TabIndex = 53;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(320, 80);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
            this.lbFreight.TabIndex = 52;
            this.lbFreight.Text = "Freight";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(320, 48);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(77, 15);
            this.lbCountry.TabIndex = 51;
            this.lbCountry.Text = "Shipped Date";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(8, 48);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(66, 15);
            this.lbMemberID.TabIndex = 50;
            this.lbMemberID.Text = "Member ID";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(8, 80);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(64, 15);
            this.lbOrderDate.TabIndex = 49;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(8, 16);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(51, 15);
            this.lbOrderID.TabIndex = 48;
            this.lbOrderID.Text = "Order ID";
            // 
            // txtToNum
            // 
            this.txtToNum.Location = new System.Drawing.Point(424, 152);
            this.txtToNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToNum.Name = "txtToNum";
            this.txtToNum.PlaceholderText = "To Date";
            this.txtToNum.Size = new System.Drawing.Size(112, 23);
            this.txtToNum.TabIndex = 81;
            // 
            // lbReport
            // 
            this.lbReport.AutoSize = true;
            this.lbReport.Location = new System.Drawing.Point(320, 128);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(71, 15);
            this.lbReport.TabIndex = 80;
            this.lbReport.Text = "Sales Report";
            // 
            // txtFromNum
            // 
            this.txtFromNum.Location = new System.Drawing.Point(424, 120);
            this.txtFromNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFromNum.Name = "txtFromNum";
            this.txtFromNum.PlaceholderText = "From Date";
            this.txtFromNum.Size = new System.Drawing.Size(112, 23);
            this.txtFromNum.TabIndex = 79;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(544, 152);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 78;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmOrderManagements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.txtToNum);
            this.Controls.Add(this.lbReport);
            this.Controls.Add(this.txtFromNum);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmOrderManagements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Managements";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrderManagements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.TextBox txtToNum;
        private System.Windows.Forms.Label lbReport;
        private System.Windows.Forms.TextBox txtFromNum;
        private System.Windows.Forms.Button btnSearch;
    }
}