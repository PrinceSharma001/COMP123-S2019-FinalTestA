﻿using System;
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
    {//PRIVATE INSTANCE VARIABLES
        private string m_fighting;
        private string m_strength;
        private string m_agility;
        private string m_endurance;
        private string m_reason;
        private string m_intuition;
        private string m_pysche;
        private string m_popularity;


        // Identity
        public string Name
        {
            get
            {
               return  m_fighting;
            }
            set
            {
                this.m_fighting = value;
                Health += int.Parse(m_fighting);
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //PRIMIARY ABILITIES

        //Physcial Abilities 
        public string Fighting
        {
            get
            {
                return m_fighting;
            }
            set
            {
                this.m_fighting = value;
                Health += int.Parse(m_fighting);
            }
        }
        public string Strength
        {
            get
            {
                return m_strength;
            }
            set
            {
                this.m_strength = value;
                Health += int.Parse(m_strength);
            }
        }
        public string Agility
        {
            get
            {
                return m_agility;
            }
            set
            {
                this.m_agility = value;
                Health += int.Parse(m_agility);
            }
        }
        public string Endurance
        {
            get
            {
                return m_endurance;
            }
            set
            {
                this.m_endurance = value;
                Health += int.Parse(m_endurance);
            }
        }

        //Mental Abilities
        public string Reason
        {
            get
            {
                return m_reason;
            }
            set
            {
                this.m_reason = value;
                Karma += int.Parse(m_reason);
            }
        }
        public string Intuition
        {
            get
            {
                return m_intuition;
            }
            set
            {
                this.m_intuition = value;
                Karma += int.Parse(m_intuition);
            }
        }
        public string Pysche
        {
            get
            {
                return m_pysche;
            }
            set
            {
                this.m_pysche = value;
                Karma += int.Parse(m_pysche);
            }
        }
        public string Popularity
        {
            get
            {
                return m_popularity;
            }
            set
            {
                this.m_popularity = value;
                Karma += int.Parse(m_popularity);
            }
        }

        //SECONDARY ABILITIES
        public int Health { get; set; }
        public int Karma { get; set; }
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
