using System;
using BusinessObject;
using System.Windows.Forms;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public IMemberRepository memberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member MemberInfor { get; set; }
        public Member loginMember { get; set; }
        public bool isAdmin { get; set; }
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            cboCity.SelectedIndex = 0;
            cboCountry.SelectedIndex = 0;

            txtMemberID.Enabled = !InsertOrUpdate;
            if (!isAdmin && !loginMember.Email.Equals(MemberInfor.Email))
            {
                txtEmail.Enabled = false;
                txtMemberName.Enabled = false;
                txtPassword.Enabled = false;
                txtMemberID.Enabled = false;
                cboCity.Enabled = false;
                cboCountry.Enabled = false;
            }
            //Update mode
            if (InsertOrUpdate == true)
            {
                //Show member to perform updating
                txtMemberID.Text = MemberInfor.MemberID.ToString();
                txtMemberName.Text = MemberInfor.MemberName;
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
                var member = new Member
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = cboCity.Text,
                    Country = cboCountry.Text,
                };
                if (InsertOrUpdate == false)
                {
                    memberRepository.InsertMember(member);
                }
                else
                {
                    memberRepository.UpdateMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
