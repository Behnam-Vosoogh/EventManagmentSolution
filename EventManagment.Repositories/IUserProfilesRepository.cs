using EventManagment.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment.Repositories
{
    public  interface IUserProfilesRepository
    {
        Task CreateAsync(UserProfile userProfile);

        Task<UserProfile> GetByIdAsync(string id);

        Task<UserProfile> GetByUserId(string userId);

        void Remove(UserProfile userProfile);

        void Update(UserProfile userProfile);
    }
}
