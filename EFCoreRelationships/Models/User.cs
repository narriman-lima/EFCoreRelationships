namespace EFCoreRelationships.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public List<Character> Characters { get; set; }

    }
}
