using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Abstractions
{
    public interface IUserGrain : IGrainWithGuidKey
    {
        Task<UserProfile> GetUserProfile();
        Task<List<UserProfile>> GetAllUser();

        Task UpdateProfile(UserProfile profile);
        Task Delete(UserProfile profile);
    }

}
