using Core.Entitities;
using Core.Entitities.EntitiyEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class DeveloperConfiguration : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            
            builder.HasMany(d => d.AssignedTickets)
                .WithOne(t => t.Developer)
                .HasForeignKey(t => t.DeveloperId);

            builder.Property(d => d.SpecializeIn)
                .HasConversion(
                    d => d.ToString(),
                    d => (SkilledIn)Enum.Parse(typeof(SkilledIn),d)
                );
        
            
        }
    }
}