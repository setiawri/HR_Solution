using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRWebApplication.Models
{
    public class BankAccountViewModels
    {
        public Guid Id { get; set; }
        public string Owner { get; set; }
        public string BankName { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public bool Internal { get; set; }
        public bool Active { get; set; }
    }
}