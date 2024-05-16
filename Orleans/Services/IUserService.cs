namespace Orleans.Services
{
    public interface IUserService
    {
        Task<List<Models.UserProfile>> GetAllUsers(Guid usersGrainId);
        Task AddUser(Models.UserProfile userProfile, Guid usersGrain);  
    }
}
