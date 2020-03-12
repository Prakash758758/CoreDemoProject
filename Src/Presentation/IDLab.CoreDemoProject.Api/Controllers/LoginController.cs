using System;
using Microsoft.AspNetCore.Mvc;
using IDLab.CoreDemoProject.Application.Interfaces;
using IDLab.CoreDemoProject.Domain.Models;

namespace IDLab.CoreDemoProject.Api.Controllers
{


    public class LoginController : BaseController
    {

   private readonly ISignIn _iSignIn;
    public LoginController(ISignIn isignIn){
            this._iSignIn=isignIn;
        }
        [HttpGet]
        public string loginget()
        {
            return "helo";
        }
        [HttpPost]
        public ActionResult UserLogin([FromBody] SignIn request)
        {
            var x = new { success = _iSignIn.UserLogin(request) };
            return Ok(x);
        }

        // [HttpPost]
        //         public string loginget([FormBody] string abc)
        //         {
        //             return "helo";
        //         }

        //     }

    }
}