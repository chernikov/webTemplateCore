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
    public class RoleControllerTests
    {

        [Test]
        public void ReturnOkWhenCallingGetAction()
        {
            MyController<RoleController>
                .Instance()
                .Calling(p => p.Get())
                .ShouldReturn()
                .Ok(result =>
                result.WithModelOfType<List<RoleDto>>()
                .Passing(check => check.Count > 0));
        }
    }
}