using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public class Contact
    {
        public virtual int Id { get; private set; }
        public ContactType Type{get; set;}
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public virtual Candidate Candidate { get; set; } 
        public Contact() {}
    }
}
