using Interface_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server.Services;
using System.Data;
namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BussinessLogic" in both code and config file together.
    public class BussinessLogic : IBussinessLogic
    {

        public bool AddAccount(AccountData b)
        {
            Account account = new Account();
            account.username = b.username;
            account.password = b.password;
            account.phone = b.phone;
            account.email = b.email;
            account.type = b.type;
            bool result = AccountService.Add(account);
            return result;
        }

        public bool AddAuthor(AuthorData a)
        {
            Author author = new Author();
            author.name = a.name;
            bool result = AuthorService.Add(author);
            return result;
        }

        public DataTable FilterBookByCategory(string category)
        {
            DataTable listBook = BookService.FilterByCategory(category);
            Console.WriteLine("Filter Book By Category");
            return listBook;
        }

        public DataTable GetAllBook()
        {
            DataTable listBook = BookService.GetAllBook();
            Console.WriteLine("Get All Book from Database");
            return listBook;
        }

        public BookData GetBookByID(int ID)
        {
            Book b = BookService.GetBookByID(ID);
            BookData book = new BookData()
            {
                ID = b.ID,
                ISBN = b.ISBN,
                Name = b.name,
                Description = b.description,
                Thumnail = b.thumbnail,
                Quantity = int.Parse(b.quantity.ToString()),
                Price = int.Parse(b.price.ToString()),
                Status = b.status,
                Year = b.year,
                Publisher_ID = int.Parse(b.publisher_ID.ToString())
            };
            Console.WriteLine("Search Book By ID");
            return book;
        }

        public bool IAddBook(BookData b)
        {
            return BookService.AddBook(b);
        }

        public bool IRemoveBook(BookData b)
        {
            Book book = new Book();
            book.ID = b.ID;
            book.name = b.Name;
            book.description = b.Description;
            book.thumbnail = b.Thumnail;
            book.quantity = b.Quantity;
            book.price = b.Price;
            book.status = b.Status;
            book.year = b.Year;
            book.publisher_ID = b.Publisher_ID;
            bool result = BookService.DeleteBook(book);
            if (result)
            {
                Console.WriteLine("Delete a Book successful");
            }
            else
            {
                Console.WriteLine("Delete book fail");
            }
            
            return result;
        }

        public bool IUpdateBook(BookData b)
        {
            return BookService.UpDateBook(b);
        }

        public bool AddCategory(CategoryData c)
        {
            Category category = new Category();
            category.name = c.name;
            category.status = c.status;
            return CategoryService.Add(category);
        }

        public DataTable GetAllAuthor()
        {
          return  AuthorService.GetAllAuthor();
        }

        public bool RemoveAuthor(AuthorData a)
        {
            Author author = new Author();
            author.ID = a.ID;
            author.name = a.name;
            bool result = AuthorService.Remove(author);
            return result;
        }

        public DataTable SearchBookByAuthor(string author)
        {
            DataTable ListBook = BookService.SearchBookByAuthor(author);
            Console.WriteLine("Search Book By Author");
            return ListBook;
        }

        public DataTable SearchBookByPublisher(string publisher)
        {
            DataTable ListBook = BookService.SearchBookByPublisher(publisher);
            Console.WriteLine("Search Book By Publisher");
            return ListBook;
        }

        public bool UpdateAuthor(AuthorData a)
        {
            Author author = new Author();
            author.name = a.name;
            author.ID = a.ID;
            bool result=AuthorService.Update(author);
            return result;
        }
        public bool RemoveCategory(CategoryData c)
        {
            Category category = new Category();
            category.name = c.name;
            category.ID = c.ID;
            category.status = c.status;
            return CategoryService.Remove(category);
        }

        public bool UpdateCategory(CategoryData c)
        {
            Category category = new Category();
            category.ID = c.ID;
            category.name = c.name;
            category.status = c.status;
            return CategoryService.Update(category);
        }

        public DataTable GetAllCategory()
        {
            return CategoryService.getAllCategory();
        }

        public bool AddOrder(OrderData od)
        {
            Order o = new Order()
            {
                ID = od.ID,
                account_ID = od.account_ID,
                customer_name = od.customer_name,
                status = od.status,
                date = od.date
            };
            bool result = OrderService.Add(o);
            return result;
        }

        public bool UpdateOrder(OrderData od)
        {
            Order o = new Order()
            {
                ID = od.ID,
                account_ID = od.account_ID,
                customer_name = od.customer_name,
                status = od.status,
                date = od.date
            };
            bool result = OrderService.Update(o);
            return result;
        }

        public DataTable SearchByDate(DateTime date)
        {
            DataTable data = OrderService.SearchByDate(date);
            return data;
        }

        public bool AddPublisher(PublisherData p)
        {
            return PublisherService.Add(new Publisher() {
                ID = p.ID,
                name = p.name
            });
        }

        public bool UpdatePublisher(PublisherData p)
        {
            return PublisherService.Update(new Publisher()
            {
                ID = p.ID,
                name = p.name
            });
        }

        public bool DeletePublisher(PublisherData p)
        {
            return PublisherService.Delete(new Publisher()
            {
                ID = p.ID,
                name = p.name
            });
        }

        public bool AddOrderDetail(OrderDetailData od)
        {
            return OrderDetailService.Add(new Order_Detail() {
                ID = od.ID,
                book_ID = od.book_ID,
                order_ID = od.order_ID,
                quantity = od.quantity
            });
        }

        public bool UpdateOrderDetail(OrderDetailData od)
        {
            return OrderDetailService.Update(new Order_Detail()
            {
                ID = od.ID,
                book_ID = od.book_ID,
                order_ID = od.order_ID,
                quantity = od.quantity
            });
        }
        public int checkLogin(string username, string password)
        {
            Account account = new Account();
            account.username = username;
            account.password = password;
            int result = AccountService.checkLogin(account.username, account.password);
            return result;
        }
        public bool RemoveAccount(AccountData b)
        {
            Account account = new Account();
            account.ID = b.ID;
            account.username = b.username;
            account.password = b.password;
            account.phone = b.phone;
            account.email = b.email;
            account.type = b.type;
            bool result = AccountService.Remove(account);
            return result;
        }

        public DataTable GetAllPublisher()
        {
            return PublisherService.GetAll();
        }

        public DataTable SearchByCustomerNameOrder(string name)
        {
            return OrderService.SearchByCustomerName(name);
        }

        public DataTable SearchByRangeDateOrder(DateTime from, DateTime to)
        {
            return OrderService.SearchByRangeDate(from, to);
        }

        public DataTable SearchByIDOrder(int ID)
        {
            return OrderService.SearchByID(ID);
        }

        public List<PublisherData> getAllPublisher()
        {
            return BookService.getAllPublisher();
        }
        public List<CategoryData> GetBookAllCategory()
        {
            return BookService.GetAllBookCategoryData();
        }
        public DataTable GetAllOrderDetailByID(int ID)
        {
            return OrderDetailService.GetAllByID(ID);
        }
        public List<AuthorData> GetAllBookAuthor()
        {
            return BookService.GetAllBookAuthorData();
        }

        public BookData GetBookDataByID(int id)
        {
            return BookService.GetBookDataById(id);
        }

        public DataTable CustomSearchBook(string ISBN, string Bookname, string authorName)
        {
            return BookService.CustomSearch(ISBN, Bookname, authorName);
        }

        public int AddReturnIDOrder(OrderData od)
        {
            Order o = new Order()
            {
                ID = od.ID,
                account_ID = od.account_ID,
                customer_name = od.customer_name,
                status = od.status,
                date = od.date
            };
            return OrderService.AddReturnID(o);
        }

        public DataTable CustomSearchOrder(string ID, string customerName, DateTime from, DateTime to)
        {
            return OrderService.CustomSearch(ID, customerName, from, to);
        }

        public bool UpdateQuantityBook(int ID, int Quantity)
        {
            return BookService.UpdateQuantity(ID, Quantity);
        }
    }
}
