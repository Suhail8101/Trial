using Ilmume.Primary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilmume.CoreAPI.SDK.API
{
    public interface IUserProfileAPI
    {
        UserProfile GetUserProfileByID(Guid id);
        UserProfile CreateUserProfile();
        UserProfile UpdateUserProfile();

    }
}
