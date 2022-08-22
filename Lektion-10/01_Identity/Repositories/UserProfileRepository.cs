using _01_Identity.Data;
using _01_Identity.Models;
using _01_Identity.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _01_Identity.Repositories
{
    public interface IUserProfile
    {
        public Task CreateUserProfileAsync(UserProfile profile);
        public Task<UserProfileEntity> GetUserProfileAsync(string id);
        public Task UpdateUserProfileAsync(string id, string firstName, string lastName);
    }

    public class UserProfileRepository : IUserProfile
    {
        private readonly ApplicationDbContext _context;

        public UserProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateUserProfileAsync(UserProfile profile)
        {
            _context.UserProfiles.Add(new UserProfileEntity
            {
                UserId = profile.UserId,
                FirstName = profile.FirstName,
                LastName = profile.LastName
            });
            await _context.SaveChangesAsync();
        }

        public async Task<UserProfileEntity> GetUserProfileAsync(string id)
        {
            var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(x => x.UserId == id);
            return userProfile;
        }

        public async Task UpdateUserProfileAsync(string id, string firstName, string lastName)
        {
            var userProfile = await _context.UserProfiles.FindAsync(id);
            userProfile.FirstName = firstName;
            userProfile.LastName = lastName;

            await _context.SaveChangesAsync();

        }
    }
}
