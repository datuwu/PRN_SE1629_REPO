using DataAccess.Repository;
using Nancy.Json;
using SalesWinApp;
using System;
using System.IO;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        public bool UserSuccessfullyAuthenticated { get; private set; }
        public bool isAdmin { get; private set; }
        public int id { get; private set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string json = string.Empty;

            // read json string from file
            using (StreamReader reader = new StreamReader("appsettings.json"))
            {
                json = reader.ReadToEnd();
            }

            JavaScriptSerializer jss = new JavaScriptSerializer();

            // convert json string to dynamic type
            var obj = jss.Deserialize<dynamic>(json);

            // get contents
            string Email = obj["DefaultAccount"]["Email"];
            string Password = obj["DefaultAccount"]["password"];
            bool isMem = false;

            if (Email.Equals(txtUserName.Text) && Password.Equals(txtPassword.Text))
            {
                frmMain frm = new frmMain()
                {
                    isAdmin = true
                };
                Close();
                UserSuccessfullyAuthenticated = true;
                isAdmin = true;
                isMem = true;
            }

            // add employees to richtextbox

            var members = memberRepository.GetMembers();

            foreach (var i in members)
            {
                if (i.CompanyName.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text) || i.Email.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text))
                {
                    frmMain frm = new frmMain()
                    {
                        isAdmin = false
                    };
                    Close();
                    UserSuccessfullyAuthenticated = true;
                    isAdmin = false;
                    id = i.MemberId;
                    isMem = true;
                }
            }
            if (isMem == true)
            {
                MessageBox.Show("Login Success", "Right user");
            }
            else
            {
                MessageBox.Show("Wrong user name or pass word, please try again", "Wrong user");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    }
}
