﻿using System.Collections.Generic;

namespace Dovs.Q2AAutoKit.Interfaces
{
    // Interface to abstract the user registration process
    public interface IUserRegistrationService
    {
        bool RegisterUsers(List<UserData> users, string password);
    }
}
