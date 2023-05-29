using webapi.Models;
using webapi.ViewModels;

namespace webapi.services.ProjectsService
{
    public interface IProjectsService
    {
        public Projects addProject(ProjectsVM projectsVM);

        public Projects FindProjectById(Guid projectID);
    }
}

