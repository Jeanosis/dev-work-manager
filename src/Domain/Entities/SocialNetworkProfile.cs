using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public class SocialNetworkProfile
    {
        public virtual int Id { get; private set; }
        public virtual SocialNetworkType Type { get; set; }
        public virtual string Link { get; set; }
        public virtual Candidate Candidate { get; set; } 
        public SocialNetworkProfile() { }
        
    }
}
