using System.ComponentModel.DataAnnotations;

namespace PorTala.Models
{
    public class Sale
    {
        [Key]
        public int SaleID { get; set; }

        public int AgentID { get; set; }

        public int ProjectID { get; set; }

        public decimal SaleAmount { get; set; }

        public DateTime SaleDate { get; set; }

        public string Status { get; set; }
    }
}