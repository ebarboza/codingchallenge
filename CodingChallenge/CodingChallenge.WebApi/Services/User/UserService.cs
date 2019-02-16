using CodingChallenge.WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.WebApi.Services
{
    public class UserService : IUserService
    {
        private CodingChallengeContext context = new CodingChallengeContext();
        public IList<User> GetUsers()
        {
            return context.User.ToList();
        }
    }
}