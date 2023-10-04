

using System.ComponentModel.DataAnnotations.Schema;
using Core.Entitities.EntitiyEnums;

namespace Core.Entitities
{
    public class Submiter : User
    {   
        [ForeignKey("Project")]
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        public BussinessTypes BussinessTypes { get; set; }


        public List<Ticket> Tickets { get; set; } = new();
    }
}