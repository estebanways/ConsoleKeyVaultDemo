using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System.Linq.Expressions;

namespace ConsoleKeyVaultDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KeyVaultUri = "https://keyvaultsamplemmf.vault.azure.net/";

            var credentials = new EnvironmentCredential();

            SecretClient client = new SecretClient(new Uri(KeyVaultUri), credentials);

            KeyVaultSecret secretValue = client.GetSecret("secreto");

            Console.WriteLine(secretValue.Value);

            Console.ReadLine();




        }
    }
}
