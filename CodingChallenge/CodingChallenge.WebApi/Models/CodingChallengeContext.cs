using CodingChallenge.WebApi.Models;
using System.Data.Entity;

namespace CodingChallenge.WebApi.Models
{
    public class CodingChallengeContext : DbContext
    {
        public CodingChallengeContext()
            : base("DefaultConnection") { }

        public IDbSet<User> User { get; set; }
        public IDbSet<Project> Project { get; set; }
        public IDbSet<UserProject> UserProject { get; set; }

    }
}