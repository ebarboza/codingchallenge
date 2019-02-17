using CodingChallenge.WebApi.Models;
using System.Collections.Generic;

namespace CodingChallenge.WebApi.Services
{
    public interface IUserService
    {
        IList<User> GetUsers();
    }
}
