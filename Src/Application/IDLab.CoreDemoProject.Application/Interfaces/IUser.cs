using IDLab.CoreDemoProject.Domain.Models;

namespace IDLab.CoreDemoProject.Application.Interfaces
{
    public interface IUser
    {
        User GetUser();

        string CreateUser(User request);

        string IsUserExist(User request);

        string OTPVerification(User request);

        //string UserLogin(User request);
    }
}