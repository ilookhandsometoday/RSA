using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Math;

namespace RSA
{
    public partial class Form1 : Form
    {
        private KeyGenerator keyGen = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartNewSession();
        }

        private void StartNewSession()
        {
            this.keyGen = new KeyGenerator();
            GeneratedOpenExponent.Text = $"{keyGen.E}";
            GeneratedModulus.Text = $"{keyGen.N}";
        }

        private void GeneratedKeyEncrypt()
        {
            this.EncryptedText.Clear();
            List<BigInteger> encrypted = EncryptorDecryptor.Encrypt(this.TextForEncryption.Text, keyGen.E, keyGen.N);
            int encryptedLength = encrypted.Count;
            for (int i = 0; i < encryptedLength; i++)
            {
                this.EncryptedText.Text += $"{encrypted[i]} ";
            }
        }

        private void UserKeyEncrypt()
        {
            this.EncryptedText.Clear();
            BigInteger userExponent = new BigInteger(this.UserOpenExponent.Text);
            BigInteger userModulus = new BigInteger(this.UserModulus.Text);
            List<BigInteger> encrypted = EncryptorDecryptor.Encrypt(this.TextForEncryption.Text, userExponent, userModulus);
            int encryptedLength = encrypted.Count;
            for (int i = 0; i < encryptedLength; i++)
            {
                this.EncryptedText.Text += $"{encrypted[i]} ";
            }
        }

        private void GeneratedKeyDecrypt()
        {
            char[] separators = new char[] { ' ' };
            string[] encryptedChunks = this.TextForDecryption.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Resize(ref encryptedChunks, encryptedChunks.Length - 1);
            int encryptedChunksLength = encryptedChunks.Length;
            List<BigInteger> forDecryption = new List<BigInteger>();
            for (int i = 0; i < encryptedChunksLength; i++)
            {
                forDecryption.Add(new BigInteger(encryptedChunks[i]));
            }

            this.DecryptedText.Text = EncryptorDecryptor.Decrypt(forDecryption, keyGen.D, keyGen.N);
        }

        private void UserOpenExponent_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void UserModulus_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!char.IsDigit(e.KeyChar) || (this.UserModulus.TextLength == 0 && e.KeyChar == '0'))
                e.Handled = true;
        }

        private void TextForDecryption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '-' && this.TextForDecryption.SelectionStart == 0 && !this.TextForDecryption.Text.Contains('-'))
                    return;
                else if (e.KeyChar == ' ')
                    return;
                e.Handled = true;
            }
        }

        private void TextForDecryption_TextChanged(object sender, EventArgs e)
        {
            if (this.TextForDecryption.TextLength > 0)
                this.DecryptButton.Enabled = true;
            else
                this.DecryptButton.Enabled = false;
        }

        private void UserOpenExponent_TextChanged(object sender, EventArgs e) 
        {
            if (this.UserOpenExponent.TextLength > 0 && this.UserModulus.TextLength > 0 && this.TextForEncryption.TextLength > 0)
                this.UserKeyEncryptionButton.Enabled = true;
            else
                this.UserKeyEncryptionButton.Enabled = false;
        }

        private void UserModulus_TextChanged(object sender, EventArgs e) 
        {
            if (this.UserOpenExponent.TextLength > 0 && this.UserModulus.TextLength > 0 && this.TextForEncryption.TextLength > 0 && this.UserModulus.Text != "0")
                this.UserKeyEncryptionButton.Enabled = true;
            else if (this.UserModulus.Text == "0")
                this.UserModulus.Clear();
            else
                this.UserKeyEncryptionButton.Enabled = false;
        }

        private void TextForEncryption_TextChanged(object sender, EventArgs e)
        {
            if(this.TextForEncryption.TextLength > 0)
            {
                this.GeneratedKeyEncryptionButton.Enabled = true;
                if (this.UserOpenExponent.TextLength > 0 && this.UserModulus.TextLength > 0)
                    this.UserKeyEncryptionButton.Enabled = true;
            }
            else
            {
                this.GeneratedKeyEncryptionButton.Enabled = false;
                this.UserKeyEncryptionButton.Enabled = false;
            }
        }

        private void NewSession_Click(object sender, EventArgs e)
        {
            this.StartNewSession();
        }

        private void UserKeyEncryptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserKeyEncrypt();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message + ". Вполне вероятно, что введены недопустимые значения в полях вкладки Управление ключами (например, любой символ кроме цифр). Исправьте ошибки и повторите попытку.");
            }
        }

        private void GeneratedKeyEncryptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                GeneratedKeyEncrypt();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                GeneratedKeyDecrypt();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + ". Вероятнее всего, был введен недопустимый символ/последовательность символов. Проверьте введённый текст и повторите попытку.");
            }
        }
    }
}
