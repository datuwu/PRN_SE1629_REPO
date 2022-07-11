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
using BusinessObject.Models;

namespace SalesWinApp
{
    public partial class frmOrderManagements : Form
    {
        public bool isAdmin { get; set; }
        public int id { get; set; }

        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;

        public frmOrderManagements()
        {
            InitializeComponent();
        }

        private void frmOrderManagements_Load(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
                btnSearch.Enabled = false;
                txtFreight.Enabled = false;
                txtFromNum.Enabled = false;
                txtMemberID.Enabled = false;
                txtOrderDate.Enabled = false;
                txtOrderID.Enabled = false;
                txtRequiredDate.Enabled = false;
                txtShippedDate.Enabled = false;
                txtToNum.Enabled = false;
                dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            }
            else
            {
                btnDelete.Enabled = false;
                //Register this event to open the frmMemberDetail form that performs updating
                dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            }
        }
        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetails frm = new frmOrderDetails
            {
                isAdmin = this.isAdmin,
                Text = "Update Order",
                InsertOrUpdate = true,
                OrderInfor = GetOrderObject(),
                OrderRepository = orderRepository,
                OrderId = GetOrderObject().OrderId,
                id = this.id
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }

        //Clear text on TextBoxes
        private void ClearText()
        {
            txtFreight.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtOrderID.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
        }
        //-----------------------------------------------
        private Order GetOrderObject()
        {
            Order member = null;

            var reqDate = DateTime.Now;
            var shipDate = DateTime.Now;
            var freight = 0;

            try
            {
                member = new Order
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    ShippedDate = (!txtShippedDate.Text.Equals("")) ? DateTime.Parse(txtShippedDate.Text) : null,
                    RequiredDate = (!txtRequiredDate.Text.Equals("")) ? DateTime.Parse(txtRequiredDate.Text) : null,
                    Freight = (!txtFreight.Text.Equals("")) ? decimal.Parse(txtFreight.Text) : null,
                    MemberId = int.Parse(txtMemberID.Text),
                    //OrderId = int.Parse(txtOrderID.Text),
                    //OrderDate = DateTime.Parse(txtOrderDate.Text),
                    //if (txtShippedDate.Text == null)
                    //ShippedDate = "" ? DateTime.Parse(txtShippedDate.Text) : shipDate,
                    //ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    //RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    //Freight = decimal.Parse(txtFreight.Text),
                    //MemberId = int.Parse(txtMemberID.Text),
                };
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return member;
        }

public void LoadMemberList()
{
    var members = orderRepository.GetOrders();

    try
    {
        //The BindingSource component is designed to simplify
        //the process of binding controls to an underlying data source
        source = new BindingSource();

        if (isAdmin == false)
        {
            source.DataSource = orderRepository.GetOrderListByMemberID(this.id);
        }
        else
        {
            source.DataSource = members.OrderByDescending(member => member.OrderDate);
        }
        txtFreight.DataBindings.Clear();
        txtMemberID.DataBindings.Clear();
        txtOrderDate.DataBindings.Clear();
        txtOrderID.DataBindings.Clear();
        txtRequiredDate.DataBindings.Clear();
        txtShippedDate.DataBindings.Clear();

        txtFreight.DataBindings.Add("Text", source, "Freight");
        txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
        txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
        txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
        txtOrderID.DataBindings.Add("Text", source, "OrderId");
        txtMemberID.DataBindings.Add("Text", source, "MemberId");


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
                btnDelete.Enabled = false;
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
        MessageBox.Show(ex.Message, "Load order list");
    }
}

private void btnLoad_Click(object sender, EventArgs e)
{
    LoadMemberList();
}

private void btnNew_Click(object sender, EventArgs e)
{
    frmOrderDetails frm = new frmOrderDetails
    {
        OrderId = -1,
        isAdmin = this.isAdmin,
        Text = "Add Order",
        InsertOrUpdate = false,
        OrderRepository = orderRepository
    };
    if (frm.ShowDialog() == DialogResult.OK)
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
        var member = GetOrderObject();
        orderRepository.DeleteOrder(member.OrderId);
        LoadMemberList();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Delete an order");
    }
}

private void FilterMember()
{

    Product member = new Product();
    List<Order> filterList = new List<Order>();
    // var members = memberRepository.GetMembers();
    try
    {
        filterList = orderRepository.GetOrderByOrderdDate(DateTime.Parse(txtFromNum.Text), DateTime.Parse(txtToNum.Text));
        //The BindingSource omponent is designed to simplify
        //the process of binding controls to an underlying data source
        // if (i.Country.Equals(this.cboSearchCountry.GetItemText(this.cboSearchCountry.SelectedItem)) && i.City.Equals(this.cboSearchCity.GetItemText(this.cboSearchCity.SelectedItem)))

        /* foreach (var i in members)
         {
          if (i.Country.Equals(cboSearchCountry.Text) && i.City.Equals(cboSearchCity.Text))
             {
                 filterList.Add(i);
             }
             else
             {
                 if (filterList.Count == 0)
                 {
                     MessageBox.Show("No member matched", "No result");
                     break;
                 }
             }
         }*/
        if (filterList.Count == 0)
        {
            MessageBox.Show("No order matched", "No result");
        }
        else if (filterList.Count != 0)
        {
            source = new BindingSource();
            source.DataSource = filterList.OrderByDescending(member => member.OrderDate);
            txtFreight.DataBindings.Clear();
            txtMemberID.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtOrderID.DataBindings.Clear();
            txtRequiredDate.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();

            txtFreight.DataBindings.Add("Text", source, "Freight");
            txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
            txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
            txtOrderID.DataBindings.Add("Text", source, "OrderId");
            txtMemberID.DataBindings.Add("Text", source, "MemberId");


            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = source;
        }
    }

    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Load product list");
    }
}
private void btnSearch_Click(object sender, EventArgs e)
{
    FilterMember();
}

       
    }
}
