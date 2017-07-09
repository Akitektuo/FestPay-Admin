using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FestPayWeb.Models
{
    public class UserModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        [DisplayName("Remember me")]
        public bool Remember { get; set; }
    }
}
