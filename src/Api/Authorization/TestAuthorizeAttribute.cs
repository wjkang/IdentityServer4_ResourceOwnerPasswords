using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Authorization
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class TestAuthorizeAttribute: AuthorizeAttribute
    {
        
        public string Permission { get; set; }

        public TestAuthorizeAttribute(string permission)
        {
            Permission = permission;
        }

    }
}
