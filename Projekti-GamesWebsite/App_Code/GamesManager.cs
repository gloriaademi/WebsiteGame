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

            Games.Add(new Models.Games()
            {
                Title= "PlayerUnknown's Battlegrounds",
                Description= "Battlegrounds is a player versus player shooter game in which up to one hundred players fight in a battle royale, a type of large-scale last man standing deathmatch where players fight to remain the last alive. Players can choose to enter the match solo, duo, or with a small team of up to four people.",
                Price ="30$",
                Quantity = 30,
                SKU= "518150",
                Referenca = Guid.NewGuid().ToString().Replace("-", ""),
                Image = "~/assets/images/Pubg-Card.jpg",
                Categories = new List<string>() { "Action"}

            });
            Games.Add(new Models.Games()
            {
                Title = "Fortnite",
                Description = "Fortnite is a survival game where 100 players fight against each other in player versus player combat to be the last one standing. It is a fast-paced, action-packed game, not unlike The Hunger Games, where strategic thinking is a must in order to survive. There are an estimated 125 million players on Fortnite.",
                Price = "80$",
                Quantity = 30,
                SKU = "E6603",
                Referenca = Guid.NewGuid().ToString().Replace("-", ""),
                Image = "~/assets/images/Fortnite.jpg",
                Categories = new List<string>() { "Action" }

            });
            Games.Add(new Models.Games()
            {
                Title = "GTA V",
                Description = "Grand Theft Auto V is an action-adventure game played from either a third-person or first-person perspective. Players complete missions—linear scenarios with set objectives—to progress through the story. Outside of the missions, players may freely roam the open world.",
                Price = "45$",
                Quantity = 30,
                SKU = "7358056",
                Referenca = Guid.NewGuid().ToString().Replace("-", ""),
                Image = "~/assets/images/GTA-5.jpg",
                Categories = new List<string>() { "Action" }

            });
            Games.Add(new Models.Games()
            {
                Title = "Forza Horizon 4",
                Description = "Forza Horizon 4 is a 2018 racing video game developed by Playground Games and published by Microsoft Studios. It was released on 2 October 2018 on Xbox One and Microsoft Windows after being announced at Xbox's E3 2018 conference. An enhanced version of the game was released on Xbox Series X/S on 10 November 2020.",
                Price = "10$",
                Quantity = 30,
                SKU = "6255310",
                Referenca = Guid.NewGuid().ToString().Replace("-", ""),
                Image = "~/assets/images/forza-horizon-4.jpg",
                Categories = new List<string>() { "Racing" }

            });
            Games.Add(new Models.Games()
            {
                Title = "God of War 4",
                Description = "God of War is an action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment. Released worldwide on April 20, 2018, for the PlayStation 4, it is the eighth installment in the God of War series, the eighth chronologically, and the sequel to 2010's God of War III.",
                Price = "20$",
                Quantity = 30,
                SKU = "3001886",
                Referenca = Guid.NewGuid().ToString().Replace("-", ""),
                Image = "~/assets/images/God_of_War_4.jpg",
                Categories = new List<string>() { "Strategy" }

            });
            Games.Add(new Models.Games()
            {
                Title = "Rocket League",
                Description = "Rocket League is a vehicular soccer video game developed and published by Psyonix. The game was first released for Microsoft Windows and PlayStation 4 in July 2015, with ports for Xbox One and Nintendo Switch being released later on.",
                Quantity = 30,
                SKU = "6290418",
                Referenca = Guid.NewGuid().ToString().Replace("-", ""),
                Image = "~/assets/images/Rocket_League.jpg",
                Categories = new List<string>() { "Sport" }

            });
        }
    }
}