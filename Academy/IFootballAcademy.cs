using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballAcademy.Players;

namespace FootballAcademy.Academy
{
    interface IFootballAcademy
    {
        Defender CreateDefender();
        Midfielder CreateMidfielder();
        Striker CreateStriker();
    }
}
