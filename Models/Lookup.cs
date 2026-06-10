using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Models
{
    public class Lookup : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public override string ToString()
        {
            return Name;
        }
    }
}
