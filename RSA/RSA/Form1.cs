using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;

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

        private void UserOpenExponent_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void StartNewSession()
        {
            this.keyGen = new KeyGenerator();
            GeneratedOpenExponent.Text = $"{keyGen.E}";
            GeneratedModulus.Text = $"{keyGen.N}";
        }

        private void UserModulus_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!char.IsDigit(e.KeyChar) || (this.UserModulus.TextLength == 0 && e.KeyChar == '0'))
                e.Handled = true;
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
            if (this.UserOpenExponent.TextLength > 0 && this.UserModulus.TextLength > 0)
            {
                this.UserKeyEncryptionButton.Enabled = true;
            }
            else
            {
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
                BigInteger userExponent = BigInteger.Parse(this.UserOpenExponent.Text);
                BigInteger userModulus = BigInteger.Parse(this.UserModulus.Text);
                this.EncryptedText.Text = $"{EncryptorDecryptor.Encrypt(this.TextForEncryption.Text, userExponent, userModulus)}";
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message + ". Вполне вероятно, что введены недопустимые значения в полях вкладки Управление ключами. Исправьте ошибки и повторите попытку.");
            }
        }

        private void GeneratedKeyEncryptionButton_Click(object sender, EventArgs e)
        {
            this.EncryptedText.Text = $"{EncryptorDecryptor.Encrypt(this.TextForEncryption.Text, keyGen.E, keyGen.N)}";
        }

        private void TextForDecryption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger forDecryption = BigInteger.Parse(this.TextForDecryption.Text);
                this.DecryptedText.Text = $"{EncryptorDecryptor.Decrypt(forDecryption, keyGen.D, keyGen.N)}";
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message + ". Вероятнее всего, был введен недопустимый символ/последовательность символов. Проверьте введённый текст и повторите попытку.");
            }
        }

        private void TextForDecryption_TextChanged(object sender, EventArgs e)
        {
            if (this.TextForDecryption.TextLength > 0)
                this.DecryptButton.Enabled = true;
            else
                this.DecryptButton.Enabled = false;
        }
    }
}
