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
        // ----------------========== Заметочка =========-------------------
        /*Выходной байт выбирается путем поиска значений S(i) и S(j), 
         * сложения их вместе по модулю 256, а затем поиска суммы в S, 
         * используется S(S (i) + S (j)) как байт ключевого потока, K.*/
        public string RC4(string input, string key)
        {
            StringBuilder result = new StringBuilder();
            int x, y, j = 0;
            int[] box = new int[256];
            for (int i = 0; i < 256; i++)
                box[i] = i;
            for (int i = 0; i < 256; i++)
            {
                j = (key[i % key.Length] + box[i] + j) % 256;
                x = box[i];
                box[i] = box[j];
                box[j] = x;
            }
            for (int i = 0; i < input.Length; i++)
            {
                y = i % 256;
                j = (box[y] + j) % 256;
                x = box[y];
                box[y] = box[j];
                box[j] = x;
                result.Append((char)(input[i] ^ box[(box[y] + box[j]) % 256]));
            }
            return result.ToString();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            encryptText.Text = RC4(origText.Text, "123");
        }
        private void decryptBtn_Click(object sender, EventArgs e)
        {
            decryptedText.Text = RC4(encryptText.Text, "123");
        }
    }
}