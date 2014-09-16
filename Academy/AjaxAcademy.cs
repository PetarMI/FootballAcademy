using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballAcademy.Players;

namespace FootballAcademy.Academy
{
    class AjaxAcademy : IFootballAcademy
    {
        private const String teamName = "Ajax";
        private static readonly AjaxAcademy instance = new AjaxAcademy();

        private AjaxAcademy() { }

        public static AjaxAcademy AcademyAjax
        {
            get
            {
                return instance;
            }
        }

        public String AcademyName
        {
            get { return teamName; }
        }

        public Defender CreateDefender()
        {
            return new Defender(NameGenerator.GenerateName(), 15, 10, 5, this.AcademyName);
        }

        public Midfielder CreateMidfielder()
        {
            return new Midfielder(NameGenerator.GenerateName(), 7, 18, 17, this.AcademyName);
        }

        public Striker CreateStriker()
        {
            return new Striker(NameGenerator.GenerateName(), 2, 14, 17, this.AcademyName);
        }
    }
}
