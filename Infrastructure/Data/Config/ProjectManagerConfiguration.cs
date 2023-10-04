using Core.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProjectManagerConfiguration : IEntityTypeConfiguration<ProjectManager>
    {
        public void Configure(EntityTypeBuilder<ProjectManager> builder)
        {
            builder.HasMany(pm => pm.Projects)
                .WithOne(pr => pr.ProjectManager)
                .HasForeignKey(pr => pr.ProjectManagerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}