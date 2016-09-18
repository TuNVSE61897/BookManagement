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
    public partial class AuthorForm : Form
    {

        IBussinessLogic proxy;
        DataTable table = new DataTable();
        AuthorData current = new AuthorData();
        public AuthorForm()
        {
            InitializeComponent();
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            ChannelFactory<IBussinessLogic> chanel =
                new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
            getDataScource();
         
            if (table.Rows.Count > 0)
            {
                setCurrent();
                current.ID = (int)table.Rows[0][0];

            }

        }

        void setCurrent()
        {
            if (dgv.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dgv.SelectedRows[0];
                int id = (int)row.Cells[0].Value;
                string name = row.Cells[0].Value.ToString();
                current.ID = id;
                current.name = name;
            }
        }

        void getDataScource()
        {

            try
            {
                binding = new BindingSource();
                table = proxy.GetAllAuthor();
                binding.DataSource = table;
                dgv.DataSource = binding;
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("Text", binding, "name");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        bool validate() {
            if (String.IsNullOrEmpty(txtName.Text)) {
                MessageBox.Show("name must not empty");
                return false;
            }
            if (txtName.Text.Length > 250) {
                MessageBox.Show("Name Lenght too long [lenght must <250]");
            }

            return true;

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!validate()) {
                return;
            }

            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Author name must not empty");
                return;
            }
            AuthorData author = new AuthorData() { name = txtName.Text };
            bool result = proxy.AddAuthor(author);
            if (result)
            {
                MessageBox.Show("Add author successful!");
                getDataScource();
            }
            else
            {
                MessageBox.Show("Add author Fail!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_MouseClick(object sender, MouseEventArgs e)
        {
            setCurrent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool result = proxy.RemoveAuthor(current);
            if (result)
            {
                getDataScource();
                MessageBox.Show("Delete Author Successful!");

            }
            else
            {
                MessageBox.Show("Can not Delete this Author, Because This author is used by some Books, If you want to delete this Author please remove all book related to this author!");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validate()) {
                return;
            }
            current.name = txtName.Text;
            bool result = proxy.UpdateAuthor(current);
            if (result)
            {
                getDataScource();
                MessageBox.Show("Update Author Successful!");

            }
            else
            {
                MessageBox.Show("Update Fail! Please Try Again");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
