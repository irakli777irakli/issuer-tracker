using System.ComponentModel.DataAnnotations.Schema;
using Core.Entitities.EntitiyEnums;

namespace Core.Entitities
{
    public class Ticket : SharedProperties
    {
        public int Id { get; set; }
        
        public BugSevarity BugSevarity { get; set; }
        public BugStatus BugStatus { get; set; }

        [ForeignKey("Project")]
        public int? ProjectId { get; set; }
        public Project Project { get; set; }


        [ForeignKey("Submiter")]
        public int? SubmiterId { get; set; }
        public Submiter Submiter { get; set; }

        [ForeignKey("Developer")]
        public int? DeveloperId { get; set; }
        public Developer Developer { get; set; }

        
        [ForeignKey("Ticket")]
        public int? TicketHistoryId { get; set; }
        public Ticket TicketHistory { get; set; }

        public List<Ticket> TicketHistories { get; set; } = new();
    }
}