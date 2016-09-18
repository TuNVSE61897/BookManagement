using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Server.Services
{
    class CategoryService
    {

        static string GET_ALL_CATEGORY = "SELECT * FROM Category";


        public static DataTable getAllCategory() {
            SqlConnection con = new SqlConnection(Const.Const.ConnectionString);
            SqlCommand command = new SqlCommand(GET_ALL_CATEGORY, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable result = new DataTable("Categories");
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                adapter.Fill(result);
                return result;
            }
            catch (Exception e)
            {
                LogService.log("error", e.Message);
            }
            return null;
        }




        public static bool Add(Category c) {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities()) {
                    context.Categories.Add(c);
                    context.SaveChanges();
                    Console.WriteLine("[Category Add Successful!]"+ c.name);
                    context.Dispose();
                    return true;
                }

            }
            catch (Exception e)
            {
                LogService.log("Error", e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        public static bool Remove(Category c)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    Category category = context.Categories.FirstOrDefault(t => t.ID == c.ID);
                    context.Categories.Remove(category);
                    context.SaveChanges();
                    Console.WriteLine("[Category Remove Successful!]" + c.name);
                    context.Dispose();
                    return true;
                }

            }
            catch (Exception e)
            {

                LogService.log("Error", e.Message);
                return false;
            }
        }


        public static bool Update(Category c)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    Category category = context.Categories.FirstOrDefault(t => t.ID == c.ID);
                    category.name = c.name;
                    category.status = c.status;
                    context.SaveChanges();
                    Console.WriteLine("[Category Update Successful!]" + c.name);
                    return true;
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
