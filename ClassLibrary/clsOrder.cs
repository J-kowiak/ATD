using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public DateTime DateOrderMade { get; set; }
        public bool ItemShipped { get; set; }
    }
}