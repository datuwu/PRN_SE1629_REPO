using MyStoreWinApp;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public bool isAdmin { get; set; }
        public int id { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void memberToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
           if (!CheckExistForm("frmMemberManagements"))
           {
                frmMemberManagements frm = new frmMemberManagements() { isAdmin = this.isAdmin, id = this.id};
                frm.MdiParent = this;
                frm.Show();
           }
           else ActiveChildForm("frmMemberManagements");
        }

        private void productToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckExistForm("frmProductManagements"))
            {
                frmProductManagements frm = new frmProductManagements() { isAdmin = this.isAdmin };
                frm.MdiParent = this;
                frm.Show();
            }
            else ActiveChildForm("frmProductManagements");
        }

        private void orderToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckExistForm("frmOrderManagements"))
            {
                frmOrderManagements frm = new frmOrderManagements() { isAdmin = this.isAdmin, id = this.id };
                frm.MdiParent = this;
                frm.Show();
            }
            else ActiveChildForm("frmOrderManagements");

        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm (string name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {

        }
    }
}
