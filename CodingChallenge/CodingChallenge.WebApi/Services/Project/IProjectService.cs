using CodingChallenge.WebApi.ViewModels;
using System.Collections.Generic;

namespace CodingChallenge.WebApi.Services
{
    public interface IProjectService
    {
        IList<ProjectViewModel> GetProject(int userId);
    }
}