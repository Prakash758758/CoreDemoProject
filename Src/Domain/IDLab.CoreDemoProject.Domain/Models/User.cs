using System;
using System.ComponentModel;
namespace IDLab.CoreDemoProject.Domain.Models
{
    public class User
    {
        //[required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //[required]
        public string LocationName { get; set; }
        //[required]
        public string Email { get; set; }
        //[required]
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string OTP { get; set; }    
        public  string InsertedBy    {get;set;}

        public string UpdatedBy { get; set; }
    }
}
