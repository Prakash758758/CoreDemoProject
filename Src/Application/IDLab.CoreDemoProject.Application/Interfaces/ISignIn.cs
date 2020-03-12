using  IDLab.CoreDemoProject.Domain.Models;

namespace IDLab.CoreDemoProject.Application.Interfaces
{
    public interface ISignIn
    {
       string UserLogin(SignIn request);
    } 
}