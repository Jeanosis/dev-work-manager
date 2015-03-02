using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Domain.Entities
{
    class SocialNetworkProfileMap : ClassMap<SocialNetworkProfile>
    {
        SocialNetworkProfileMap()
        {
            Table("SocialNetwork");
            Id(e => e.Id)
                   .GeneratedBy.Sequence("SocialNetwork_seq");
            Map(e => e.Type);
            Map(e => e.Link);
            References(e => e.Candidate);
        }
    }
}
