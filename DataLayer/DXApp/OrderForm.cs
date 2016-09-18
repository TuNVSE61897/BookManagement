using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_Data;
using System.ServiceModel;

namespace DXApp
{

    public partial class frmOrder : Form
    {
        IBussinessLogic proxy;
        DataTable datatable;
        List<Panel> listPanel = new List<Panel>();

        public frmOrder()
        {
            InitializeComponent();


            for (int i = 0; i < listPanel.Count; i++)
            {

                if (i == 3)
                {
                    listPanel[i].Visible = true;
                }
                else
                {
                    listPanel[i].Visible = false;
                }

            }

            //chDate.Format = DateTimePickerFormat.Time;

            chDateFrom.CustomFormat = "yyyy/MM/dd";
            chDateFrom.Format = DateTimePickerFormat.Custom;
            //chDateFrom.Format = DateTimePickerFormat.Time;

            chDateTo.CustomFormat = "yyyy/MM/dd";
            chDateTo.Format = DateTimePickerFormat.Custom;

            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchByName.Text))
            {
                errName.SetError(txtSearchByName, "Name is not empty.");
                return;
            }
            else
            {
                errName.Clear();
            }

            string keyname = txtSearchByName.Text.Trim();
            datatable = proxy.SearchByCustomerNameOrder(keyname);
            dgvOrder.DataSource = datatable;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

        }

        private void cbbChoiceSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearchByDate_Click(object sender, EventArgs e)
        {
            
        }

        private void chDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchByRangeDate_Click(object sender, EventArgs e)
        {
            
        }

        private void chDateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string textID = dgvOrder.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string CusName = dgvOrder.Rows[e.RowIndex].Cells["Customer Name"].Value.ToString();
                string Date = dgvOrder.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                int ID = int.Parse(textID);
                datatable = proxy.GetAllOrderDetailByID(ID);
                dgvOrderDetail.DataSource = datatable;
                double TotalPrice = 0;
                foreach (DataGridViewRow row in dgvOrderDetail.Rows)
                {
                    TotalPrice += int.Parse(row.Cells["Quantity"].Value.ToString()) * double.Parse(row.Cells["Price"].Value.ToString());
                    //More code here
                }
                lblCustomerName.Text = "Customer Name: " + CusName;
                lblDate.Text ="Date: " +  Date;
                lblTotal.Text = "Total Price: "+ TotalPrice.ToString() + " $";
            }
            else
            {
                return;
            }
        }

        private void dgvOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCustomSearch_Click_1(object sender, EventArgs e)
        {
            string ID = txtSearchByID.Text;
            string customerName = txtSearchByName.Text;
            DateTime from = chDateFrom.Value;
            DateTime to = chDateTo.Value;

            datatable = proxy.CustomSearchOrder(ID, customerName, from, to);
            dgvOrder.DataSource = datatable;
        }

        private void dgvOrderDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }
    }
}
