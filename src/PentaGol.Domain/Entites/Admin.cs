using PentaGol.Domain.Commons;
using PentaGol.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Domain.Entites
{
    public class Admin : Auditable
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role AdminRole { get; set; }
    }
}
