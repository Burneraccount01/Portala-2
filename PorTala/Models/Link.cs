using System.ComponentModel.DataAnnotations;

namespace PorTala.Models
{
    public class Link
    {
        [Key]
        public int LinkID { get; set; }

        public string Title { get; set; } = "";

        public string URL { get; set; } = "";

        public string Description { get; set; } = "";
    }
}