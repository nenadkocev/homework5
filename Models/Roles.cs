using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace d5.Models
{
    public static class Roles
    {
        public const string Administrator = "Administrator";
        public const string Manager = "Manager";
        public const string User = "User";
        public const string AdminOrManager = Administrator + "," + Manager;
    }
}