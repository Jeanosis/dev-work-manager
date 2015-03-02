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
        private List<PhoneNumber> phonesList;
        private string email;
        private string skype;
        private string siteURL;
        private EnglishLevelType englishLevel;

        private List<Contact> contacsList;
        private List<SocialNetworkProfile> socialNetworksList;

        public Candidate()
        {
            FirstName = "";
            MiddleName = "";
            LastName = "";
            BirthdayDate = new DateTime();
            Gender = GenderType.Male;
            Country = "";
            City = "";
            RelocationAgreement = false;
            PhonesList = new List<PhoneNumber>();
            //photo

            Email = "";
            Skype = "";
            SiteURL = "";
            EnglishLevel = EnglishLevelType.Beginner;

            ContacsList = new List<Contact>();
            SocialNetworksList = new List<SocialNetworkProfile>();

        }

        public Candidate(string _firstName, string _middleName, string _lastName, GenderType _gender)
        {
            FirstName = _firstName;
            MiddleName = _middleName;
            LastName = _lastName;
            BirthdayDate = new DateTime();
            Gender = _gender;
            Country = "";
            City = "";
            RelocationAgreement = false;
            PhonesList = new List<PhoneNumber>();
            //photo

            Email = "";
            Skype = "";
            SiteURL = "";
            EnglishLevel = EnglishLevelType.Beginner;

            ContacsList = new List<Contact>();
            SocialNetworksList = new List<SocialNetworkProfile>();

        }

        public Candidate(string _firstName, string _middleName, string _lastName, GenderType _gender, Contact _contact)
        {
            FirstName = _firstName;
            MiddleName = _middleName;
            LastName = _lastName;
            BirthdayDate = new DateTime();
            Gender = _gender;
            Country = "";
            City = "";
            RelocationAgreement = false;
            PhonesList = new List<PhoneNumber>();
            //photo

            Email = "";
            Skype = "";
            SiteURL = "";
            EnglishLevel = EnglishLevelType.Beginner;

            ContacsList = new List<Contact>();
            ContacsList.Add(_contact);
            SocialNetworksList = new List<SocialNetworkProfile>();
        }

        public Candidate(string _firstName, string _middleName, string _lastName, GenderType _gender, List<Contact> _contactsList)
        {
            FirstName = _firstName;
            MiddleName = _middleName;
            LastName = _lastName;
            BirthdayDate = new DateTime();
            Gender = _gender;
            Country = "";
            City = "";
            RelocationAgreement = false;
            PhonesList = new List<PhoneNumber>();
            //photo

            Email = "";
            Skype = "";
            SiteURL = "";
            EnglishLevel = EnglishLevelType.Beginner;

            ContacsList = _contactsList;
            ContacsList.Sort((x, y) => y.Date.CompareTo(x.Date));
            SocialNetworksList = new List<SocialNetworkProfile>();
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (value == null)
                    firstName = "";
                else firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                if (value == null)
                    middleName = "";
                else middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (value == null)
                    lastName = "";
                else lastName = value;
            }
        }

        
        public DateTime BirthdayDate
        {
            get
            {
                return birthdayDate;
            }
            set
            {
                if (value == null)
                    birthdayDate = new DateTime();
                else birthdayDate = value;
            }
        }
        public GenderType Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (value == null)
                    country = "";
                else country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (value == null)
                    city = "";
                else city = value;
            }
        }
        public bool RelocationAgreement { get { return relocationAgreement; } set { relocationAgreement = value; } }
        public Image Photo { get; set; } //???
        public List<PhoneNumber> PhonesList
        {
            get
            {
                return phonesList;
            }
            set
            {
                if (value == null)
                    phonesList = new List<PhoneNumber>();
                else phonesList = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value == null)
                    email = "";
                else email = value;
            }
        }
        public string Skype
        {
            get
            {
                return skype;
            }
            set
            {
                if (value == null)
                    skype = "";
                else skype = value;
            }
        }
        public string SiteURL
        {
            get
            {
                return siteURL;
            }
            set
            {
                if (value == null)
                    siteURL = "";
                else siteURL = value;
            }
        }
        public EnglishLevelType EnglishLevel { get; set; }

        public List<Contact> ContacsList
        {
            get
            {
                return contacsList;
            }
            set
            {
                if (value == null)
                    contacsList = new List<Contact>();
                else contacsList = value;
            }
        }
        public List<SocialNetworkProfile> SocialNetworksList
        {
            get
            {
                return socialNetworksList;
            }
            set
            {
                if (value == null)
                    socialNetworksList = new List<SocialNetworkProfile>();
                else socialNetworksList = value;
            }
        }

        //List has to be sorted by dates
        public Contact getLastContact()
        {
            return ContacsList[ContacsList.Count-1];
        }
        
    }
}
