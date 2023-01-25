﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMultiThreading
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Department { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
    }
}