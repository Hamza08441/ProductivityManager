
using webapi.Data;
using webapi.Models;
using webapi.ViewModels;
namespace webapi.services.ProjectsService
{
    public class ProjectsService : IProjectsService
    {
        private readonly dbContext _context;
        public ProjectsService(dbContext context)
        {
            _context = context;
        }
        public Projects addProject(ProjectsVM projectsVM)
        {
            Projects newProjects = new Projects()
            {

                id = Guid.NewGuid(),
                name = projectsVM.name,
                region = projectsVM.region,
                leader_id = projectsVM.leader_id



            };
            _context.projects.Add(newProjects);
            _context.SaveChanges();
            return newProjects;
        }

    }

}

