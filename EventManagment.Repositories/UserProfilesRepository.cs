using EventManagment.Models.Data;
using EventManagment.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment.Repositories
{
    public class UserProfilesRepository : IUserProfileRepository
    {
        private readonly ApplicationDbContext _db;

        public UserProfilesRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task CreateAsync(UserProfile userProfile)
        {
            await _db.UserProfiles.AddAsync(userProfile);
        }

        public async Task<UserProfile> GetByIdAsync(string id)
        {
            return await _db.UserProfiles.FindAsync(id);
        }

        public async Task<UserProfile> GetByUserId(string userId)
        {
            return await _db.UserProfiles.SingleOrDefaultAsync(up => up.UserId == userId);
        }

        public void Remove(UserProfile userProfile)
        {
            _db.UserProfiles.Remove(userProfile);
        }

        public void Update(UserProfile userProfile)
        {
            _db.Entry(userProfile).State = EntityState.Modified;
        }

    }
}
