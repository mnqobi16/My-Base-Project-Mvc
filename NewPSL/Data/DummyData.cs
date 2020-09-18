using NewPSL.Models.PSL;
using NewPSL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewPSL.Data
{
    public class DummyData
    {
        public static List<Team> getTeams()
        {

            List<Team> teams = new List<Team>()
            {
                new Team()
                {
                    TeamName="Pirates",
                    City="JHB",
                    Provice="Gauteng",
                    Country="South Africa"
                },
                new Team()
                {
                    TeamName="Amazulu",
                    City="Durban",
                    Provice="KZN",
                    Country="South Africa"
                },
                new Team()
                {
                    TeamName="Cape Town City",
                    City="Cape Town",
                    Provice="Western Cape",
                    Country="South Africa"
                },
                new Team()
                {
                    TeamName="Chiefs",
                    City="Mtubatuba",
                    Provice="KZN",
                    Country="Zimbabwe"
                },
            };
            return teams;
        }

        public static List<Player> getPlayers(PSLContext context)
        {

            List<Player> players = new List<Player>()
            {
                new Player()
                {
                    LastName="Mgazi",
                    FirstName="Mnqobi",
                    
                    Position="Mid",
                    TeamName=context.Teams.Find("Pirates").TeamName,


                },
                new Player()
                {
                    LastName="Biyela",
                    FirstName="Khethelo",
                    Position="Forward",
                    TeamName=context.Teams.Find("Amazulu").TeamName,
                },
                new Player()
                {
                    LastName="Ntopho",
                    FirstName="Sandile",
                    Position="Defence",
                    TeamName=context.Teams.Find("Cape Town City").TeamName,
                },
            };

            return players;
        }

        public static List<Gender> getGender()
        {

            List<Gender> Genders = new List<Gender>()
            {
                new Gender()
                {
                    
                    GenderName="Male",


                },
                new Gender()
                {

                    GenderName="Female",
                },
                new Gender()
                {

                    GenderName="Don't want to specify",
                },

            };

            return Genders;
        }

    }
}