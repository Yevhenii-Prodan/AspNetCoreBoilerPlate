﻿using System;
using Microsoft.AspNetCore.Authorization;

namespace Boilerplate.Api.ActionFilters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorizeWithPermissionsAttribute: AuthorizeAttribute
    {
        public string[] Permissions { get; set; }

        public AuthorizeWithPermissionsAttribute(params string[] permissions) : base("JWT")
        {
            Permissions = permissions;
        }
    }
}
