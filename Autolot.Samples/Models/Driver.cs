﻿
namespace AutoLot.Samples.Models
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
