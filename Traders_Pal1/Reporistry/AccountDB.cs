using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Traders_Pal1.Models;
using System.Data.Entity;

namespace Traders_Pal1.Reporistry
{
    public class AccountDB : DbContext
    {

        public AccountDB(): base("name = pal")
        {

        }
        public T NewRegistration<T>(AccountModels model, int procId)
        {
            
            SqlParameter[] Params =
            {
                new SqlParameter("@Password", model.Password),
                new SqlParameter("@Name", model.Name),
                new SqlParameter("@MobileNo", model.MobileNo),
                new SqlParameter("@EmailId", model.EmailId)

                //new SqlParameter("@procId", procId)
            };
            var data = this.Database.SqlQuery<T>("Login @Password,@Name,@MobileNo,@EmailId", Params).FirstOrDefault();

            return data;
        }

        public T Login<T>(AccountModels model)
        {

            SqlParameter[] Params =
            {
                new SqlParameter("@Password", model.Password),
               
                new SqlParameter("@MobileNo", model.MobileNo),
             

                //new SqlParameter("@procId", procId)
            };
            var data = this.Database.SqlQuery<T>("Login @Password,@MobileNo", Params).FirstOrDefault();

            return data;
        }
    }
}