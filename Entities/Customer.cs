using System;
using System.Collections.Generic;

namespace migrations_example.Entities {
    public class Customer : BaseEntity {
        public Customer () {
            this.CarsOwned = new List<Sale> ();
        }

        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public DateTime BornDate { get; set; }
        public ICollection<Sale> CarsOwned { get; set; }
    }
}