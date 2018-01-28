using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using GTAnoRP.Data.Enums;

namespace GTAnoRP.Data
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [StringLength(32)]
        public string Name { get; set; }

        public GroupType Type { get; set; }
        public GroupExtraType ExtraType { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
        
    }
}