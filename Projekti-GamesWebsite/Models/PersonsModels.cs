using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekti_GamesWebsite.Models
{
    public class PersonsModels
    {
        public enum PersonType
        {
            Admin,
            User,
            Visitor
        }
        public abstract class Person
        {
            public int PersonId { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public bool IsActive { get; set; }
            public PersonType PersonType { get; set; }
        }
        public class User : Person
        {
            public List<string> WishList { get; set; }
        }
        public class Admin : Person
        {
            public DateTime StartDate { get; set; }
        }
    }
}