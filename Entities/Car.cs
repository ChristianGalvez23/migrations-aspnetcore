using System;
using System.Collections.Generic;

namespace migrations_example.Entities {
    public class Car : BaseEntity {
        public Car () {
            this.Sales = new List<Sale> ();
        }

        public string Version { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public Guid AgencyId { get; set; }
        public Agency Agency { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}