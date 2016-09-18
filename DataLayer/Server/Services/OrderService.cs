using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Server.Services
{
    class OrderService
    {

        public static bool Add(Order o)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    context.Orders.Add(o);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can't add order to database. Detail: {0}", ex);
            }
            return false;
        }

        public static int AddReturnID(Order o)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    context.Orders.Add(o);
                    context.SaveChanges();
                    
                    return o.ID;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can't add order to database. Detail: {0}", ex);
            }
            return -1;
        }

        public static bool Update(Order o)
        {
            using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
            {
                try
                {
                    Order update = context.Orders.SingleOrDefault(x => x.ID == o.ID);
                    if (update != null)
                    {

                        if (o.Account != null) update.Account = o.Account;
                        if (o.account_ID != null) update.account_ID = o.account_ID;
                        if (o.customer_name != null) update.customer_name = o.customer_name;
                        if (o.date != null) update.date = o.date;
                        if (o.Order_Detail != null) update.Order_Detail = o.Order_Detail;
                        if (o.status != null) update.status = o.status;

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

        public static DataTable SearchByDate(DateTime date)
        {



            DataTable listOrder = new DataTable("OrderByDate");

            SqlConnection conn = new SqlConnection(Const.Const.ConnectionString);

            SqlCommand cmd = new SqlCommand("select * from [Order] where [date] = @date", conn);
            cmd.Parameters.AddWithValue("@date", date.ToString());
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
                Console.WriteLine(e.StackTrace);

            }
            finally
            {
                if (conn!=null){
                    conn.Close();
                }
            }
            return null;
        }

        public static DataTable SearchByCustomerName(string name)
        {

            DataTable listOrder = new DataTable("OrderByDate");

            SqlConnection conn = new SqlConnection(Const.Const.ConnectionString);

            SqlCommand cmd = new SqlCommand("select * from [Order] where [customer_name] like @name", conn);
            cmd.Parameters.AddWithValue("@name", "%" + name+"%");

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

        public static DataTable SearchByRangeDate(DateTime from, DateTime to)
        {



            DataTable listOrder = new DataTable("OrderByDate");

            SqlConnection conn = new SqlConnection(Const.Const.ConnectionString);

            SqlCommand cmd = new SqlCommand("select * from [Order] where [date] >= @from AND [date] <= @to", conn);
            cmd.Parameters.AddWithValue("@from", from.ToString());
            cmd.Parameters.AddWithValue("@to", to.ToString());
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

        public static DataTable SearchByID(int ID)
        {
            DataTable listOrder = new DataTable("OrderByDate");

            SqlConnection conn = new SqlConnection(Const.Const.ConnectionString);

            SqlCommand cmd = new SqlCommand("select * from [Order] where ID = @ID", conn);
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

        public static DataTable CustomSearch(string ID, string customerName, DateTime from, DateTime to)
        {
            DataTable list = new DataTable("CustomSearchOrder");
            string Query = "";
            SqlConnection conn = new SqlConnection(Const.Const.ConnectionString);

            Query = "Select ID,customer_name as 'Customer Name', date as 'Date' from[Order] where ID = @ID";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            if (string.IsNullOrEmpty(ID))
            {
                Query = "Select ID,customer_name as 'Customer Name', date as 'Date' from[Order] where customer_name like @customer_name AND date >= @from AND date <= @to";
                cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@customer_name", "%" + customerName + "%");
                cmd.Parameters.AddWithValue("@from", from.ToString());
                cmd.Parameters.AddWithValue("@to", to.ToString());
            }



            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(list);
                return list;
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
