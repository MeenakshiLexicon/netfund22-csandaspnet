﻿namespace _01_Identity.Models
{
    public class UserProfile
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DisplayName => $"{FirstName} {LastName}";
    }
}
