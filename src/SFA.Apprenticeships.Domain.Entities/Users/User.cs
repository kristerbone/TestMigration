﻿namespace SFA.Apprenticeships.Domain.Entities.Users
{
    using System;

    public class User : BaseEntity
    {
        public string Username { get; set; }

        public UserStatuses Status { get; set; }

        public UserRoles Roles { get; set; }
    }
}
