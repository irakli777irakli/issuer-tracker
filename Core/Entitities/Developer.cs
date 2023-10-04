using System.ComponentModel.DataAnnotations.Schema;
using Core.Entitities.EntitiyEnums;

namespace Core.Entitities
{
    public class Developer : User
    {      
        [ForeignKey("Project")]
        public int? ProjectId { get; set; }
        public Project Project { get; set; }


        public List<Ticket> AssignedTickets { get; set; }
        public SkilledIn SpecializeIn { get; set; }

    }
}