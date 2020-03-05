using MyTested.AspNetCore.Mvc;
using NUnit.Framework;
using System.Security.Claims;
using webTemplate.Web.Api;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Tests
{

    [TestFixture]
    public class CurrentUserControllerTests
    {

        [Test]
        public void ReturnOkWhenAdminCallingGetAction()
        {
            MyController<CurrentUserController>
                .Instance()
                .WithUser(user =>
                 user.WithClaims(new Claim(ClaimTypes.Sid, "1"))
                )
                .Calling(p => p.Get())
                .ShouldReturn()
                .Ok(result => result
                        .WithModelOfType<UserDto>()
                        .Passing(p => p.Roles.Contains("admin")));
        }

        //[Test]
        //public void ReturnOkWhenUserByJwtTokenCallingGetAction()
        //{
        //    var bearerToken = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9zaWQiOiIzIiwidW5pcXVlX25hbWUiOiJ1c2VyQGV4YW1wbGUuY29tIiwidXNlciI6IntcIklkXCI6MyxcIk5hbWVcIjpcIlRlc3QgVXNlclwiLFwiRW1haWxcIjpcInVzZXJAZXhhbXBsZS5jb21cIixcIlJvbGVzXCI6W1widXNlclwiXX0iLCJyb2xlIjoidXNlciIsIm5iZiI6MTU4MzQxMTYyMywiZXhwIjoxNTg0MDE2NDIzLCJpYXQiOjE1ODM0MTE2MjN9.mIm8q53PLcOd9-5ixcNyqxYfN0Rc7JzmvuedBDYgMd8";
        //    MyController<CurrentUserController>
        //        .Instance()
        //        .WithHttpRequest(request => request
        //        .WithHeader(HttpHeader.Authorization, bearerToken))
        //        .Calling(p => p.Get())
        //        .ShouldReturn()
        //        .Ok(result => result
        //                .WithModelOfType<UserDto>()
        //                .Passing(p => p.Roles.Contains("user")));
        //}

        [Test]
        public void ReturnOkWhenUserCallingGetAction()
        {

            MyController<CurrentUserController>
                .Instance()
                .WithUser(user =>
                 user.WithClaims(new Claim(ClaimTypes.Sid, "2"))
                )
                .Calling(p => p.Get())
                .ShouldReturn()
                .Ok(result => result
                        .WithModelOfType<UserDto>()
                        .Passing(p => p.Roles.Contains("user")));
        }

        [Test]
        public void ReturnOkWhenAnonymusCallingGetAction()
        {

            MyController<CurrentUserController>
                .Instance()
                .WithUser(user =>
                 user.WithClaims(new Claim(ClaimTypes.Sid, "0"))
                )
                .Calling(p => p.Get())
                .ShouldReturn()
                .Ok();
        }
    }
}