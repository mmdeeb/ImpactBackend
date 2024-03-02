using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrganizationAccount : BaseAuditableEntity
    {
        public Organization Name { get; set; }
        public List<Training> Trainings { get; set; }
        public double Discount { get; set; }
        public List<Receipt>? Receipts { get; set; }
    }
}
