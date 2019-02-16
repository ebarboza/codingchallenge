using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CodingChallenge.WebApi.Models;
using CodingChallenge.WebApi.Utils;
using CodingChallenge.WebApi.ViewModels;

namespace CodingChallenge.WebApi.Services
{
    public class ProjectService : IProjectService
    {
        private CodingChallengeContext context = new CodingChallengeContext();

        public IList<ProjectViewModel> GetProject(int userId)
        {
            return context.UserProject
                .Where(a=>a.UserId == userId)
                .Include(x => x.Project)
                
                .Select(e => new ProjectViewModel
                {
                    ProjectId = e.ProjectId,
                    StartDate = e.Project.StartDate,
                    TimeToStart = DbFunctions.DiffDays(e.Project.StartDate, e.AssignedDate) > 0 ? DbFunctions.DiffDays(e.Project.StartDate, e.AssignedDate).ToString() : Constants.Started,
                    EndDate = e.Project.EndDate,
                    Credits = e.Project.Credits,
                    Status = e.IsActive ? Constants.Active : Constants.Inactive
                }).ToList<ProjectViewModel>();
        }
    }
}