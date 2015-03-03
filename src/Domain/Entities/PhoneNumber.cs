using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public class PhoneNumber
    {
        public virtual int Id { get; private set; }
        public virtual string Phone { get; set; }
        public virtual PhoneType Type { get; set; }
        public virtual Candidate Candidate { get; set; }
        public PhoneNumber() { }
    }
}
