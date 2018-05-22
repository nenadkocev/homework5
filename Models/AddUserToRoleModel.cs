using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace d5.Models
{
    public class AddUserToRoleModel
    {
        public List<string> roles { get; set; }
        public string selectedRole{ get; set; }
        [Display(Name = "E-mail")]
        public string email { get; set; }
        public AddUserToRoleModel()
        {
            roles = new List<string> { "Administrator", "Manager", "User" };
        }
    }
}