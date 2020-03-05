using MyTested.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using webTemplate.Data;
using webTemplate.Domain;
using webTemplate.Web.Api;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Tests
{

    [TestFixture]
    public class AuthControllerTests
    {

        [Test]
        public void ReturnOkWhenCallingPostAction()
        {
            var login = new LoginDto()
            {
                Email = "user@example.com",
                Password = "simple"
            };
            MyController<AuthController>
                .Instance()
                .Calling(p => p.Post(login))
                .ShouldReturn()
                .Ok(result =>
                result.WithModelOfType<TokenDto>());
        }

        [Test]
        public void ReturnBadRequestWhenCallingPostAction()
        {
            var login = new LoginDto()
            {
                Email = "fake@example.com",
                Password = "simple"
            };
            MyController<AuthController>
                .Instance()
                .Calling(p => p.Post(login))
                .ShouldReturn()
                .BadRequest();
        }
    }
}