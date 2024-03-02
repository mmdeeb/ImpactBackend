using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OtherExpenses : BaseAuditableEntity
    {
        public string? Description { get; set; }
        public Employee? Employee { get; set; }
        public string? PhotoInvoiceURL { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
    }
}
