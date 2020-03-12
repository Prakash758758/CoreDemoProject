using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using IDLab.CoreDemoProject.Domain.Models;
using static IDLab.CoreDemoProject.Persistence.Utility.SqlUtility;

namespace IDLab.CoreDemoProject.Persistence.DBContext
{
    public class UserDBContext
    {
    IDbConnection sqlCon;
        public User GetUser()
        {
           using (sqlCon = GetConnection())
            {
                var com = new DynamicParameters();
                User result=new User();
                com.Add("@UserName", "fsdf");
                try
                {
                    result = sqlCon.Query<User>("usp_userGet", com, commandType: CommandType.StoredProcedure).FirstOrDefault();
                 
                }
                catch (Exception)
                {
                    throw;
                }
                   return result;
            }
        }

        public string CreateUser(User request){
        using (sqlCon = GetConnection())
            {
                string result="";
                var com = new DynamicParameters();
                
                com.Add("@FirstName", request.FirstName);
                com.Add("@LastName", request.LastName);
                com.Add("@Email", request.Email);
                com.Add("@MobileNo", request.MobileNo);
                com.Add("@LocationName", request.LocationName);
                com.Add("@InsertedBy",request.InsertedBy);
                try
                {
                    result = sqlCon.Query<string>("usp_SampleCreateUser", com, commandType: CommandType.StoredProcedure).FirstOrDefault();
                 
                }
                catch (Exception)
                {
                    throw;
                }
                   return result;
            }
    
        }

        public string IsUserExist(User request){
            using(sqlCon=GetConnection()){
                var result="";
                var param=new DynamicParameters();
                param.Add("@Email", request.Email);
                param.Add("@MobileNo", request.MobileNo);
                try
                {
                    result = sqlCon.Query<string>("usp_checkUserExistOrNot", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                 
                }
                catch (Exception)
                {
                    throw;
                }
                   return result;
            }
        }

        public string OTPVerification(User request){
            using(sqlCon =GetConnection()){
                var result="";
                var param=new DynamicParameters();;
                param.Add("@MobileNo", request.MobileNo);
                param.Add("@OTP",request.OTP);
                try
                {
                    result = sqlCon.Query<string>("usp_otpVerification", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                 
                }
                catch (Exception)
                {
                    throw;
                }
                   return result;
            }
        }

        public string UserLogin(User request){
            using(sqlCon=GetConnection()){
                var result="";
                var param=new DynamicParameters();;
                param.Add("@Email", request.Email);
                param.Add("@MobileNo", request.MobileNo);
                param.Add("@Password", request.Password);
                try
                {
                    result = sqlCon.Query<string>("usp_userLogin", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                 
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