using System.ComponentModel.DataAnnotations;

namespace PorTala.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }

        public string ProjectName { get; set; }

        public string Location { get; set; }

        public string Developer { get; set; }

        public string PropertyType { get; set; }

        public string PriceRange { get; set; }

        public string Status { get; set; }
    }
}