using GloboTicket.Abstractions;
using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Grains
{
    public class UserGrain : Grain, IUserGrain
    {
        private readonly IPersistentState<UserProfile> _userProfile;

        public UserGrain(
            [PersistentState(stateName: "profile", storageName: "profileStore")]
            IPersistentState<UserProfile> profile)
        {
            _userProfile = profile;
        }

        public Task Delete(UserProfile profile)
        {
            var users = _userProfile.WriteStateAsync();
            throw new NotImplementedException();
        }

        public Task<List<UserProfile>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> GetUserProfile()
        {
            return Task.FromResult(_userProfile.State);
        }

        public async Task UpdateProfile(UserProfile profile)
        {
            _userProfile.State = profile;
            await _userProfile.WriteStateAsync();
        }
    } 
}
