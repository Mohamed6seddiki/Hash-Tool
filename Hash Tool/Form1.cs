using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;

namespace Hash_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ComputeHash(string input, Func<HashAlgorithm> algorithmFactory)
        {
            using (HashAlgorithm algorithm = algorithmFactory())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = algorithm.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private string ComputeBouncyHash(string input, IDigest digest)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            digest.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] result = new byte[digest.GetDigestSize()];
            digest.DoFinal(result, 0);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in result)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            // MD2
            if (MD2.Checked)
                textBox2.Text = ComputeBouncyHash(text, new MD2Digest());

            // MD5 - Using fully qualified name
            if (MD5.Checked)
                textBox8.Text = ComputeHash(text, () => System.Security.Cryptography.MD5.Create());

            // RIPEMD160 - Using fully qualified name
            if (RIPEMD160.Checked)
                textBox9.Text = ComputeHash(text, () => System.Security.Cryptography.RIPEMD160.Create());

            // SHA1 - Using fully qualified name
            if (SHA1.Checked)
                textBox10.Text = ComputeHash(text, () => System.Security.Cryptography.SHA1.Create());

            // SHA-224 (BouncyCastle)
            if (SHA2224.Checked)
                textBox14.Text = ComputeBouncyHash(text, new Sha224Digest());

            // SHA-256
            if (SHA2256.Checked)
                textBox7.Text = ComputeHash(text, () => SHA256.Create());

            // SHA-384
            if (SHA2384.Checked)
                textBox6.Text = ComputeHash(text, () => SHA384.Create());

            // SHA-512
            if (SHA2512.Checked)
                textBox5.Text = ComputeHash(text, () => SHA512.Create());

            // SHA3-224
            if (SHA3224.Checked)
                textBox4.Text = ComputeBouncyHash(text, new Sha3Digest(224));

            // SHA3-256
            if (SHA3256.Checked)
                textBox3.Text = ComputeBouncyHash(text, new Sha3Digest(256));

            // SHA3-384
            if (SHA3384.Checked)
                textBox13.Text = ComputeBouncyHash(text, new Sha3Digest(384));

            // SHA3-512
            if (SHA3512.Checked)
                textBox12.Text = ComputeBouncyHash(text, new Sha3Digest(512));

            // Whirlpool
            if (WHIRLPOOL.Checked)
                textBox11.Text = ComputeBouncyHash(text, new WhirlpoolDigest());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text= textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = "";
        }
    }
}