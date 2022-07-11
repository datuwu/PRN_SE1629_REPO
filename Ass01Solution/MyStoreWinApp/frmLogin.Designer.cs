namespace MyStoreWinApp
{
    partial class frmLogin
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
            this.ibEmail = new System.Windows.Forms.Label();
            this.ibPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ibEmail
            // 
            this.ibEmail.AutoSize = true;
            this.ibEmail.Location = new System.Drawing.Point(127, 67);
            this.ibEmail.Name = "ibEmail";
            this.ibEmail.Size = new System.Drawing.Size(46, 20);
            this.ibEmail.TabIndex = 0;
            this.ibEmail.Text = "Email";
            // 
            // ibPassword
            // 
            this.ibPassword.AutoSize = true;
            this.ibPassword.Location = new System.Drawing.Point(118, 151);
            this.ibPassword.Name = "ibPassword";
            this.ibPassword.Size = new System.Drawing.Size(70, 20);
            this.ibPassword.TabIndex = 1;
            this.ibPassword.Text = "Password";
            this.ibPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(233, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(233, 151);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '1';
            this.txtPassword.Size = new System.Drawing.Size(181, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(118, 257);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(94, 29);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "&Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(320, 257);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.ibPassword);
            this.Controls.Add(this.ibEmail);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ibEmail;
        private Label ibPassword;
        private MaskedTextBox txtEmail;
        private MaskedTextBox txtPassword;
        private Button btnLog;
        private Button btnClose;
    }
}