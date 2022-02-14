using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The numeric identifier for the person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the person.
        /// </summary>
        /// 
        public string  FirstName { get; set; }
        /// <summary>
        /// The Last Name of the person.
        /// </summary>
        /// 
        public string LastName { get; set; }
        /// <summary>
        /// The primary e-mail address of the person.
        /// </summary>
        /// 
        public string EmailAdress { get; set; }

        /// <summary>
        /// The primary cell phone of the person.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

    }
}
