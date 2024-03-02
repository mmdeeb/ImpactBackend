using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TrainerAccount : BaseAuditableEntity,IBaseAccountEntity
    {
        public Trainer Trainer { get; set; }
        public List<Training> Trainings { get; set; }
        public double TotalBalance { get; set; }
        public double Debt { get; set; }
        public List<Paid>? Paids { get; set; }
    }
}
