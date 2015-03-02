using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
  
    class SocialNetworkProfile
    {
        private SocialNetworkType type;
        private string link;
        public SocialNetworkType Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Link
        {
            get { return link; }
            set { link = value; }
        }
    }
}
