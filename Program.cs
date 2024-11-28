using System.Security.Cryptography;
using System.Text;

namespace hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aaa= Console.ReadLine();
            //static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
            /*
             
                byte[] plainText = Encoding.ASCII.GetBytes(aaa);
            byte[] salt = Encoding.ASCII.GetBytes("ui4urids9i3idlkw");
            HashAlgorithm algorithm = new SHA256Managed();

                byte[] plainTextWithSaltBytes =
                  new byte[plainText.Length + salt.Length];

                for (int i = 0; i < plainText.Length; i++)
                {
                    plainTextWithSaltBytes[i] = plainText[i];
                }
                for (int i = 0; i < salt.Length; i++)
                {
                    plainTextWithSaltBytes[plainText.Length + i] = salt[i];
                }

               Console.WriteLine(Encoding.UTF8.GetString(algorithm.ComputeHash(plainTextWithSaltBytes)));
             
             
             */
            string pw = "SninHJneumJ" + aaa + "TemsjnHj3nwk";
             var sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(pw));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x4"));
            }
            Console.WriteLine(sb.ToString());

            //0270560580a60950cf0340f101e0fb03f0f50db0bf0230ee0cb0410b30570b20e603103f01204b0290830540f20c7035
            //0250900030d904d0810dc0590330270950a20cd09e09304d03a0e000e07904305303f0d60ed0da0d70f500a009090061
            //00250090000300d9004d008100dc005900330027009500a200cd009e0093004d003a00e0000e007900430053003f00d600ed00da00d700f5000a000900900061
        }

    }
}
