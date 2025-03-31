using System;

namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        public string UserName { get; set; } = string.Empty;
        public bool IsLoggedIn { get; set; } = false;

        public void Login(string userName)
        {
            UserName = userName;
            IsLoggedIn = true;
        }

        public void Logout()
        {
            UserName = string.Empty;
            IsLoggedIn = false;
        }
    }
}