namespace Muhasebe.Entity
{
    public class User : TableObjects
    {
        public override string PrimaryKey => "UserID";
        public int UserID { get; set; }
        public string  Name { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        public bool Remember { get; set; }
    }
}
