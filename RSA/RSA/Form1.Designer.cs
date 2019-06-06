namespace RSA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.KeyManagement = new System.Windows.Forms.TabPage();
            this.UserModulus = new System.Windows.Forms.RichTextBox();
            this.UsersModulus = new System.Windows.Forms.Label();
            this.GeneratedModulus = new System.Windows.Forms.RichTextBox();
            this.GeneratedModulusLabel = new System.Windows.Forms.Label();
            this.NewSession = new System.Windows.Forms.Button();
            this.UserOpenKeyLabel = new System.Windows.Forms.Label();
            this.UserOpenExponent = new System.Windows.Forms.RichTextBox();
            this.GeneratedOpenExponentLabel = new System.Windows.Forms.Label();
            this.GeneratedOpenExponent = new System.Windows.Forms.RichTextBox();
            this.EncryptTab = new System.Windows.Forms.TabPage();
            this.GeneratedKeyEncryptionButton = new System.Windows.Forms.Button();
            this.EncryptedText = new System.Windows.Forms.RichTextBox();
            this.UserKeyEncryptionButton = new System.Windows.Forms.Button();
            this.EncryptedTextLabel = new System.Windows.Forms.Label();
            this.TextForEncryptionLabel = new System.Windows.Forms.Label();
            this.TextForEncryption = new System.Windows.Forms.RichTextBox();
            this.DecryptTab = new System.Windows.Forms.TabPage();
            this.DecryptedTextLabel = new System.Windows.Forms.Label();
            this.TextForDecryptionLabel = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.DecryptedText = new System.Windows.Forms.RichTextBox();
            this.TextForDecryption = new System.Windows.Forms.RichTextBox();
            this.Tabs.SuspendLayout();
            this.KeyManagement.SuspendLayout();
            this.EncryptTab.SuspendLayout();
            this.DecryptTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.KeyManagement);
            this.Tabs.Controls.Add(this.EncryptTab);
            this.Tabs.Controls.Add(this.DecryptTab);
            this.Tabs.Location = new System.Drawing.Point(13, 13);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1137, 425);
            this.Tabs.TabIndex = 0;
            // 
            // KeyManagement
            // 
            this.KeyManagement.Controls.Add(this.UserModulus);
            this.KeyManagement.Controls.Add(this.UsersModulus);
            this.KeyManagement.Controls.Add(this.GeneratedModulus);
            this.KeyManagement.Controls.Add(this.GeneratedModulusLabel);
            this.KeyManagement.Controls.Add(this.NewSession);
            this.KeyManagement.Controls.Add(this.UserOpenKeyLabel);
            this.KeyManagement.Controls.Add(this.UserOpenExponent);
            this.KeyManagement.Controls.Add(this.GeneratedOpenExponentLabel);
            this.KeyManagement.Controls.Add(this.GeneratedOpenExponent);
            this.KeyManagement.Location = new System.Drawing.Point(4, 25);
            this.KeyManagement.Name = "KeyManagement";
            this.KeyManagement.Padding = new System.Windows.Forms.Padding(3);
            this.KeyManagement.Size = new System.Drawing.Size(1129, 396);
            this.KeyManagement.TabIndex = 0;
            this.KeyManagement.Text = "Управление ключами";
            this.KeyManagement.UseVisualStyleBackColor = true;
            // 
            // UserModulus
            // 
            this.UserModulus.Location = new System.Drawing.Point(7, 280);
            this.UserModulus.Name = "UserModulus";
            this.UserModulus.Size = new System.Drawing.Size(1115, 56);
            this.UserModulus.TabIndex = 11;
            this.UserModulus.Text = "";
            this.UserModulus.TextChanged += new System.EventHandler(this.UserModulus_TextChanged);
            this.UserModulus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserModulus_KeyPress);
            // 
            // UsersModulus
            // 
            this.UsersModulus.AutoSize = true;
            this.UsersModulus.Location = new System.Drawing.Point(7, 260);
            this.UsersModulus.Name = "UsersModulus";
            this.UsersModulus.Size = new System.Drawing.Size(470, 17);
            this.UsersModulus.TabIndex = 10;
            this.UsersModulus.Text = "Модуль (пользовательский; Замечание: не может быть равным нулю)";
            // 
            // GeneratedModulus
            // 
            this.GeneratedModulus.Location = new System.Drawing.Point(6, 113);
            this.GeneratedModulus.Name = "GeneratedModulus";
            this.GeneratedModulus.ReadOnly = true;
            this.GeneratedModulus.Size = new System.Drawing.Size(1115, 62);
            this.GeneratedModulus.TabIndex = 9;
            this.GeneratedModulus.Text = "";
            // 
            // GeneratedModulusLabel
            // 
            this.GeneratedModulusLabel.AutoSize = true;
            this.GeneratedModulusLabel.Location = new System.Drawing.Point(6, 92);
            this.GeneratedModulusLabel.Name = "GeneratedModulusLabel";
            this.GeneratedModulusLabel.Size = new System.Drawing.Size(184, 17);
            this.GeneratedModulusLabel.TabIndex = 8;
            this.GeneratedModulusLabel.Text = "Модуль(сгенерированный)";
            // 
            // NewSession
            // 
            this.NewSession.Location = new System.Drawing.Point(6, 339);
            this.NewSession.Name = "NewSession";
            this.NewSession.Size = new System.Drawing.Size(1118, 54);
            this.NewSession.TabIndex = 6;
            this.NewSession.Text = "Начать новую сессию (сгенерировать новые открытый и секретный ключи)";
            this.NewSession.UseVisualStyleBackColor = true;
            this.NewSession.Click += new System.EventHandler(this.NewSession_Click);
            // 
            // UserOpenKeyLabel
            // 
            this.UserOpenKeyLabel.AutoSize = true;
            this.UserOpenKeyLabel.Location = new System.Drawing.Point(6, 178);
            this.UserOpenKeyLabel.Name = "UserOpenKeyLabel";
            this.UserOpenKeyLabel.Size = new System.Drawing.Size(289, 17);
            this.UserOpenKeyLabel.TabIndex = 3;
            this.UserOpenKeyLabel.Text = "Открытая экспонента (пользовательская)";
            // 
            // UserOpenExponent
            // 
            this.UserOpenExponent.Location = new System.Drawing.Point(6, 198);
            this.UserOpenExponent.Name = "UserOpenExponent";
            this.UserOpenExponent.Size = new System.Drawing.Size(1115, 59);
            this.UserOpenExponent.TabIndex = 2;
            this.UserOpenExponent.Text = "";
            this.UserOpenExponent.TextChanged += new System.EventHandler(this.UserOpenExponent_TextChanged);
            this.UserOpenExponent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserOpenExponent_KeyPress);
            // 
            // GeneratedOpenExponentLabel
            // 
            this.GeneratedOpenExponentLabel.AutoSize = true;
            this.GeneratedOpenExponentLabel.Location = new System.Drawing.Point(7, 7);
            this.GeneratedOpenExponentLabel.Name = "GeneratedOpenExponentLabel";
            this.GeneratedOpenExponentLabel.Size = new System.Drawing.Size(283, 17);
            this.GeneratedOpenExponentLabel.TabIndex = 1;
            this.GeneratedOpenExponentLabel.Text = "Открытая экспонента (сгенерированная)";
            // 
            // GeneratedOpenExponent
            // 
            this.GeneratedOpenExponent.Location = new System.Drawing.Point(6, 27);
            this.GeneratedOpenExponent.Name = "GeneratedOpenExponent";
            this.GeneratedOpenExponent.ReadOnly = true;
            this.GeneratedOpenExponent.Size = new System.Drawing.Size(1115, 62);
            this.GeneratedOpenExponent.TabIndex = 0;
            this.GeneratedOpenExponent.Text = "";
            // 
            // EncryptTab
            // 
            this.EncryptTab.Controls.Add(this.GeneratedKeyEncryptionButton);
            this.EncryptTab.Controls.Add(this.EncryptedText);
            this.EncryptTab.Controls.Add(this.UserKeyEncryptionButton);
            this.EncryptTab.Controls.Add(this.EncryptedTextLabel);
            this.EncryptTab.Controls.Add(this.TextForEncryptionLabel);
            this.EncryptTab.Controls.Add(this.TextForEncryption);
            this.EncryptTab.Location = new System.Drawing.Point(4, 25);
            this.EncryptTab.Name = "EncryptTab";
            this.EncryptTab.Padding = new System.Windows.Forms.Padding(3);
            this.EncryptTab.Size = new System.Drawing.Size(1129, 396);
            this.EncryptTab.TabIndex = 1;
            this.EncryptTab.Text = "Зашифровать";
            this.EncryptTab.UseVisualStyleBackColor = true;
            // 
            // GeneratedKeyEncryptionButton
            // 
            this.GeneratedKeyEncryptionButton.Location = new System.Drawing.Point(538, 184);
            this.GeneratedKeyEncryptionButton.Name = "GeneratedKeyEncryptionButton";
            this.GeneratedKeyEncryptionButton.Size = new System.Drawing.Size(585, 34);
            this.GeneratedKeyEncryptionButton.TabIndex = 5;
            this.GeneratedKeyEncryptionButton.Text = "Зашифровать сгенерированным открытым ключом";
            this.GeneratedKeyEncryptionButton.UseVisualStyleBackColor = true;
            this.GeneratedKeyEncryptionButton.Click += new System.EventHandler(this.GeneratedKeyEncryptionButton_Click);
            // 
            // EncryptedText
            // 
            this.EncryptedText.Location = new System.Drawing.Point(4, 241);
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.ReadOnly = true;
            this.EncryptedText.Size = new System.Drawing.Size(1119, 152);
            this.EncryptedText.TabIndex = 4;
            this.EncryptedText.Text = "";
            // 
            // UserKeyEncryptionButton
            // 
            this.UserKeyEncryptionButton.Enabled = false;
            this.UserKeyEncryptionButton.Location = new System.Drawing.Point(12, 184);
            this.UserKeyEncryptionButton.Name = "UserKeyEncryptionButton";
            this.UserKeyEncryptionButton.Size = new System.Drawing.Size(520, 34);
            this.UserKeyEncryptionButton.TabIndex = 3;
            this.UserKeyEncryptionButton.Text = "Зашифровать открытым ключом пользователя";
            this.UserKeyEncryptionButton.UseVisualStyleBackColor = true;
            this.UserKeyEncryptionButton.Click += new System.EventHandler(this.UserKeyEncryptionButton_Click);
            // 
            // EncryptedTextLabel
            // 
            this.EncryptedTextLabel.AutoSize = true;
            this.EncryptedTextLabel.Location = new System.Drawing.Point(6, 221);
            this.EncryptedTextLabel.Name = "EncryptedTextLabel";
            this.EncryptedTextLabel.Size = new System.Drawing.Size(160, 17);
            this.EncryptedTextLabel.TabIndex = 2;
            this.EncryptedTextLabel.Text = "Зашифрованный текст";
            // 
            // TextForEncryptionLabel
            // 
            this.TextForEncryptionLabel.AutoSize = true;
            this.TextForEncryptionLabel.Location = new System.Drawing.Point(6, 3);
            this.TextForEncryptionLabel.Name = "TextForEncryptionLabel";
            this.TextForEncryptionLabel.Size = new System.Drawing.Size(113, 17);
            this.TextForEncryptionLabel.TabIndex = 1;
            this.TextForEncryptionLabel.Text = "Исходный текст";
            // 
            // TextForEncryption
            // 
            this.TextForEncryption.Location = new System.Drawing.Point(6, 23);
            this.TextForEncryption.Name = "TextForEncryption";
            this.TextForEncryption.Size = new System.Drawing.Size(1117, 155);
            this.TextForEncryption.TabIndex = 0;
            this.TextForEncryption.Text = "";
            this.TextForEncryption.TextChanged += new System.EventHandler(this.TextForEncryption_TextChanged);
            // 
            // DecryptTab
            // 
            this.DecryptTab.Controls.Add(this.DecryptedTextLabel);
            this.DecryptTab.Controls.Add(this.TextForDecryptionLabel);
            this.DecryptTab.Controls.Add(this.DecryptButton);
            this.DecryptTab.Controls.Add(this.DecryptedText);
            this.DecryptTab.Controls.Add(this.TextForDecryption);
            this.DecryptTab.Location = new System.Drawing.Point(4, 25);
            this.DecryptTab.Name = "DecryptTab";
            this.DecryptTab.Padding = new System.Windows.Forms.Padding(3);
            this.DecryptTab.Size = new System.Drawing.Size(1129, 396);
            this.DecryptTab.TabIndex = 2;
            this.DecryptTab.Text = "Расшифровать";
            this.DecryptTab.UseVisualStyleBackColor = true;
            // 
            // DecryptedTextLabel
            // 
            this.DecryptedTextLabel.AutoSize = true;
            this.DecryptedTextLabel.Location = new System.Drawing.Point(6, 220);
            this.DecryptedTextLabel.Name = "DecryptedTextLabel";
            this.DecryptedTextLabel.Size = new System.Drawing.Size(167, 17);
            this.DecryptedTextLabel.TabIndex = 4;
            this.DecryptedTextLabel.Text = "Расшифрованный текст";
            // 
            // TextForDecryptionLabel
            // 
            this.TextForDecryptionLabel.AutoSize = true;
            this.TextForDecryptionLabel.Location = new System.Drawing.Point(7, 4);
            this.TextForDecryptionLabel.Name = "TextForDecryptionLabel";
            this.TextForDecryptionLabel.Size = new System.Drawing.Size(160, 17);
            this.TextForDecryptionLabel.TabIndex = 3;
            this.TextForDecryptionLabel.Text = "Зашифрованный текст";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Enabled = false;
            this.DecryptButton.Location = new System.Drawing.Point(9, 180);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(1117, 34);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Расшифровать (только сгенерированный ключ)";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // DecryptedText
            // 
            this.DecryptedText.Location = new System.Drawing.Point(6, 240);
            this.DecryptedText.Name = "DecryptedText";
            this.DecryptedText.ReadOnly = true;
            this.DecryptedText.Size = new System.Drawing.Size(1117, 150);
            this.DecryptedText.TabIndex = 1;
            this.DecryptedText.Text = "";
            // 
            // TextForDecryption
            // 
            this.TextForDecryption.Location = new System.Drawing.Point(6, 25);
            this.TextForDecryption.Name = "TextForDecryption";
            this.TextForDecryption.Size = new System.Drawing.Size(1117, 149);
            this.TextForDecryption.TabIndex = 0;
            this.TextForDecryption.Text = "";
            this.TextForDecryption.TextChanged += new System.EventHandler(this.TextForDecryption_TextChanged);
            this.TextForDecryption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextForDecryption_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 450);
            this.Controls.Add(this.Tabs);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.KeyManagement.ResumeLayout(false);
            this.KeyManagement.PerformLayout();
            this.EncryptTab.ResumeLayout(false);
            this.EncryptTab.PerformLayout();
            this.DecryptTab.ResumeLayout(false);
            this.DecryptTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage KeyManagement;
        private System.Windows.Forms.Label UserOpenKeyLabel;
        private System.Windows.Forms.RichTextBox UserOpenExponent;
        private System.Windows.Forms.Label GeneratedOpenExponentLabel;
        private System.Windows.Forms.RichTextBox GeneratedOpenExponent;
        private System.Windows.Forms.TabPage EncryptTab;
        private System.Windows.Forms.TabPage DecryptTab;
        private System.Windows.Forms.Button NewSession;
        private System.Windows.Forms.RichTextBox EncryptedText;
        private System.Windows.Forms.Button UserKeyEncryptionButton;
        private System.Windows.Forms.Label EncryptedTextLabel;
        private System.Windows.Forms.Label TextForEncryptionLabel;
        private System.Windows.Forms.RichTextBox TextForEncryption;
        private System.Windows.Forms.Label DecryptedTextLabel;
        private System.Windows.Forms.Label TextForDecryptionLabel;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.RichTextBox DecryptedText;
        private System.Windows.Forms.RichTextBox TextForDecryption;
        private System.Windows.Forms.RichTextBox GeneratedModulus;
        private System.Windows.Forms.Label GeneratedModulusLabel;
        private System.Windows.Forms.RichTextBox UserModulus;
        private System.Windows.Forms.Label UsersModulus;
        private System.Windows.Forms.Button GeneratedKeyEncryptionButton;
    }
}

