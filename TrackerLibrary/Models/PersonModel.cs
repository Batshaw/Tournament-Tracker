using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// First Name of the player.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of the player.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email of the player.
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// Phonenumber of the player.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Id of the Person
        /// </summary>
        public int Id { get; set; }
    }
}
