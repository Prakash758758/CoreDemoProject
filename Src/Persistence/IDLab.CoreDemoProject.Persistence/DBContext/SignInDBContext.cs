using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using IDLab.CoreDemoProject.Domain.Models;
using static IDLab.CoreDemoProject.Persistence.Utility.SqlUtility;

namespace IDLab.CoreDemoProject.Persistence.DBContext
{
    public class SignInDBContext
    {
      IDbConnection sqlCon;
      public string UserLogin(SignIn request){
        using (sqlCon = GetConnection())
            {
                string result="";
                var com = new DynamicParameters();
                com.Add("@Email", request.UserName);
                com.Add("@MobileNo", request.UserName);
                com.Add("@Password", request.Password);
                try
                {
                    result = sqlCon.Query<string>("usp_userLogin", com, commandType: CommandType.StoredProcedure).FirstOrDefault();
                 
                }
                catch (Exception)
                {
                    throw;
                }
                   return result;
            }
    
        }  
    }
}