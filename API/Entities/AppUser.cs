namespace API.Entities
{
    public class AppUser
    {
        //`Id` or `ID` is considered a primary key
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] passwrodHash { get; set; }
        public byte[] passwordSalt { get; set; }
    }
}