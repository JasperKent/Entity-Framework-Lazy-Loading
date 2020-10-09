using System.Collections.Generic;

namespace DBFirstLibrary
{
    public partial class Authors
    {
        public Authors()
        {
            Books = new HashSet<Books>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
