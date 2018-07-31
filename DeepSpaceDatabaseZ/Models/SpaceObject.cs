using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DeepSpaceDatabaseZ.Models
{
    public class SpaceObject
    {
            public int ID { get; set; }

            [Required]
            public string URL { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            public float Magnitude { get; set; }

            [Required]
            public string Category { get; set; }

            [Required]
            public string Distance { get; set; }
        
    }

    public class SpaceObjectDBContext : DbContext
    {
        public DbSet<SpaceObject> SpaceObjects { get; set; }
    }
}