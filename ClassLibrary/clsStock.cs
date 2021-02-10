using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Sale_Ready { get; set; }
        public DateTime NextDelivery { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
    }
}