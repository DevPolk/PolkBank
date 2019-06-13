using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.ViewModels
{
    public class BankCollection<T> where T : class
    {
        public int TotalItems { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public ICollection<T> Collection { get; set; } = new HashSet<T>();
    }
}