

using System.Text.Json;
using Core.Entitities;

namespace Infrastructure.Data
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            if(!context.ProjectManagers.Any())
            {
                var pmData = File.ReadAllText("../Infrastructure/Data/SeedData/projectManagerData.json");
                var pm = JsonSerializer.Deserialize<List<ProjectManager>>(pmData);
                context.ProjectManagers.AddRange(pm);
            }

            if(!context.Projects.Any())
            {
                var prData = File.ReadAllText("../Infrastructure/Data/SeedData/projectData.json");
                var pr = JsonSerializer.Deserialize<List<Project>>(prData);
                context.Projects.AddRange(pr);
            }

            if(!context.Submiters.Any())
            {
                var subData = File.ReadAllText("../Infrastructure/Data/SeedData/submiterData.json");
                var sub = JsonSerializer.Deserialize<List<Submiter>>(subData);
                context.Submiters.AddRange(sub);
            }

            if(!context.Tickets.Any())
            {
                var ticketData = File.ReadAllText("../Infrastructure/Data/SeedData/ticketData.json");
                var ticket = JsonSerializer.Deserialize<List<Ticket>>(ticketData);
                context.Tickets.AddRange(ticket);
            }

            if(!context.Developers.Any())
            {
                var developerData = File.ReadAllText("../Infrastructure/Data/SeedData/developerData.json");
                var developer = JsonSerializer.Deserialize<List<Developer>>(developerData);
                context.Developers.AddRange(developer);
            }

            await context.SaveChangesAsync();
        }       
    }
}