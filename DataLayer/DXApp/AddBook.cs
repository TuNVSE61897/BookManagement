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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
            ChannelFactory<IBussinessLogic> chanel =
                new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        IBussinessLogic proxy;

        private void AddBook_Load(object sender, EventArgs e)
        {
            ListAuthors.DataSource = proxy.GetAllBookAuthor();
            ListAuthors.DisplayMember = "Name";
            ListAuthors.ValueMember = "Id";
            ListCategory.DataSource = proxy.GetBookAllCategory();
            ListCategory.DisplayMember = "name";
            ListCategory.ValueMember = "Id";
            ListCategory.SelectionMode = SelectionMode.MultiExtended;
            ListAuthors.SelectionMode = SelectionMode.MultiExtended;
            publishYearPicker.Format = DateTimePickerFormat.Custom;
            publishYearPicker.CustomFormat = "yyyy";
            publishYearPicker.ShowUpDown = true;
            cboPublisher.DataSource = proxy.getAllPublisher();
            cboPublisher.DisplayMember = "name";
            cboPublisher.ValueMember = "id";
            ListAuthors.ClearSelected();
            
        }



        // validate if empty or can not part return true . if valid return false;
        bool Myvalidate()
        {
            if (String.IsNullOrEmpty(txtISBN.Text)) {
                MessageBox.Show("ISBN must not Empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtName.Text)) {
                MessageBox.Show("Name must not Empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtDesc.Text)) {
                MessageBox.Show("Description Must not Empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtQuantity.Text)) {
                MessageBox.Show("Quantity Must not Empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtPrice.Text)) {
                MessageBox.Show("Price must not Empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtStatus.Text)) {
                MessageBox.Show("Status must not Empty!");
                return false;    
            }
            try
            {
                int a=int.Parse(txtQuantity.Text);
                if (a < 0) {
                    MessageBox.Show("Quantity Must Be Positive Integer Number");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Quantity Number!");
                return false;
            }
            try
            {
                int b = int.Parse(txtPrice.Text);
                if (b < 0)
                {
                    MessageBox.Show("Price must be Positive  number");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Price must be integer number");
                return false;
            }
            return true;    
        }



        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!Myvalidate())
            {
                return;

            }
            BookData book = new BookData();
            book.Author = new List<AuthorData>();
            book.Category = new List<CategoryData>();
            book.Name = txtName.Text;
            book.ISBN = txtISBN.Text;
            book.Description = txtDesc.Text;
            book.Price = int.Parse(txtPrice.Text);
            book.Quantity = int.Parse(txtQuantity.Text);
            book.Publisher_ID = (int)cboPublisher.SelectedValue;
            book.Status = txtStatus.Text;
            book.Year = publishYearPicker.Value.ToString("yyyy");
            foreach (CategoryData item in ListCategory.SelectedItems)
            {
                book.Category.Add(item);
            }
            foreach (AuthorData item in ListAuthors.SelectedItems)
            {
                book.Author.Add(item);
            }

            bool result = proxy.IAddBook(book);

            if (result)
            {
                MessageBox.Show("Add Book Successful!");
            }
            else
            {
                MessageBox.Show("Please Check book ISBN , This ISBN is existed!");

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtISBN.Text = "";
            txtDesc.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtStatus.Text = "";
        }
    }
}
