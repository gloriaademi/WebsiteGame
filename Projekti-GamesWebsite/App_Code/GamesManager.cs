using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekti_GamesWebsite.Core

{
    public static class GamesManager
    {
        public static List<Models.Games> Games = new List<Models.Games>();
        public static List<Models.Admin> Admins = new List<Models.Admin>();
        public static List<Models.User> Users = new List<Models.User>();
        public static void Start()
        {
            Admins.Add(new Models.Admin()
            {
                Email = "gloriaademi0@gmail.com",
                FirstName = "gloria",
                LastName = "ademi",
                IsActive = true,
                Password = "1234",
                PersonId = 1,
                PersonType = Models.PersonType.Admin,
                Username = "gloriaademi",
                StartDate = DateTime.Now
            });
            Users.Add(new Models.User()
            {
                Email = "user@gmail.com",
                FirstName = "user",
                LastName = "user",
                IsActive = true,
                Password = "0",
                PersonId = 1,
                PersonType = Models.PersonType.User,
                Username = "user"
            });


        }
    }
}