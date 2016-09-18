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
    public partial class UpdateBook : Form
    {

        BookData book = new BookData();
        IBussinessLogic proxy;
        BindingSource bidding = new BindingSource();


        public UpdateBook(int ID)
        {
            InitializeComponent();
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
            book = proxy.GetBookDataByID(ID);
            ListAuthors.DataSource = proxy.GetAllBookAuthor();
            ListAuthors.DisplayMember = "name";
            ListAuthors.ValueMember = "id";
            ListCategory.DataSource = proxy.GetBookAllCategory();
            ListCategory.DisplayMember = "name";
            ListCategory.ValueMember = "id";
            cboPublisher.DataSource = proxy.getAllPublisher();
            cboPublisher.DisplayMember = "name";
            cboPublisher.ValueMember = "id";
            ListAuthors.ClearSelected();
            ListCategory.ClearSelected();
            ListAuthors.SelectionMode = SelectionMode.MultiExtended;
            ListCategory.SelectionMode = SelectionMode.MultiExtended;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {
            txtISBN.Text = book.ISBN;
            txtName.Text = book.Name;
            txtPrice.Text = book.Price.ToString();
            txtQuantity.Text = book.Quantity.ToString();
            txtDesc.Text = book.Description;
            txtPrice.Text = book.Price.ToString();
            txtStatus.Text = book.Status;


            for (int i = 0; i < ListAuthors.Items.Count; i++)
            {
                int count = 0;
                for (int t = count; t < book.Author.Count; t++)
                {
                    if (book.Author[t].ID == ((AuthorData)ListAuthors.Items[i]).ID)
                    {
                        ListAuthors.SetSelected(i, true);
                        count = t;
                        break;
                    }
                }
            }

            for (int i = 0; i < ListCategory.Items.Count; i++)
            {
                for (int t = 0; t < book.Category.Count; t++)
                {
                    if (((CategoryData)ListCategory.Items[i]).ID == book.Category[t].ID)
                    {
                        ListCategory.SetSelected(i, true);
                        break;
                    }
                }
            }
            for (int i = 0; i < cboPublisher.Items.Count; i++)
            {
                if (book.Publisher_ID == ((PublisherData)cboPublisher.Items[i]).ID)
                {
                    cboPublisher.SelectedIndex = i;
                }
            }



        }



        bool validate()
        {
            if (String.IsNullOrEmpty(txtISBN.Text))
            {
                MessageBox.Show("ISBN must not Empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name must not Empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Description Must not Empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Quantity Must not Empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Price must not Empty!");
                return false;
            }
            if (String.IsNullOrEmpty(txtStatus.Text))
            {
                MessageBox.Show("Status must not Empty!");
                return false;
            }
            try
            {
                int a = int.Parse(txtQuantity.Text);
                if (a < 0)
                {
                    MessageBox.Show("Quantity Must Be Positive Number");
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
                MessageBox.Show("Price must be Integer number");
                return false;
            }
            return true;


        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtISBN.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
            txtStatus.Text = "";
            ListAuthors.ClearSelected();
            ListCategory.ClearSelected();
            cboPublisher.SelectedIndex = 0;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                return;
            }
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

            bool result = proxy.IUpdateBook(book);
            if (result)
            {
                MessageBox.Show("Update Book Successful!");
            }
            else
            {
                MessageBox.Show("Please Check book ISBN , This ISBN is existed!");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtISBN.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
            txtStatus.Text = "";
            ListAuthors.ClearSelected();
            ListCategory.ClearSelected();
            cboPublisher.SelectedIndex = 0;
        }
    }
}
