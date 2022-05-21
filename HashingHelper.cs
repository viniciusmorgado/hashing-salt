using System.Security.Cryptography;
using System.Text;

public static class HashingHelper
{
    public static string SaltGenerator()
    {
        Random GenerateNumber = new();
        return GenerateNumber.Next().ToString();
    }

    public static string Encrypt(string password, string salt)
    {
        return Hasher($"{password}{salt}");
    }

    public static string Hasher(string saltedPassword)
    {
        return Convert.ToBase64String
        (
            SHA512.Create().ComputeHash(Encoding.Default.GetBytes(saltedPassword))
        );  
    }
}