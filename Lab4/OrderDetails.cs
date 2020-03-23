using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    public partial class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int ProductId { get; set; }
        public Single Qty { get; set; }
        public Single Price { get; set; }
        public int Deleted { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
