using System;

namespace openid
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Microsoft.IdentityModel.Tokens.Saml2SecurityTokenHandler();
            Console.WriteLine("Eureka");
            Console.ReadKey();
        }
    }
}
