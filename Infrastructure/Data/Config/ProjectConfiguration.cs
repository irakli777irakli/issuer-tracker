using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasMany(pr => pr.Developers)
                .WithOne(d => d.Project)
                .HasForeignKey(d => d.ProjectId);
            
            builder.HasMany(pr => pr.Tickets)
                .WithOne(t => t.Project)
                .HasForeignKey(t => t.ProjectId);

            
        }
    }
}