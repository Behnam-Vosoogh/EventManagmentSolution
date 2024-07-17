using EventManagment.Shared.Models;
using EventManagment.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment.Services
{
    public class UserProfilesService : IUserProfilesService
    {
        public Task<OperationResponse<UserProfileDetail>> GetProfileByUserIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
