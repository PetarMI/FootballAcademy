using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballAcademy
{
    class Skills
    {
        private uint defending;
        private uint passing;
        private uint goalScoring;

        public Skills(uint defending, uint passing, uint goalScoring)
        {
            this.defending = defending;
            this.passing = passing;
            this.goalScoring = goalScoring;
        }

        public uint Defending
        {
            get { return this.defending; }
            set { this.defending = value; }
        }

        public uint Passing
        {
            get { return this.passing; }
            set { this.passing = value; }
        }

        public uint GoalScoring
        {
            get { return this.goalScoring; }
            set { this.goalScoring = value; }
        }
    }
}
