﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballAcademy.Players
{
    interface IStriker : IPlayer
    {
        void ScoreGoal();
    }
}