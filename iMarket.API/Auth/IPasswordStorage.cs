namespace iMarket.API.Auth
{
    public interface IPasswordStorage
    {
        string CreateHash(string password);
        bool VerifyPassword(string password, string goodHash);
    }
}
