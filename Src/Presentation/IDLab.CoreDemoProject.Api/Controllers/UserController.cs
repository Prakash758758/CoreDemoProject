using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using IDLab.CoreDemoProject.Application.Interfaces;
using System.Collections.Generic;
using IDLab.CoreDemoProject.Domain.Models;

namespace IDLab.CoreDemoProject.Api.Controllers
{

    public class UserController : BaseController
    {
        private readonly IUser _iUser;
        //public UserController(IUser iuser)=>_iUser = iuser;
        public UserController(IUser iuser){
            this._iUser=iuser;
        }
        
        [HttpGet]
        public ActionResult GetUser() => Ok(_iUser.GetUser());

        [HttpPost]
        [Route("CreateUser")]
        public ActionResult CreateUser([FromBody] User request){
            var x=new {success=_iUser.CreateUser(request)};
            return Ok(x);
        }
        
    }
}