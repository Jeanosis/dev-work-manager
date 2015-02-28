using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevWorkMainProject
{
    enum ContactType
    {
        Meet,
        Call

    }
    class Contact
    {
        private ContactType type;
        private DateTime date;
        private string comment;
        public ContactType Type
        {
            get { return type; }
            set { type = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
    }
}
