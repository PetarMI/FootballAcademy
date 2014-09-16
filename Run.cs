using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballAcademy.Players;
using FootballAcademy.Academy;
using FootballAcademy.Teams;

namespace FootballAcademy
{
    class Run
    {
        static void Main(string[] args)
        {
            IFootballAcademy academy = AjaxAcademy.AcademyAjax;

            Team kamenitsa = new Team("Kamenitsa");
            kamenitsa.AddDefender(academy.CreateDefender());
            kamenitsa.AddDefender(academy.CreateDefender());

            academy = RandomAcademy.AcademyRandom;
            kamenitsa.AddMidfielder(academy.CreateMidfielder());
            kamenitsa.AddMidfielder(academy.CreateMidfielder());

            academy = AjaxAcademy.AcademyAjax;
            kamenitsa.AddStriker(academy.CreateStriker());

            kamenitsa.PrintTeamFormation();
        }
    }
}
