using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModifiedDatabaseIdentity.Models
{
    public class UserRoleIntPk : Microsoft.AspNetCore.Identity.IdentityRole<int>
    {
        public UserRoleIntPk() : base()
        {

        }
        public UserRoleIntPk(string rolename) : base()
        {
            Name = rolename;
        }

    }
}
