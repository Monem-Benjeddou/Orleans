using GloboTicket.Abstractions;
using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.Grains
{
    public class UsersGrain : Grain, IUsersGrain
    {
        private readonly IPersistentState<List<UserProfile>> _usersProfiles;

        public UsersGrain(
            [PersistentState(stateName: "profiles", storageName: "profiles")]
            IPersistentState<List<UserProfile>> profiles)
        {
            _usersProfiles = profiles;
        }
        public async Task AddUser(UserProfile user)
        {
            var usersGrain = _usersProfiles.State;
            usersGrain.Add(user);
            await _usersProfiles.WriteStateAsync();

        }

        public Task<List<UserProfile>> GetUsers()
        {
            return Task.FromResult(_usersProfiles.State);
        }
    }
}
