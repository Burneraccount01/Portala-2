using System.ComponentModel.DataAnnotations;

namespace PorTala.Models
{
    public class NavigationMenu
    {
        [Key]
        public int MenuID { get; set; }

        public string Title { get; set; } = "";

        public int? ParentMenuID { get; set; }

        public string MenuURL { get; set; } = "";

        public int DisplayOrder { get; set; }

        public bool IsVisible { get; set; }
    }
}