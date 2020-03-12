using IDLab.CoreDemoProject.Application.Interfaces;
using IDLab.CoreDemoProject.Domain.Models;
using IDLab.CoreDemoProject.Persistence.DBContext;

namespace IDLab.CoreDemoProject.Application.Repositories
{
    public class UserRepository : IUser
    {
        UserDBContext _iClientDBContext;
        public User GetUser()
        {
            _iClientDBContext = new UserDBContext();
            return _iClientDBContext.GetUser();
        }

        public string CreateUser(User request){
            _iClientDBContext = new UserDBContext();
           return _iClientDBContext.CreateUser(request);
        }

        public string IsUserExist(User request){
            _iClientDBContext=new UserDBContext();
            return _iClientDBContext.IsUserExist(request);
        }

        public string OTPVerification(User request){
            _iClientDBContext=new UserDBContext();
            return _iClientDBContext.OTPVerification(request);
        }

        // public string UserLogin(User request){
        //     _iClientDBContext=new UserDBContext();
        //     return _iClientDBContext.UserLogin(request);
        // }
    }
}