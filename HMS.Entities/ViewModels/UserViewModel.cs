using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities.ViewModels
{
    public class UserViewModel
    {
        public int UserId  {get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool UserStatus { get; set; }
        public bool IsAdmin { get; set; }
    }
}
