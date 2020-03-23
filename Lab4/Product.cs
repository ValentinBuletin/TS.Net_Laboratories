using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibraryNetCore
{
    public partial class Product
    {
        public int ProductId { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        public Single Stock { get; set; }
        public Single Price { get; set; }
        public int Deleted { get; set; }
        public int OrderDetailsId { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
