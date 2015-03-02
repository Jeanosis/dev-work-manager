using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DevWorkMainProject
{
    public class Candidates
    {
        public static List<Candidate> GetData()
        {
            Contact newContact = null;
            List<Candidate> Result = new List<Candidate>();

            for (int i = 0; i < 10; i++)
            {
                newContact = new Contact();
                newContact.Date = new DateTime(1994, 01, 15 + i);
                newContact.Comment = String.Format("This is comment #{0}", i);
                newContact.Type = ContactType.Meet;

                Result.Add(new Candidate(String.Format("Vasya_{0}", i), String.Format("Vasilievich_{0}", i),
                    String.Format("Pupkin_{0}", i), GenderType.Male, newContact));
            }

            return Result;
        }
    }
}
