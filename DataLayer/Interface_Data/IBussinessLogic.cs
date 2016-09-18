using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Interface_Data
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBussinessLogic" in both code and config file together.
    [ServiceContract]
    public interface IBussinessLogic
    {
        /*-----------------------------------------------------------------------------------------*/
        //Author Bussiness Logic Implement
        [OperationContract]
        bool AddAuthor(AuthorData a);
        [OperationContract]
        bool RemoveAuthor(AuthorData a);
        
        [OperationContract]
        bool UpdateAuthor(AuthorData a);
        [OperationContract]
        DataTable GetAllAuthor();
        //Author Bussiness Logic Implement
        /*-----------------------------------------------------------------------------------------*/
        /* Category Bussiness Logic*/
        /*==========================================================================================*/
        [OperationContract]
        bool AddCategory(CategoryData c);
        [OperationContract]
        bool RemoveCategory(CategoryData c);
        [OperationContract]
        bool UpdateCategory(CategoryData c);
        [OperationContract]
        DataTable GetAllCategory();

        /*==========================================================================================*/






        //Begin Bussiness Order

        [OperationContract]
        bool AddOrder(OrderData a);

        [OperationContract]
        int AddReturnIDOrder(OrderData o);

        bool UpdateOrder(OrderData a);
        [OperationContract]
        DataTable SearchByDate(DateTime date);

        [OperationContract]
        DataTable SearchByCustomerNameOrder(string name);

        [OperationContract]
        DataTable SearchByRangeDateOrder(DateTime from, DateTime to);

        [OperationContract]
        DataTable SearchByIDOrder(int ID);

        [OperationContract]
        DataTable CustomSearchOrder(string ID, string customerName, DateTime from, DateTime to);

        //End bussiness Order
        //Account Business Logic Implement
        [OperationContract]
        bool AddAccount(AccountData b);
        [OperationContract]
        bool RemoveAccount(AccountData b);
        [OperationContract]
        int checkLogin(string username, string password);


        //Begin Bussiness Publisher
        [OperationContract]
        bool AddPublisher(PublisherData p);
        [OperationContract]
        bool UpdatePublisher(PublisherData p);
        [OperationContract]
        bool DeletePublisher(PublisherData p);

        [OperationContract]
        DataTable GetAllPublisher();
        //End Bussiness Publisher

        //Begin Bussiness OrderDetail
        [OperationContract]
        bool AddOrderDetail(OrderDetailData p);
        [OperationContract]
        bool UpdateOrderDetail(OrderDetailData p);

        [OperationContract]
        DataTable GetAllOrderDetailByID(int ID);

        //End Bussiness OrderDetail

        //Book Bussiness Logic Implement
        [OperationContract]
        bool IAddBook(BookData b);
        [OperationContract]
        bool IUpdateBook(BookData b);
        [OperationContract]
        bool IRemoveBook(BookData b);
        [OperationContract]
        DataTable GetAllBook();
        [OperationContract]
        BookData GetBookByID(int ID);
        [OperationContract]
        DataTable SearchBookByAuthor(string author);
        [OperationContract]
        DataTable SearchBookByPublisher(string publisher);
        [OperationContract]
        DataTable FilterBookByCategory(string category);
        [OperationContract]
        List<PublisherData> getAllPublisher();
        [OperationContract]
        List<AuthorData> GetAllBookAuthor();
        [OperationContract]
        List<CategoryData> GetBookAllCategory();

        [OperationContract]
        BookData GetBookDataByID(int id);

        [OperationContract]
        DataTable CustomSearchBook(string ISBN, string Bookname, string authorName);
        [OperationContract]
        bool UpdateQuantityBook(int ID, int Quantity);
        // end business logic book
    }
}
