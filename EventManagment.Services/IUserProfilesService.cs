using EventManagment.Shared.Models;
using EventManagment.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment.Services
{
    public interface IUserProfilesService
    {
        Task<OperationResponse <UserProfileDetail>> GetProfileByUserIdAsync();
        //Task<UserProfileDetail> GetProfileByUserIdAsync();

        //Task<UserProfileDetail> CreateProfileAsync(CreateProfileRequest model);
        //Task<UserProfileDetail> UpdateProfilePictureAsync(IFormFile image);
    }
}
