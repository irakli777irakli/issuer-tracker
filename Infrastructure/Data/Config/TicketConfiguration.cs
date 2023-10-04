using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entitities;
using Core.Entitities.EntitiyEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Config
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            

           builder
            .Property(t => t.BugSevarity)
            .HasConversion(
                t => t.ToString(),
                t => (BugSevarity)Enum.Parse(typeof(BugSevarity),t)
            );

          builder.Property(t => t.BugStatus)
            .HasConversion(
                t => t.ToString(),
                t => (BugStatus)Enum.Parse(typeof(BugStatus),t)
            );
            
                
        }
    }
}