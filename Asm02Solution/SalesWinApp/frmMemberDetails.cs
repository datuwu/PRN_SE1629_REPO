using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        //-----------------------------------------
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member MemberInfor { get; set; }
        //----------------------------------------------
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            cboCity.SelectedIndex = 0;
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)//update mode
            {
                //Show member to perform updating
                txtMemberID.Text = MemberInfor.MemberId.ToString();
                txtMemberName.Text = MemberInfor.CompanyName;
                cboCity.Text = MemberInfor.City;
                txtEmail.Text = MemberInfor.Email;
                cboCountry.Text = MemberInfor.Country;
                txtPassword.Text = MemberInfor.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean check = false;
                var list = MemberRepository.GetMembers();
                foreach (var i in list)
                {
                    if (txtEmail.Text.Equals(i.Email) && !txtMemberID.Text.Equals(i.MemberId.ToString()))
                    {
                        MessageBox.Show("This email exists. Please check again!", InsertOrUpdate == false ? "Add a new Member" : "Update a Member");
                        check = true;
                    }
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^(?!\s*$).+")
                    && System.Text.RegularExpressions.Regex.IsMatch(txtMemberID.Text, @"^(?!\s*$).+")
                    && System.Text.RegularExpressions.Regex.IsMatch(txtMemberName.Text, @"^(?!\s*$).+")
                    && System.Text.RegularExpressions.Regex.IsMatch(cboCity.Text, @"^(?!\s*$).+")
                    && System.Text.RegularExpressions.Regex.IsMatch(cboCountry.Text, @"^(?!\s*$).+")
                    && System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"^(?!\s*$).+")&&check==false)
                {
                    var member = new Member
                    {
                        MemberId = int.Parse(txtMemberID.Text),
                        CompanyName = txtMemberName.Text,
                        City = cboCity.Text,
                        Email = txtEmail.Text,
                        Country = cboCountry.Text,
                        Password = txtPassword.Text,
                    };
                    if (InsertOrUpdate == false)
                    {
                        MemberRepository.InsertMember(member);
                    }
                    else
                    {
                        MemberRepository.UpdateMember(member);
                    }
                }
                else
                {
                    MessageBox.Show("Please double check every fields must not be null, empty or spaces only!", InsertOrUpdate == false ? "Add a new Member" : "Update a Member");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Member" : "Update a Member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
       
    }
}
