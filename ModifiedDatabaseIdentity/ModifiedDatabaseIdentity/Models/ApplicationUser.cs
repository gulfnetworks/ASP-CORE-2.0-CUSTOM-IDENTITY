using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ModifiedDatabaseIdentity.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<int>
    {
        public int UserDetailId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string MobileNo { get; set; }
        public string UserEmail { get; set; }
        public int JobTitleId { get; set; }
        public int ManagerId { get; set; }
        public int OutletId { get; set; }
        public string ExtraOutletId { get; set; }
        public int SubscriptionId { get; set; }
        public int Active { get; set; }
        public int SettingsId { get; set; }
    }
}
