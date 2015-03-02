using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public class SocialNetworkProfile
    {
        private SocialNetworkType type;
        private string link;
        public virtual int Id { get; private set; }
        public virtual SocialNetworkType Type
        {
            get { return type; }
            set { type = value; }
        }
        public virtual string Link
        {
            get { return link; }
            set { link = value; }
        }


        public virtual Candidate Candidate { get; set; } 
        public SocialNetworkProfile() { }
        
    }
}
