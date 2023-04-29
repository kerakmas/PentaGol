using PentaGol.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Domain.Entites
{
    public class Leaugue : Auditable
    {
        public string Name { get; set; }
        public string ImgPath { get; set; }
    }
}
