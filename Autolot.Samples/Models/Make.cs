

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLot.Samples.Models
{
    [Table("Makes", Schema ="dbo") ]
    public class Make : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
