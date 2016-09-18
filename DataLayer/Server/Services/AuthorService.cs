using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Server.Const;

namespace Server.Services
{
    class AuthorService
    {

        static String SqlURL = Const.Const.ConnectionString;
        static String GET_ALL = "SELECT * FROM Author";


        public static DataTable GetAllAuthor()
        {
            SqlConnection con = new SqlConnection(SqlURL);
            SqlCommand prepareStatement = new SqlCommand(GET_ALL, con);
            SqlDataAdapter adapte = new SqlDataAdapter(prepareStatement);
            DataTable table = new DataTable("Author");
           
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                adapte.Fill(table);
                Console.WriteLine("Client Get All Author");
                return table;
            }
            catch (Exception e)
            {

                LogService.log("Error",e.Message);
            }
            return null;
        }





        public static bool Add(Author a)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    context.Authors.Add(a);
                    context.SaveChanges();
                    Console.WriteLine("[AuthorService]: Add Author Successful!"+a.name);
                    return true;
                }
            }
            catch (Exception e)
            {
                LogService.log("Error", e.Message);
                return false;
            }
        }

        public static bool Remove(Author a)
        {

            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {

                    Author author = context.Authors.FirstOrDefault(t => t.ID == a.ID);
                    if (author != null)
                    {
                        context.Authors.Remove(author);
                        context.SaveChanges();
                        Console.WriteLine("[AuthorService]: Remove Author Successful!" + a.name);

                        return true;
                    }
                    else
                    {
                        
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                LogService.log("Error", e.Message);
                return false;
            }
        }


        public static bool Update(Author a)
        {

            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {

                    Author author = context.Authors.FirstOrDefault(t => t.ID == a.ID);
                    if (author != null)
                    {
                        author.name = a.name;
                        context.SaveChanges();
                        Console.WriteLine("[AuthorService]: Update Author Successful!" + a.name);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                LogService.log("Error", e.Message);
                return false;
            }
        }









    }
}
