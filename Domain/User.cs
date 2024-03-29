using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class User : IdentityUser
    {
        public string DisplayName { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}