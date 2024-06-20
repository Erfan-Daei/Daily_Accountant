
namespace Accountant.Main
{
    internal class TokenCreator
    {
        public string Token;
        public bool TokenIsValid = true;

        public string CreateToken()
        {
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            Token = Convert.ToBase64String(time.Concat(key).ToArray());
            return Token;
        }
        public bool ExpirationEmailToken(string Token)
        {
            byte[] data = Convert.FromBase64String(Token);
            DateTime creationTime = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
            if (creationTime < DateTime.UtcNow.AddMinutes(-1))
            {
                TokenIsValid = false;
            }
            return TokenIsValid;
        }
    }
}
