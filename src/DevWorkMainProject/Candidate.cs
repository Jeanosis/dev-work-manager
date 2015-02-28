using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DevWorkMainProject
{
    enum EnglishLevelType
    {
        Beginner,
        Elementary,
        PreIntermediate,
        Intermediate,
        UpperIntermediate,
        Advanced,
        Proficiency
    }

    enum GenderType
    {
        Male,
        Female
    }

    class Candidate
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthdayDate;
        private GenderType gender;
        private string country;
        private string city;
        private bool relocationAgreement;
        private Image photo;
        //List<PhoneNumber> PhonesList = new List<PhoneNumber>();
        private string email;
        private string skype;
        private string siteURL;
        private EnglishLevelType englishLevel;


        //This template fields and similar properties:
        private DateTime lastContactDate;
        private string lastContactComment;
        public DateTime LastContactDate
        {
            get
            {
                return lastContactDate;
            }

            set
            {
                if (value == null)
                {
                    lastContactDate = new DateTime();
                }
                else lastContactDate = value; 
            }
        }
        public string LastContactComment
        {
            get
            {
                return lastContactComment;
            }

            set
            {
                if (value == null)
                    lastContactComment = "";
                else lastContactComment = value;
            }
        }
    }
}
