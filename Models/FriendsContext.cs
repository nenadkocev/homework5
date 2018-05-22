using Friends.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace d5.Models
{
    public class IdentityModels : DbContext
    {
        public DbSet<FriendModel> Friends { get; set; }
    }
}