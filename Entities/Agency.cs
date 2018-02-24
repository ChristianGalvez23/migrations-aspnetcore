using System;
using System.Collections.Generic;

namespace migrations_example.Entities {
    public class Agency : BaseEntity {
        public Agency () {
            this.Cars = new List<Car> ();
        }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Brand { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}