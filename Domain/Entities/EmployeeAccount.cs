﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EmployeeAccount : BaseAuditableEntity
    {
        public Employee? Employee { get; set; }
        public int? EmployeeId { get; set; }
        public double Salary { get; set; }
        public double? Deduct { get; set; }
        public double? AdvancePayment { get; set; }
        public double? Reward { get; set; }
        public double TotalBalance { get; set; }
        public double Debt { get; set; }
        public List<ReceiptToEmployee>? ReceiptToEmployees { get; set; }
    }
}
