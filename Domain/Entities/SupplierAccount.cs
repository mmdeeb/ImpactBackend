using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SupplierAccount : BaseAuditableEntity , IBaseAccountEntity
    {
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public double TotalBalance { get ; set ; }
        public double Debt { get; set; }
        public List<Paid>? Paids { get; set; }
    }
}
