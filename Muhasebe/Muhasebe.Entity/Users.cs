namespace Muhasebe.Entity
{
    public class Users : TableObjects
    {
        public override string PrimaryKey => "UsersID";
        public int UserID { get;}
        public string  Name { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
    }
}
