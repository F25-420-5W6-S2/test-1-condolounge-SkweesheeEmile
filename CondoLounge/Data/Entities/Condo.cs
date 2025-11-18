using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondoLounge.Data.Entities
{
    public class Condo
    {
        [ForeignKey("BuildingId")]
        public int BuildingId { get; set; }

        [Key]
        public int CondoNumber { get; set; }

        public string Location { get; set; }

        public User[] Users { get; set; }
    }
}
