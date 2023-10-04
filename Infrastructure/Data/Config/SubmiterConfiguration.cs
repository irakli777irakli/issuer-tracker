using Core.Entitities;
using Core.Entitities.EntitiyEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class SubmiterConfiguration : IEntityTypeConfiguration<Submiter>
    {
        public void Configure(EntityTypeBuilder<Submiter> builder)
        {
            builder.HasMany(s => s.Tickets)
                .WithOne(t => t.Submiter)
                .HasForeignKey(t => t.SubmiterId);
            
            builder.Property(s => s.BussinessTypes)
            .HasConversion(
                s => s.ToString(),
                s => (BussinessTypes)Enum.Parse(typeof(BussinessTypes),s)
            );
            
        }
    }
}