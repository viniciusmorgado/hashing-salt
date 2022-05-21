string password = "MyPassword@78923";
string salt = HashingHelper.SaltGenerator();

Console.WriteLine("Hash: " + HashingHelper.Encrypt(password, salt));
Console.WriteLine("Salt: " + salt);