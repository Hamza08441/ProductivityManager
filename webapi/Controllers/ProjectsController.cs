using Microsoft.AspNetCore.Mvc;
using webapi.services.ProjectsService;
using webapi.ViewModels;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController : Controller
    {
         private readonly IProjectsService _projectsService;
          public ProjectsController(IProjectsService projectsService) {

            _projectsService=projectsService;
        }
        [HttpPost(nameof(add))]
        public IActionResult add(ProjectsVM projects)
        {


            return Ok(_projectsService.addProject(projects));
        }
        [HttpPut(nameof(edit))]
        public IActionResult edit(Guid projectId, ProjectsVM projects)
        {


            return Ok(_projectsService.editProjects(projectId, projects));
        }
    }
}
