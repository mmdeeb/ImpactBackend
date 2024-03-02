using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Receipt : BaseAuditableEntity
    {
        public DateTime Date { get; set; }
        public string? Receiver { get; set; }
        public string? Payer { get; set; }
        public double Amount { get; set; }

    }
}
