namespace Access.API
{
    public class UserModel
    {
        public Account Account { get; set; }
    }

    public class Account
    {
        public int Id { get; set; }
        public string Lola { get; set; }

    }

}
