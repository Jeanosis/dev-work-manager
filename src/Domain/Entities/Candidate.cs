using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Domain
{
    public class Candidate
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime dob;
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
            BirthdayDate = new DateTime();
            PhonesList = new List<PhoneNumber>();
            ContacsList = new List<Contact>();
            SocialNetworksList = new List<SocialNetworkProfile>();
        }


        public virtual int Id { get; private set; }
        public virtual string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public virtual string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }

        public virtual string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }


        public virtual DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                if (value == null)
                    dob = new DateTime();
                else dob = value;
            }
        }
        public virtual GenderType Gender
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
        public virtual string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public virtual string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public virtual bool RelocationAgreement { get { return relocationAgreement; } set { relocationAgreement = value; } }
        public virtual Image Photo { get; set; } //???
        public virtual List<PhoneNumber> PhonesList
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
        public virtual string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public virtual string Skype
        {
            get
            {
                return skype;
            }
            set
            {
                skype = value;
            }
        }
        public virtual string SiteURL
        {
            get
            {
                return siteURL;
            }
            set
            {
                siteURL = value;
            }
        }
        public virtual EnglishLevelType EnglishLevel { get; set; }

        public virtual List<Contact> ContacsList
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
        public virtual List<SocialNetworkProfile> SocialNetworksList
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
        public virtual void AddPhoneNumber(PhoneNumber phone)
        {
            PhonesList.Add(phone);
        }

        public virtual void AddContact(Contact contact)
        {
            ContacsList.Add(contact);
        }

        public virtual void AddSocialNetwork(SocialNetworkProfile socialNetwork)
        {
            SocialNetworksList.Add(socialNetwork);
        }

        //List has to be sorted by dates
        public virtual Contact getLastContact()
        {
            return ContacsList[ContacsList.Count - 1];
        }
    }
}
