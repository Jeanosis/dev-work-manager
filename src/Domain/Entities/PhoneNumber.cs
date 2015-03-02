using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public class PhoneNumber
    {
        private string phone;
        private PhoneType type;
        public virtual int Id { get; private set; }
        public virtual string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public virtual PhoneType Type
        {
            get { return type; }
            set { type = value; }
        }
        public virtual Candidate Candidate { get; set; } 
    }
}
