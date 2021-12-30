namespace e8e14766c6a82e2f2d10623bb56bd367.Either
{
    public class E
    {
        public string Id { get; set; }
        public string Description { get; set; }

        public E(string id, string description)
        {
            Id = id;
            Description = description;
        }

        public static implicit operator E((string Id, string Description) error)
            => new(error.Id, error.Description);

        public override string ToString() => $"{Id} - {Description}";
    }
}
