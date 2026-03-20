using System.ComponentModel.DataAnnotations;

namespace PorTala.Models
{
    public class Documents
    {
        [Key]
        public int DocumentID { get; set; }

        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public string FilePath { get; set; } = "";

        public int CategoryID { get; set; }

        public string Status { get; set; } = "";
    }
}