using Boccee_Ball_League.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Boccee_Ball_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BocceeBallContext();
            var Teams = db.Teams;
            //var team1 = db.Teams.Single(t => t.ID == 2);
            //var team2 = db.Teams.Single(t => t.ID == 3);

            //var firstGame = new Models.Game
            //{
            //    HomeTeamID = team1.ID,
            //    AwayTeamID = team2.ID,
            //    HomeScore = 10,
            //    AwayScore = 20,
            //    DateHappened = DateTime.Now,
            //    Notes = "The away team kicked butt!!!",
            //};
            //var secondGame = new Models.Game
            //{
            //    HomeTeamID = 2,
            //    AwayTeamID = 3,
            //    HomeScore = 10,
            //    AwayScore = 20,
            //    DateHappened = new DateTime(2010, 05, 19),
            //    Notes = "Keep an eye out for no. 9",
            //};
            //var thirdGame = new Models.Game
            //{
            //    HomeTeamID = 1,
            //    AwayTeamID = 3,
            //    HomeScore = 10,
            //    AwayScore = 20,
            //    DateHappened = new DateTime(2013, 12, 24),
            //    Notes = "Ten points to Gryffindor!!!",
            //};

            //db.Games.Add(firstGame);
            //db.Games.Add(secondGame);
            //db.Games.Add(thirdGame);

            // Creating a bunch of teams.
            //var teamA = new Models.Team
            //{
            //    Mascot = "Honeybadgers",
            //    Color = "Dark Gray"
            //};
            //var teamB = new Models.Team
            //{
            //    Mascot = "Warriors",
            //    Color = "Gold"
            //};
            //var teamC = new Models.Team
            //{
            //    Mascot = "Snakes",
            //    Color = "Green"
            //};
            //var teamD = new Models.Team
            //{
            //    Mascot = "Eagles",
            //    Color = "Brown"
            //};
            //var teamE = new Models.Team
            //{
            //    Mascot = "Griffins",
            //    Color = "Silver"
            //};
            //var teamF = new Models.Team
            //{
            //    Mascot = "Tigers",
            //    Color = "Orange"
            //};

            //db.Teams.Add(teamA);
            //db.Teams.Add(teamB);
            //db.Teams.Add(teamC);
            //db.Teams.Add(teamD);
            //db.Teams.Add(teamE);
            //db.Teams.Add(teamF);

            foreach(var team in Teams)
            {
                Console.WriteLine(team.Mascot);
            }

            Console.ReadLine();
            db.SaveChanges();
        }
    }
}
