using CodingChallenge.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.WebApi.Services
{
    public interface IUserService
    {
        IList<User> GetUsers();
    }
}
