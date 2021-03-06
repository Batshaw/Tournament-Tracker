﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Represents a list of the team members as constructor.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents the name of the team.
        /// </summary>
        public string TeamName { get; set; }

        public int Id { get; set; }

    }
}
