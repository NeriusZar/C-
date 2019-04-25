using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class UsersInfo // Only name, surname and photo
    {
        public UsersInfo(string firstName, string lastName, string text)
        {
            FirstName = firstName;
            LastName = lastName;
            Text = text;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Text { get; set; }
    }
}
