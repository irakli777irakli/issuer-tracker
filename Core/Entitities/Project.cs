using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entitities
{
    public class Project : SharedProperties
    {
        public int Id { get; set; }
        

        [ForeignKey("ProjectManager")]
        public int? ProjectManagerId { get; set; }
        public ProjectManager ProjectManager { get; set; }


        public List<Developer> Developers { get; set; } = new();

        public Submiter Submiter { get; set; }

        public List<Ticket> Tickets { get; set; } = new();

    }
}