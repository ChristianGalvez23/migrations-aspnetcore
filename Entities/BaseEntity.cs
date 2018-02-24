using System;

namespace migrations_example.Entities {
    public class BaseEntity {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime SignUpDate { get; set; }
    }
}