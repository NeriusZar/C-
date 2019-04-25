using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class User : IEnumerable // Only name, surname and information
    {
        public User(string firstName, string lastName, string information)
        {
            FirstName = firstName;
            LastName = lastName;
            Information = information;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Information { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
