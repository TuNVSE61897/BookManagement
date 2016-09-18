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
    public partial class BookForm : Form
    {
        IBussinessLogic proxy;
        DataTable table = new DataTable();
        //BookData current = new BookData();
        DataView dvBook = new DataView();
        public BookForm()
        {
            InitializeComponent();
            dgvBook.MultiSelect = false;
            dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
            getDataSource();
            lbNumOfBook.Text = "Number of Book: "+ table.Rows.Count.ToString();
            dvBook = new DataView(table);
        }

        public void getDataSource()
        {
            try
            {
                table = proxy.GetAllBook();
                dgvBook.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void setCurrent()
        {
            if (dgvBook.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBook.SelectedRows[0];
                txtID.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook AddBookForm = new AddBook();
            DialogResult result = AddBookForm.ShowDialog();
            if (result == DialogResult.Cancel || result == DialogResult.OK)
            {
                getDataSource();
            }
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            cboSearch.SelectedIndex = 0;
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setCurrent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please choose a Book to Delete");
            }
            else
            {
                BookData b = new BookData()
                {
                    ID = int.Parse(txtID.Text)
                };
                proxy.IRemoveBook(b);
                getDataSource();
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            getDataSource();
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                int searchIndex = cboSearch.SelectedIndex;
                string searchText = cboSearch.SelectedItem.ToString();
                string search = txtSearch.Text;
                table = proxy.FilterBookByCategory(search);
                if (string.IsNullOrEmpty(search))
                {
                    MessageBox.Show("Please input a " + searchText);
                    txtSearch.Focus();
                    return;
                }
                if (searchIndex == 0)
                {
                    table = proxy.SearchBookByAuthor(search);
                }
                else if (searchIndex == 1)
                {
                    dvBook.RowFilter = "Publisher_Name like '%" + search + "%'";
                    table = dvBook.ToTable();
                    //table = proxy.SearchBookByPublisher(search);
                }
                else if (searchIndex == 2)
                {
                    table = proxy.FilterBookByCategory(search);
                }
                if (table.Rows.Count == 0 || table == null)
                {
                    MessageBox.Show("This " + searchText + " is empty");
                }
                else
                {
                    lbNumOfBook.Text = "Number of Book: " + table.Rows.Count.ToString();
                    dgvBook.DataSource = dvBook;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                try
                {
                    UpdateBook form = new UpdateBook(int.Parse(txtID.Text));
                    form.ShowDialog();
                }
                catch (Exception)
                {

                    MessageBox.Show("Please Enter correct ISBN");
                }
            }
            else
            {
                MessageBox.Show("Please choose a Book!!!");
            }
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBook form = new UpdateBook(int.Parse(txtID.Text));
            form.ShowDialog();
        }
    }
}
