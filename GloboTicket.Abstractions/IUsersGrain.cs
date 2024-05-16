using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Abstractions
{
    public interface IUsersGrain : IGrainWithGuidKey
    {
        Task AddUser(UserProfile user);
        Task<List<UserProfile>> GetUsers();

    }
}
