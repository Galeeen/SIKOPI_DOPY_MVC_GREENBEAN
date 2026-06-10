using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Models
{
    public class GreenBean : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string? Origin { get; set; }

        public long BeanTypeId { get; set; }

        public long? ProcessMethodId { get; set; }

        public long? GradeId { get; set; }

        public decimal StockKg { get; set; }

        public decimal PricePerKg { get; set; }
    }
}