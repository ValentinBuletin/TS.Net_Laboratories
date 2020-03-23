using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibraryNetCore
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public Single Value { get; set; }
        public int Payed { get; set; }
        public int ClientId { get; set; }
        public int Deleted { get; set; }
        public virtual Client Client { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}