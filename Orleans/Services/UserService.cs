using AutoMapper;
using GloboTicket.Abstractions;
using Orleans.Models;

namespace Orleans.Services
{
    public class UserService : IUserService
    {
        private readonly IClusterClient _client;
        private readonly IMapper _mapper;

        public UserService(
            IClusterClient client,
            IMapper mapper)
        {
            _client = client;
            _mapper = mapper;
        }

        public async Task AddUser(Models.UserProfile userProfile, Guid usersGrain)
        {
            var userGrain = _client.GetGrain<IUsersGrain>(usersGrain);
            GloboTicket.Abstractions.UserProfile user = _mapper.Map<GloboTicket.Abstractions.UserProfile>(userProfile);
             await userGrain.AddUser(user);
        }

        public async Task<List<Models.UserProfile>> GetAllUsers(Guid usersGrainId)
        {
            var usersGrain = _client.GetGrain<IUsersGrain>(usersGrainId);
            var users = await usersGrain.GetUsers();
            return _mapper.Map<List<Models.UserProfile>>(users);
        }
    }
}
