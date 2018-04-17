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
            var team1 = db.Teams.Single(t => t.ID == 2);
            var team2 = db.Teams.Single(t => t.ID == 3);

            var firstGame = new Models.Game
            {
                HomeTeamID = team1.ID,
                AwayTeamID = team2.ID,
                HomeScore = 10,
                AwayScore = 20,
                DateHappened = DateTime.Now,
                Notes = "The away team kicked butt!!!",
            };
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

            db.Games.Add(firstGame);
            //db.Games.Add(secondGame);
            //db.Games.Add(thirdGame);


            db.SaveChanges();
        }
    }
}
