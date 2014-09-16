using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballAcademy
{
    class NameGenerator
    {
        private static Random rand = new Random();
        private static String[] firstName = { "Thiago", "James", "Ricardo", "Thomas", "Mats", "Sebasian" };
        private static String[] lastName = { "Nesta", "Rodrigez", "Silva", "Lahm", "Verratti", "Hazard" };

        private NameGenerator() { }

        public static String GenerateName()
        {
            int i = rand.Next(6);
            int j = rand.Next(6);

            return String.Format("{0} {1}", firstName[i], lastName[j]); 
        }
    }
}
