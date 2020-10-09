namespace DBFirstLibrary
{
    public partial class Books
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long YearOfPublication { get; set; }
        public long? AuthorId { get; set; }

        public virtual Authors Author { get; set; }
    }
}
