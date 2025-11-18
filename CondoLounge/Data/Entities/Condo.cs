using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondoLounge.Data.Entities
{
    public class Condo
    {
        public int BuildingId { get; set; }

        [Key]
        public int CondoNumber { get; set; }

        public string Location { get; set; }

        public ApplicationUser[] Users { get; set; }
    }
}
