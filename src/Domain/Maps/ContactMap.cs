using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Domain.Entities
{
    class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Table("Contact");
            Id(e => e.Id)
                   .GeneratedBy.Sequence("Contact_seq");
            Map(e => e.Date);
            Map(e => e.Type);
            Map(e => e.Comment);
            References(e => e.Candidate);
        }

    }
}
