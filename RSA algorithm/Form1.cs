using System.Security.Cryptography;
using System.Text;

namespace RSA_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private const bool IncludePrivateParameters = false;
        UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
        RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
        byte[] data;
        byte[] encryptData;

        

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            data = unicodeEncoding.GetBytes(origText.Text);
            encryptData = Encrypt(data, rSACryptoServiceProvider.ExportParameters(IncludePrivateParameters), IncludePrivateParameters);
            encryptText.Text = unicodeEncoding.GetString(encryptData);
            rSACryptoServiceProvider.ExportParameters(false);
        }
        private void decryptBtn_Click(object sender, EventArgs e)
        {
            byte[] data = Decrypt(encryptData, rSACryptoServiceProvider.ExportParameters(true), IncludePrivateParameters);
            decryptedText.Text = unicodeEncoding.GetString(data);
            rSACryptoServiceProvider.ExportParameters(false);
        }
        byte[] Encrypt(byte[] data, RSAParameters RSAKey, bool fOAEP)
        {
            byte[] encryptedData;
            using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rSACryptoServiceProvider.ImportParameters(RSAKey);
                encryptedData = rSACryptoServiceProvider.Encrypt(data, fOAEP);
            }
            return encryptedData;
        }
        byte[] Decrypt(byte[] data, RSAParameters RSAKey, bool fOAEP)
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
            {
                rSACryptoServiceProvider.ImportParameters(RSAKey);
                decryptedData = rSACryptoServiceProvider.Decrypt(data, fOAEP);
            }
            return decryptedData;
        }        


    }
}