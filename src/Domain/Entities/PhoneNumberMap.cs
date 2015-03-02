using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Domain.Entities
{
    class PhoneNumberMap : ClassMap<PhoneNumber>
    {
        public PhoneNumberMap()
        {
            Table("PhoneNumber");
            Id(x => x.Id)
                    .GeneratedBy.Sequence("PhoneNumber");
            Map(x => x.Type);
            Map(x => x.Phone);

            References(e=>e.Candidate);
        }
    }
}
