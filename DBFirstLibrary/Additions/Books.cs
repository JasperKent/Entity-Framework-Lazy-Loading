using System;
using System.Collections.Generic;
using System.Text;

namespace DBFirstLibrary
{
    public partial class Books
    {
        public override string ToString()
        {
            return $"{Title} ({YearOfPublication})";
        }
    }
}
