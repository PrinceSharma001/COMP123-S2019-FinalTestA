using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * STUDENT NAME:
 * STUDENT NO.:
 * DESCRIPTION: Tis is the hero data Container
 */
namespace COMP123_S2019_FinalTestA.Objects
{
    class Hero
    {
        // Identity
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Physcial Abilities 
        public string Fighting { get; set; }
        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Endurance { get; set; }
        
        //Mental Abilities
        public string Reason { get; set; }
        public string Intuition { get; set; }
        public string Pysche { get; set; }
        public string Popularity { get; set; }

        //Power List
        List<Power> Powers;

        //Cpnstructor

        Hero()
        {
            //Instatiates an empty power List
            Powers = new List<Power>();
        }

    }
}
