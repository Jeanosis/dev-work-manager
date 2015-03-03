using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Domain.Entities
{
    class CandidateMap : ClassMap<Candidate>
    {
        public CandidateMap()
        {
            Table("Candidate");
            Id(e => e.Id)
                   .GeneratedBy.Sequence("Candidate_seq");//на бд пернести
            Map(e => e.FirstName);
            Map(e => e.MiddleName);
            Map(e => e.LastName);
            Map(e => e.DOB);
            Map(e => e.Gender);
            Map(e => e.Country);
            Map(e => e.City);
            Map(e => e.RelocationAgreement);
            Map(e => e.Photo);
            Map(e => e.Email);
            Map(e => e.Skype);
            Map(e => e.SiteURL);
            Map(e => e.EnglishLevel);
            HasMany(x => x.PhonesList)
                          .Inverse()
                          .Cascade.All();
            HasMany(x => x.ContactsList)
                          .Inverse()
                          .Cascade.All();
            HasMany(x => x.SocialNetworksList)
                          .Inverse()
                          .Cascade.All();

        }
    }
}
