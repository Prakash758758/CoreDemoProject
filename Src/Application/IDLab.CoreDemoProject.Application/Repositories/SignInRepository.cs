using IDLab.CoreDemoProject.Application.Interfaces;
using IDLab.CoreDemoProject.Domain.Models;
using IDLab.CoreDemoProject.Persistence.DBContext;

namespace IDLab.CoreDemoProject.Application.Repositories
{
    public class SignInRepository : ISignIn
    {
        SignInDBContext _iSignInDBContext;
        public string UserLogin(SignIn request){
            _iSignInDBContext = new SignInDBContext();
           return _iSignInDBContext.UserLogin(request);
        }
    }
}