using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevWorkMainProject
{
    enum PhoneType
    {
        Home,
        Mobile
    }
    class PhoneNumber
    {
        private string phone;
        private PhoneType type;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public PhoneType Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
