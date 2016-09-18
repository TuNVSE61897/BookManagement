using System;
using Interface_Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Forms;

namespace DXApp
{
    public partial class PublisherForm : Form
    {
        IBussinessLogic proxy;
        DataTable datatable;
        private bool readyAddNew = false;
        public PublisherForm()
        {
            InitializeComponent();
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 1;
            btnAdd.FlatAppearance.BorderColor = Color.Gray;
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private bool loadData()
        {
            try
            {
                datatable = proxy.GetAllPublisher();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't connect to server!");
                return false;
            }
            return true;
            
        }
        private void refeshForm()
        {
            loadData();
            if (loadData() == true)
            {
                datatable.PrimaryKey = new DataColumn[] { datatable.Columns["ID"] };
                dgvPublisher.DataSource = datatable;
            }
            //txtID.DataBindings.Clear();
            //txtName.DataBindings.Clear();
            //txtID.DataBindings.Add("Text", datatable, "ID");
            //txtName.DataBindings.Add("Text", datatable, "Name");
            
        }
        private bool validate()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errName.SetError(txtName, "Name is not empty!");
                return false;
            }
            else
            {
                errName.Clear();
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {
            refeshForm();
        }

        private void PublisherForm_Click(object sender, EventArgs e)
        {

        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            //validate();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            //validate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (readyAddNew == false)
            {
                readyAddNew = true;
                txtID.Text = "";
                txtName.Focus();
                txtName.Text = "";
                btnAdd.Text = "Save Publisher";
                btnAdd.FlatAppearance.BorderSize = 2;
                btnAdd.FlatAppearance.BorderColor = Color.Green;
                lblMessage.Text = "Enter new Publisher";
            }
            else
            {
                if (validate() == true)
                {
                    PublisherData p = new PublisherData()
                    {
                        name = txtName.Text.Trim()
                    };
                    bool re = proxy.AddPublisher(p);
                    if (re == true)
                    {
                        txtName.Focus();
                        txtName.Text = "";

                        MessageBox.Show("Add new Publisher is successful.");
                        // int lastInt = int.Parse(datatable.Rows[datatable.Rows.Count - 1]["ID"].ToString());
                        //datatable.Rows.Add(lastInt + 2, txtName.Text.Trim());
                        refeshForm();
                    }
                    else
                    {
                        MessageBox.Show("Add new Publisher is fail");
                    }
                }
                else
                {
                    return;
                }
            }

        }

        private void dgvPublisher_Leave(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validate() == true)
            {
                int ID = 0;
                try
                {
                    ID = int.Parse(txtID.Text.Trim());
                    errID.Clear();
                }
                catch (Exception)
                {
                    errID.SetError(txtID, "ID is only number and not empty.");
                    return;
                }

                string name = txtName.Text.Trim();
                bool re = proxy.UpdatePublisher(new PublisherData() {
                    ID = ID,
                    name = name
                    });
                if (re)
                {
                    //DataRow row = datatable.Rows.Find(ID);
                    //row["name"] = name;
                    MessageBox.Show("Update is successfull");
                    refeshForm();
                }
                else
                {
                    MessageBox.Show("Update is fail");
                }
            }
        }

        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                string ID = dgvPublisher.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string Name = dgvPublisher.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtID.Text = ID;
                txtName.Text = Name;
                readyAddNew = false;
                btnAdd.Text = "Add new Publisher";
                btnAdd.FlatAppearance.BorderSize = 1;
                btnAdd.FlatAppearance.BorderColor = Color.Gray;
                lblMessage.Text = "Publisher Detail";
            }
            else
            {
                return;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int IDremove = 0;
            try
            {
                IDremove = int.Parse(txtID.Text.Trim());
                errID.Clear();
            }
            catch (Exception)
            {
                errID.SetError(txtID, "ID is only number and not empty.");
                return;
            }
            bool re = false;

            try
            {
                re = proxy.DeletePublisher(new PublisherData()
                {
                    ID = IDremove
                });
            }
            catch (Exception)
            {
                MessageBox.Show("This publisher has many books. Remove it and try again remove this Publisher.");
                return;
            }

            if (re)
            {
                //DataRow row = datatable.Rows.Find(IDremove);
                MessageBox.Show("Remove is successfull");
                refeshForm();
            }
            else
            {
                MessageBox.Show("Remove is fail");
            }
        }

        private void dgvPublisher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }
    }
}
