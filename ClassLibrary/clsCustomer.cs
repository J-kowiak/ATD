using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public bool Archived { get; set; }
    }
}