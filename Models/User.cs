using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;
    }
}
