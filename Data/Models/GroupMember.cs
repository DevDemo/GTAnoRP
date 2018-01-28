using System.ComponentModel.DataAnnotations;
using GTAnoRP.Data;

namespace GTAnoRP.Data
{
    public class GroupMember
    {
        [Key]
        public int Id { get; set; }
        public Character Character { get; set; }
        public Group Group { get; set; }
        public bool Leader { get; set; }
    }
}