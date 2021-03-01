namespace Ave_Caesar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.original_textBox = new System.Windows.Forms.TextBox();
            this.cryptogram_textBox = new System.Windows.Forms.TextBox();
            this.decryption_textBox = new System.Windows.Forms.TextBox();
            this.coder_button = new System.Windows.Forms.Button();
            this.decoder_button = new System.Windows.Forms.Button();
            this.russion_radioButton = new System.Windows.Forms.RadioButton();
            this.english_radioButton = new System.Windows.Forms.RadioButton();
            this.languages_label = new System.Windows.Forms.Label();
            this.key_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.key_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.clearOrig_button = new System.Windows.Forms.Button();
            this.clearCrypt_button = new System.Windows.Forms.Button();
            this.clearDecrypt_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.caesar_radioButton = new System.Windows.Forms.RadioButton();
            this.vigenere_radioButton = new System.Windows.Forms.RadioButton();
            this.ciphers_label = new System.Windows.Forms.Label();
            this.Ciphers_groupBox = new System.Windows.Forms.GroupBox();
            this.Languages_groupBox = new System.Windows.Forms.GroupBox();
            this.key_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.key_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Ciphers_groupBox.SuspendLayout();
            this.Languages_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // original_textBox
            // 
            this.original_textBox.Location = new System.Drawing.Point(205, 203);
            this.original_textBox.Name = "original_textBox";
            this.original_textBox.Size = new System.Drawing.Size(393, 20);
            this.original_textBox.TabIndex = 0;
            this.original_textBox.Text = "ВВЕДИТЕ ТЕКСТ / ENTER TEXT";
            this.original_textBox.Click += new System.EventHandler(this.original_textBox_Click);
            this.original_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.original_textBox_KeyPress);
            // 
            // cryptogram_textBox
            // 
            this.cryptogram_textBox.Location = new System.Drawing.Point(205, 294);
            this.cryptogram_textBox.Name = "cryptogram_textBox";
            this.cryptogram_textBox.ReadOnly = true;
            this.cryptogram_textBox.Size = new System.Drawing.Size(393, 20);
            this.cryptogram_textBox.TabIndex = 1;
            // 
            // decryption_textBox
            // 
            this.decryption_textBox.Enabled = false;
            this.decryption_textBox.Location = new System.Drawing.Point(205, 389);
            this.decryption_textBox.Name = "decryption_textBox";
            this.decryption_textBox.ReadOnly = true;
            this.decryption_textBox.Size = new System.Drawing.Size(393, 20);
            this.decryption_textBox.TabIndex = 2;
            // 
            // coder_button
            // 
            this.coder_button.BackColor = System.Drawing.Color.DarkOrange;
            this.coder_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coder_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coder_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coder_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.coder_button.Location = new System.Drawing.Point(301, 238);
            this.coder_button.Margin = new System.Windows.Forms.Padding(0);
            this.coder_button.Name = "coder_button";
            this.coder_button.Size = new System.Drawing.Size(202, 41);
            this.coder_button.TabIndex = 3;
            this.coder_button.Text = "Зашифровать";
            this.coder_button.UseVisualStyleBackColor = false;
            this.coder_button.Click += new System.EventHandler(this.coder_button_Click);
            // 
            // decoder_button
            // 
            this.decoder_button.BackColor = System.Drawing.Color.DarkOrange;
            this.decoder_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decoder_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decoder_button.Location = new System.Drawing.Point(301, 332);
            this.decoder_button.Name = "decoder_button";
            this.decoder_button.Size = new System.Drawing.Size(202, 40);
            this.decoder_button.TabIndex = 4;
            this.decoder_button.Text = "Расшифровать";
            this.decoder_button.UseVisualStyleBackColor = false;
            this.decoder_button.Click += new System.EventHandler(this.decoder_button_Click);
            // 
            // russion_radioButton
            // 
            this.russion_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.russion_radioButton.AutoSize = true;
            this.russion_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.russion_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.russion_radioButton.Location = new System.Drawing.Point(4, 9);
            this.russion_radioButton.Name = "russion_radioButton";
            this.russion_radioButton.Size = new System.Drawing.Size(67, 17);
            this.russion_radioButton.TabIndex = 5;
            this.russion_radioButton.TabStop = true;
            this.russion_radioButton.Text = "Русский";
            this.russion_radioButton.UseVisualStyleBackColor = false;
            // 
            // english_radioButton
            // 
            this.english_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.english_radioButton.AutoSize = true;
            this.english_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.english_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.english_radioButton.Location = new System.Drawing.Point(4, 26);
            this.english_radioButton.Name = "english_radioButton";
            this.english_radioButton.Size = new System.Drawing.Size(59, 17);
            this.english_radioButton.TabIndex = 6;
            this.english_radioButton.TabStop = true;
            this.english_radioButton.Text = "English";
            this.english_radioButton.UseVisualStyleBackColor = false;
            // 
            // languages_label
            // 
            this.languages_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.languages_label.AutoSize = true;
            this.languages_label.BackColor = System.Drawing.Color.Transparent;
            this.languages_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.languages_label.Location = new System.Drawing.Point(13, 375);
            this.languages_label.Name = "languages_label";
            this.languages_label.Size = new System.Drawing.Size(38, 13);
            this.languages_label.TabIndex = 7;
            this.languages_label.Text = "Язык:";
            // 
            // key_numericUpDown
            // 
            this.key_numericUpDown.Location = new System.Drawing.Point(89, 395);
            this.key_numericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.key_numericUpDown.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.key_numericUpDown.Name = "key_numericUpDown";
            this.key_numericUpDown.Size = new System.Drawing.Size(45, 20);
            this.key_numericUpDown.TabIndex = 8;
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.BackColor = System.Drawing.Color.Transparent;
            this.key_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.key_label.Location = new System.Drawing.Point(86, 375);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(36, 13);
            this.key_label.TabIndex = 9;
            this.key_label.Text = "Ключ:";
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DarkOrange;
            this.clear_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clear_button.Location = new System.Drawing.Point(633, 408);
            this.clear_button.Margin = new System.Windows.Forms.Padding(0);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(158, 41);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "Очистить всё";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // clearOrig_button
            // 
            this.clearOrig_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearOrig_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearOrig_button.Location = new System.Drawing.Point(604, 203);
            this.clearOrig_button.Name = "clearOrig_button";
            this.clearOrig_button.Size = new System.Drawing.Size(20, 20);
            this.clearOrig_button.TabIndex = 11;
            this.clearOrig_button.Text = "Х";
            this.clearOrig_button.UseVisualStyleBackColor = false;
            this.clearOrig_button.Click += new System.EventHandler(this.clearOrig_button_Click);
            // 
            // clearCrypt_button
            // 
            this.clearCrypt_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearCrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearCrypt_button.Location = new System.Drawing.Point(604, 293);
            this.clearCrypt_button.Name = "clearCrypt_button";
            this.clearCrypt_button.Size = new System.Drawing.Size(20, 20);
            this.clearCrypt_button.TabIndex = 12;
            this.clearCrypt_button.Text = "Х";
            this.clearCrypt_button.UseVisualStyleBackColor = false;
            this.clearCrypt_button.Click += new System.EventHandler(this.clearCrypt_button_Click);
            // 
            // clearDecrypt_button
            // 
            this.clearDecrypt_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearDecrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearDecrypt_button.Location = new System.Drawing.Point(604, 389);
            this.clearDecrypt_button.Name = "clearDecrypt_button";
            this.clearDecrypt_button.Size = new System.Drawing.Size(20, 20);
            this.clearDecrypt_button.TabIndex = 13;
            this.clearDecrypt_button.Text = "Х";
            this.clearDecrypt_button.UseVisualStyleBackColor = false;
            this.clearDecrypt_button.Click += new System.EventHandler(this.clearDecrypt_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(205, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 185);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // caesar_radioButton
            // 
            this.caesar_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.caesar_radioButton.AutoSize = true;
            this.caesar_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.caesar_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.caesar_radioButton.Location = new System.Drawing.Point(6, 13);
            this.caesar_radioButton.Name = "caesar_radioButton";
            this.caesar_radioButton.Size = new System.Drawing.Size(58, 17);
            this.caesar_radioButton.TabIndex = 15;
            this.caesar_radioButton.TabStop = true;
            this.caesar_radioButton.Text = "Caesar";
            this.caesar_radioButton.UseVisualStyleBackColor = false;
            // 
            // vigenere_radioButton
            // 
            this.vigenere_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vigenere_radioButton.AutoSize = true;
            this.vigenere_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.vigenere_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vigenere_radioButton.Location = new System.Drawing.Point(6, 32);
            this.vigenere_radioButton.Name = "vigenere_radioButton";
            this.vigenere_radioButton.Size = new System.Drawing.Size(67, 17);
            this.vigenere_radioButton.TabIndex = 16;
            this.vigenere_radioButton.TabStop = true;
            this.vigenere_radioButton.Text = "Vigenere";
            this.vigenere_radioButton.UseVisualStyleBackColor = false;
            this.vigenere_radioButton.CheckedChanged += new System.EventHandler(this.vigenere_radioButton_CheckedChanged);
            // 
            // ciphers_label
            // 
            this.ciphers_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ciphers_label.AutoSize = true;
            this.ciphers_label.BackColor = System.Drawing.Color.Transparent;
            this.ciphers_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ciphers_label.Location = new System.Drawing.Point(13, 300);
            this.ciphers_label.Name = "ciphers_label";
            this.ciphers_label.Size = new System.Drawing.Size(40, 13);
            this.ciphers_label.TabIndex = 17;
            this.ciphers_label.Text = "Cipher:";
            // 
            // Ciphers_groupBox
            // 
            this.Ciphers_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.Ciphers_groupBox.Controls.Add(this.caesar_radioButton);
            this.Ciphers_groupBox.Controls.Add(this.vigenere_radioButton);
            this.Ciphers_groupBox.Location = new System.Drawing.Point(12, 313);
            this.Ciphers_groupBox.Name = "Ciphers_groupBox";
            this.Ciphers_groupBox.Size = new System.Drawing.Size(73, 59);
            this.Ciphers_groupBox.TabIndex = 18;
            this.Ciphers_groupBox.TabStop = false;
            // 
            // Languages_groupBox
            // 
            this.Languages_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.Languages_groupBox.Controls.Add(this.russion_radioButton);
            this.Languages_groupBox.Controls.Add(this.english_radioButton);
            this.Languages_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Languages_groupBox.Location = new System.Drawing.Point(12, 389);
            this.Languages_groupBox.Name = "Languages_groupBox";
            this.Languages_groupBox.Size = new System.Drawing.Size(71, 49);
            this.Languages_groupBox.TabIndex = 19;
            this.Languages_groupBox.TabStop = false;
            // 
            // key_textBox
            // 
            this.key_textBox.Location = new System.Drawing.Point(89, 418);
            this.key_textBox.Name = "key_textBox";
            this.key_textBox.Size = new System.Drawing.Size(112, 20);
            this.key_textBox.TabIndex = 20;
            this.key_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_textBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.key_textBox);
            this.Controls.Add(this.Languages_groupBox);
            this.Controls.Add(this.Ciphers_groupBox);
            this.Controls.Add(this.ciphers_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clearDecrypt_button);
            this.Controls.Add(this.clearCrypt_button);
            this.Controls.Add(this.clearOrig_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.key_numericUpDown);
            this.Controls.Add(this.languages_label);
            this.Controls.Add(this.decoder_button);
            this.Controls.Add(this.coder_button);
            this.Controls.Add(this.decryption_textBox);
            this.Controls.Add(this.cryptogram_textBox);
            this.Controls.Add(this.original_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.key_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Ciphers_groupBox.ResumeLayout(false);
            this.Ciphers_groupBox.PerformLayout();
            this.Languages_groupBox.ResumeLayout(false);
            this.Languages_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox original_textBox;
        private System.Windows.Forms.TextBox cryptogram_textBox;
        private System.Windows.Forms.TextBox decryption_textBox;
        private System.Windows.Forms.Button coder_button;
        private System.Windows.Forms.Button decoder_button;
        private System.Windows.Forms.RadioButton russion_radioButton;
        private System.Windows.Forms.RadioButton english_radioButton;
        private System.Windows.Forms.Label languages_label;
        private System.Windows.Forms.NumericUpDown key_numericUpDown;
        private System.Windows.Forms.Label key_label;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button clearOrig_button;
        private System.Windows.Forms.Button clearCrypt_button;
        private System.Windows.Forms.Button clearDecrypt_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton caesar_radioButton;
        private System.Windows.Forms.RadioButton vigenere_radioButton;
        private System.Windows.Forms.Label ciphers_label;
        private System.Windows.Forms.GroupBox Ciphers_groupBox;
        private System.Windows.Forms.GroupBox Languages_groupBox;
        private System.Windows.Forms.TextBox key_textBox;
    }
}

