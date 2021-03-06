﻿using System.Collections.Generic;

namespace CommunityToolShedCore.Models
{
    interface IUserRepository
    {
        ApplicationUser GetById(string Id);
        IList<ApplicationUser> GetAllUsers();
        ApplicationUser Add(ApplicationUser user);
        ApplicationUser Update(ApplicationUser userChanges);
        ApplicationUser Delete(string Id);
    }
}
