using System.ComponentModel.DataAnnotations;

namespace PorTala.Models
{
    public class Agent
    {
        [Key]
        public int AgentID { get; set; }

        public string FullName { get; set; }

        public string ContactNumber { get; set; }

        public string Branch { get; set; }

        public string Position { get; set; }
    }
}