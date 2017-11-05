// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Api.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [Route("[controller]")]
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        [TestAuthorize("User_Edit1")]
        public IActionResult Get()
        {
            return new JsonResult(from c in HttpContext.User.Claims select new { c.Type, c.Value });
        }

    }
}