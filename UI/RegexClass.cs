
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace UI
{
    
    class RegexClass
    {
        static Regex NameRegex = new Regex(@"^[a-zA-Z ]*$");
        static private Regex Name()
        {
            return NameRegex;
        }
        public static int Ragex_Check(TextBox text)
        {
            if (Name().IsMatch(text.Text))
                return 1;
            else return 0;
        }
    }
}
