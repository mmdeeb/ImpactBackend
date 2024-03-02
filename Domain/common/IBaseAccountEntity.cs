using Domain.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.common
{
    public interface IBaseAccountEntity
    {
        public double TotalBalance { get; set; }
        public double Debt { get; set; }
        public List<Paid>? Paids { get; set; }
    }
}
