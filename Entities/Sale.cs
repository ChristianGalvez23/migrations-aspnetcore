using System;

namespace migrations_example.Entities {
    public class Sale {
        public Guid IdCustomer { get; set; }
        public Customer Customer { get; set; }
        public Guid CarId { get; set; }
        public Car Car { get; set; }
        public string CarSerie { get; set; }
        public DateTime SaleDate { get; set; }
    }
}