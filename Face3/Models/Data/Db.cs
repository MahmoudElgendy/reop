using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Face3.Models.Data
{
    public class Db : DbContext
    {
        public System.Data.Entity.DbSet<Face3.Models.Data.UserDto> UserDtoes { get; set; }
    }
}