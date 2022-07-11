using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using BusinessObject;
using System.Windows.Forms;
using System.ComponentModel;
using DataAccess.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        public bool isAdmin { get; set; }
        public int id { get; set; }
        public Member loginMember { get; set; }

        IMemberRepository memberRepository = new MemberRepository();
        //Create a data source
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add member",
                InsertOrUpdate = false,
                memberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //Set focus member inserted
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FilterMember();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOneMember();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
                cboCity.Enabled = false;
                cboCountry.Enabled = false;
                txtEmail.Enabled = false;
                txtMemberID.Enabled = false;
                txtMemberName.Enabled = false;
                txtPassword.Enabled = false;

                dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
            }
            else
            {


                //Register this event to open the frmMemberDetail form that performs updating
                dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
            }


        }
        private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfor = GetMemberObject(),
                memberRepository = memberRepository,
                loginMember = new Member
                {
                    Email = loginMember.Email,
                    Password = loginMember.Password,
                },
                isAdmin = isAdmin                
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //Set focus member updated
                source.Position = source.Count - 1;
            }
        }
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cboCountry.Text = string.Empty;
            cboCity.Text = string.Empty;
        }
        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    City = cboCity.Text,
                    Country = cboCountry.Text,

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }
        public void LoadMemberList()
        {
            var members = memberRepository.GetMembers();

            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                /* if (isAdmin == false)
                 {
                     source.DataSource = memberRepository.GetMemberByID(this.id);
                 }*/
                //else
                //{
                source.DataSource = members.OrderByDescending(members => members.MemberName);
                //}
                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                cboCountry.DataBindings.Clear();
                cboCity.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                cboCountry.DataBindings.Add("Text", source, "Country");
                cboCity.DataBindings.Add("Text", source, "City");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (isAdmin == false)
                {
                    if (members.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
                else
                {
                    if (members.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private void LoadOneMember()
        {
            Member member = new Member();
            var members = memberRepository.GetMembers();
            try
            {
                foreach (var i in members)
                {
                    //The BindingSource omponent is designed to simplify
                    //the process of binding controls to an underlying data source
                    if (i.MemberName.Equals(txtSearch.Text))
                    {
                        source = new BindingSource();


                        source.DataSource = memberRepository.GetMemberByID(i.MemberID);

                        txtMemberID.DataBindings.Clear();
                        txtMemberName.DataBindings.Clear();
                        txtPassword.DataBindings.Clear();
                        txtEmail.DataBindings.Clear();
                        cboCountry.DataBindings.Clear();
                        cboCity.DataBindings.Clear();

                        txtMemberID.DataBindings.Add("Text", source, "MemberID");
                        txtMemberName.DataBindings.Add("Text", source, "MemberName");
                        txtPassword.DataBindings.Add("Text", source, "Password");
                        txtEmail.DataBindings.Add("Text", source, "Email");
                        cboCountry.DataBindings.Add("Text", source, "Country");
                        cboCity.DataBindings.Add("Text", source, "City");


                        dgvMemberList.DataSource = null;
                        dgvMemberList.DataSource = source;
                        break;
                    }
                    else if (i.MemberID.ToString().Contains(txtSearch.Text))
                    {
                        source = new BindingSource();


                        source.DataSource = memberRepository.GetMemberByID(i.MemberID);

                        txtMemberID.DataBindings.Clear();
                        txtMemberName.DataBindings.Clear();
                        txtPassword.DataBindings.Clear();
                        txtEmail.DataBindings.Clear();
                        cboCountry.DataBindings.Clear();
                        cboCity.DataBindings.Clear();

                        txtMemberID.DataBindings.Add("Text", source, "MemberID");
                        txtMemberName.DataBindings.Add("Text", source, "MemberName");
                        txtPassword.DataBindings.Add("Text", source, "Password");
                        txtEmail.DataBindings.Add("Text", source, "Email");
                        cboCountry.DataBindings.Add("Text", source, "Country");
                        cboCity.DataBindings.Add("Text", source, "City");


                        dgvMemberList.DataSource = null;
                        dgvMemberList.DataSource = source;

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private void FilterMember()
         {
            Member member = new Member();
            var members = memberRepository.GetCityAndCountry(cboSearchCity.Text, cboSearchCountry.Text);

            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmail.DataBindings.Clear();

                cboCity.DataBindings.Clear();
                cboCountry.DataBindings.Clear();


                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");

                cboCity.DataBindings.Add("Text", source, "City");
                cboCountry.DataBindings.Add("Text", source, "Country");


                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

    }
}
