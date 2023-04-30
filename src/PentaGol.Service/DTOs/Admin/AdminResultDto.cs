using PentaGol.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.DTOs.Admin
{
    public class AdminResultDto
    {
        public string UserName { get; set; }
        public Role AdminRole { get; set; }
    }
}
