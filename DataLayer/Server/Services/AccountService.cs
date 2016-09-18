using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    class AccountService
    {
        public static bool Add(Account b)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    context.Accounts.Add(b);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Can't add account to database. Detail: {0}", ex);
                return false;
            }
        }

        public static bool Remove(Account b)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    Account account = context.Accounts.FirstOrDefault(temp => temp.ID == b.ID);
                    context.Accounts.Remove(account);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Can't remove account from database. Detail: {0}", ex);
                return false;
            }
        }

        public static int checkLogin(string username, string password)
        {
            try
            {
                using (Book_Sale_ManagerEntities context = new Book_Sale_ManagerEntities())
                {
                    Account account = context.Accounts.FirstOrDefault(temp => temp.username.ToLower().Equals(username.ToLower()) && temp.password.Equals(password));
                    if (account != null)
                    {

                        if (account.type == "ADMIN")
                        {
                            LogService.log("Info", username + "Login Successful");
                            return 1;
                        }

                        else
                        {
                            LogService.log("Info", username + "Login Successful");
                            return 0;
                        }
                    }
                    return -1;
                }
            }
            catch (Exception ex)
            {
                LogService.log("Infor", username + "Login Fail!");
                return -1;
            }
        }
    }
}
