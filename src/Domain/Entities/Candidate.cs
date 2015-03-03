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
        public Candidate()
        {
            PhonesList = new List<PhoneNumber>();
            ContactsList = new List<Contact>();
            SocialNetworksList = new List<SocialNetworkProfile>();
        }

        public virtual int Id { get; private set; }
        public virtual string FirstName {get; set;}
        public virtual string MiddleName{get; set;}
        public virtual string LastName {get; set;}
        public virtual DateTime DOB {get; set;}
        public virtual GenderType Gender {get; set;}
        public virtual string Country {get; set;}
        public virtual string City {get; set;}
        public virtual bool RelocationAgreement { get; set; }
        public virtual Image Photo { get; set; }
        public virtual List<PhoneNumber> PhonesList { get; set; }
        public virtual string Email { get; set; }
        public virtual string Skype { get; set; }
        public virtual string SiteURL { get; set; }
        public virtual EnglishLevelType EnglishLevel { get; set; }
        public virtual List<Contact> ContactsList { get; set; }
        public virtual List<SocialNetworkProfile> SocialNetworksList { get; set; }
        public virtual Contact LastContact { get; set; }
    }
}
