using Interface_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApp
{
    public partial class CategoryForm : Form
    {
        DataTable table = new DataTable();
        IBussinessLogic proxy;
        CategoryData current = new CategoryData();
        public CategoryForm()
        {
            InitializeComponent();
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
            getDataSource();
            if (table.Rows.Count > 0)
            {
                current.ID = (int)table.Rows[0][0];
                current.name = table.Rows[0][1].ToString();
            }


        }



        public void getDataSource()
        {
            try
            {
                table = proxy.GetAllCategory();
                bindingTor.DataSource = table;
                if (bindingTor != null)
                {
                    txtName.DataBindings.Clear();
                    txtStatus.DataBindings.Clear();
                    txtName.DataBindings.Add("Text", bindingTor, "name");
                    txtStatus.DataBindings.Add("Text", bindingTor, "status");
                    dgv.DataSource = bindingTor;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        private void CategoryForm_Load(object sender, EventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String status = txtStatus.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Category name Must not Empty");
                return;
            }
            if (txtName.Text.Length > 200) {
                MessageBox.Show("name lenght too long ,lenght must <200");
                return;
            }

            if (status.Length >= 10) {
                MessageBox.Show("Status must less thang 10 charactor!");
                return;
            }

            CategoryData category = new CategoryData();
            category.name = name;
            category.status = status;
            bool result;

            try
            {
                result = proxy.AddCategory(category);
                if (result)
                {

                    MessageBox.Show("Add Category Success");
                    getDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool result = proxy.RemoveCategory(current);
            if (result)
            {
                getDataSource();
                MessageBox.Show("Delete Category Success!");

            }
            else
            {
                MessageBox.Show("You can not Delete This Category because this category" +
                     "used by some book, If you want to delete this Category please remove all book relate to this category");

            }
        }

        private void bindingTor_CurrentChanged(object sender, EventArgs e)
        {




        }

        void setCurrent()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                int id = (int)row.Cells[0].Value;
                current.ID = id;
                current.name = row.Cells[1].Value.ToString();
                current.status = row.Cells[2].Value.ToString();
            }
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            setCurrent();

        }

        private void dgv_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Category name Must not Empty");
                return;
            }

            if (txtStatus.Text.Length >= 10)
            {
                MessageBox.Show("Status must less thang 10 charactor!");
                return;
            }
            current.name = txtName.Text;
            current.status = txtStatus.Text;
            bool result = proxy.UpdateCategory(current);
            if (result)
            {
                getDataSource();
                MessageBox.Show("Update Category Success!!!");

            }
            else
            {
                MessageBox.Show("ERROR CODE: 500");
            }
        }
    }
}
