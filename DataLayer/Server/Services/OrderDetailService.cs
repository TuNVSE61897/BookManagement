using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Server.Services
{
    class OrderDetailService
    {
        public static bool Add(Order_Detail o)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    context.Order_Detail.Add(o);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can't add order detail to database. Detail: {0}", ex);
            }
            return false;
        }
        public static bool Update(Order_Detail o)
        {
            using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
            {
                try
                {
                    Order_Detail update = context.Order_Detail.SingleOrDefault(x => x.ID == o.ID);
                    if (update != null)
                    {

                        if (o.Order != null) update.Order = o.Order;
                        if (o.order_ID != null) update.order_ID = o.order_ID;
                        if (o.quantity != null) update.quantity = o.quantity;
                        if (o.book_ID != null) update.book_ID = o.book_ID;
                        context.SaveChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Can't update order. Detail: {0}", ex);
                }
            }
            return false;
        }

        public static DataTable GetAllByID(int ID)
        {
            DataTable listOrder = new DataTable("OrderDetailByID");

            SqlConnection conn = new SqlConnection(Const.Const.ConnectionString);

            SqlCommand cmd = new SqlCommand("select b.ISBN as 'ISBN', b.name as 'Name', od.quantity as 'Quantity', b.price as 'Price' from [Order_Detail] od, Book b where od.order_ID = @ID AND od.book_ID = b.ID ", conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(listOrder);
                return listOrder;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return null;
        }
    }
}
