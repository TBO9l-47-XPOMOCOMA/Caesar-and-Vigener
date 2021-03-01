using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ave_Caesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            coder_button.FlatAppearance.BorderSize = 0;
            coder_button.FlatStyle = FlatStyle.Flat;
            decoder_button.FlatAppearance.BorderSize = 0;
            decoder_button.FlatStyle = FlatStyle.Flat;
            clearOrig_button.FlatAppearance.BorderSize = 0;
            clearOrig_button.FlatStyle = FlatStyle.Flat;
            clearCrypt_button.FlatAppearance.BorderSize = 0;
            clearCrypt_button.FlatStyle = FlatStyle.Flat;
            clearDecrypt_button.FlatAppearance.BorderSize = 0;
            clearDecrypt_button.FlatStyle = FlatStyle.Flat;
            key_textBox.Enabled = false;
            russion_radioButton.Checked = true;
            caesar_radioButton.Checked = true;
        }
        bool flag = false;
        const string rusAlfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890";
        const string engAlfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        int rusAlfabetPower = rusAlfabet.Length;
        int engAlfabetPower = engAlfabet.Length;

        private string caesarEncryption(string alfabet, string origText, int power, int key )
        {
            string cryptogram = "";
            for (int i = 0; i < origText.Length; i++)
            {
                var letter = origText[i];
                var index = alfabet.IndexOf(letter);
                if (index < 0)
                    cryptogram += letter;
                else
                    cryptogram += alfabet[(power + index + key%power) % power];
            }
            return cryptogram;
        }
        
        private string vigenereEncryption(string alfabet, string origText, int power, string key)
        {
            int j = 0;
            string cryptogram = "";
            for (int i = 0; i < origText.Length; i++)
            {
                var letterOfText = origText[i];
                var letterOfKey = key[j];
                var index = alfabet.IndexOf(letterOfText);
                int shift = alfabet.IndexOf(letterOfKey);
                if (index < 0)
                    cryptogram += letterOfText;
                else
                {
                    cryptogram += alfabet[(power + index + (shift+1) % power) % power];
                    j++;
                    if(j==key.Length) { j = 0; }
                }
            }
            return cryptogram;
        }

        private string vigenereDecryption(string alfabet, string origText, int power, string key)
        {
            int j = 0;
            string cryptogram = "";
            for (int i = 0; i < origText.Length; i++)
            {
                var letterOfText = origText[i];
                var letterOfKey = key[j];
                var index = alfabet.IndexOf(letterOfText);
                int shift = alfabet.IndexOf(letterOfKey);
                if (index < 0)
                    cryptogram += letterOfText;
                else
                {
                    cryptogram += alfabet[(power + index + (shift + 1)*-1 % power) % power];
                    j++;
                    if (j == key.Length) { j = 0; }
                }
            }
            return cryptogram;
        }

        private bool notSpecSymbolsInKey()
        {
            string key = key_textBox.Text;
            for (int i = 0; i < key.Length; i++)
            {
                var letter = key[i];
                if (rusAlfabet.IndexOf(letter) < 0 && engAlfabet.IndexOf(letter) < 0)
                    return false;
            }
            return true;
        }
        private bool notNumberInKey()
        {
            string numbers = "0123456789";
            string key = key_textBox.Text;
            for(int i = 0; i<key.Length;i++)
            {
                var letter = key[i];
                if (numbers.IndexOf(letter) >= 0)
                    return false;
            }
            return true;
        }
        private bool rightLanguageInKey()
        {
            string key = key_textBox.Text;
            bool rus = false;
            bool eng = false;
            for (int i = 0; i < key.Length; i++)
            {
                var letter = key[i];
                if (rusAlfabet.IndexOf(letter) >= 0)
                    rus = true;
                if (engAlfabet.IndexOf(letter) >= 0)
                    eng = true;
            }
            if (rus == eng) { return false; }
            if (rus && english_radioButton.Checked) { return false; }
            if(eng && russion_radioButton.Checked) { return false; }
            return true;
        }
        private bool rightLanguageInText()
        {
            string key = original_textBox.Text;
            bool rus = false;
            bool eng = false;
            for (int i = 0; i < key.Length; i++)
            {
                var letter = key[i];
                if (rusAlfabet.IndexOf(letter) >= 0)
                    rus = true;
                if (engAlfabet.IndexOf(letter) >= 0)
                    eng = true;
            }
            if (rus == eng) { return false; }
            if (rus && english_radioButton.Checked) { return false; }
            if (eng && russion_radioButton.Checked) { return false; }
            return true;
        }

        private void coder_button_Click(object sender, EventArgs e)
        {
            string result = "";
            string origText = original_textBox.Text.ToUpper();
            if (caesar_radioButton.Checked)
            {
                if (rightLanguageInText())
                {
                    int key = (int)key_numericUpDown.Value;
                    if (russion_radioButton.Checked)
                    {
                        result = caesarEncryption(rusAlfabet, origText, rusAlfabetPower, key);
                        english_radioButton.Enabled = false;
                    }
                    else
                    {
                        result = caesarEncryption(engAlfabet, origText, engAlfabetPower, key);
                        russion_radioButton.Enabled = false;
                    }
                    cryptogram_textBox.Text = result;
                    vigenere_radioButton.Enabled = false;
                }
                else
                {
                    string text = original_textBox.Text;
                    if (russion_radioButton.Checked)
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            var letter = text[i];
                            if (engAlfabet.IndexOf(letter) >= 0)
                            {
                                cryptogram_textBox.Text = "ОШИБКА! ТЕКСТ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО РУССКИЕ БУКВЫ!";
                            }

                        }
                    }
                    else if (english_radioButton.Checked)
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            var letter = text[i];
                            if (rusAlfabet.IndexOf(letter) >= 0)
                            {
                                cryptogram_textBox.Text = "ОШИБКА! ТЕКСТ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО АНГЛИЙСКИЕ БУКВЫ!";
                            }

                        }
                    }
                }
            }
            else if(vigenere_radioButton.Checked)
            {
                if (notSpecSymbolsInKey())
                {
                    if (notNumberInKey())
                    {
                        if (rightLanguageInKey())
                        {
                            if (rightLanguageInText())
                            {
                                string key = key_textBox.Text;
                                if (russion_radioButton.Checked)
                                {
                                    result = vigenereEncryption(rusAlfabet, origText, rusAlfabetPower, key);
                                    english_radioButton.Enabled = false;
                                }
                                else
                                {
                                    result = vigenereEncryption(engAlfabet, origText, engAlfabetPower, key);
                                    russion_radioButton.Enabled = false;
                                }
                                cryptogram_textBox.Text = result;
                                caesar_radioButton.Enabled = false;
                            }
                            else
                            {
                                string text = original_textBox.Text;
                                if (russion_radioButton.Checked)
                                {
                                    for (int i = 0; i < text.Length; i++)
                                    {
                                        var letter = text[i];
                                        if (engAlfabet.IndexOf(letter) >= 0)
                                        {
                                            cryptogram_textBox.Text = "ОШИБКА! ТЕКСТ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО РУССКИЕ БУКВЫ!";
                                        }

                                    }
                                }
                                else if (english_radioButton.Checked)
                                {
                                    for (int i = 0; i < text.Length; i++)
                                    {
                                        var letter = text[i];
                                        if (rusAlfabet.IndexOf(letter) >= 0)
                                        {
                                            cryptogram_textBox.Text = "ОШИБКА! ТЕКСТ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО АНГЛИЙСКИЕ БУКВЫ!";
                                        }

                                    }
                                }
                            }
                        }
                        else
                        {
                            string key = key_textBox.Text;
                            if (russion_radioButton.Checked)
                            {
                                for (int i = 0; i < key.Length; i++)
                                {
                                    var letter = key[i];
                                    if (engAlfabet.IndexOf(letter) >= 0)
                                    {
                                        cryptogram_textBox.Text = "ОШИБКА! КЛЮЧ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО РУССКИЕ БУКВЫ!";
                                    }

                                }
                            }
                            else if (english_radioButton.Checked)
                            {
                                for (int i = 0; i < key.Length; i++)
                                {
                                    var letter = key[i];
                                    if (rusAlfabet.IndexOf(letter) >= 0)
                                    {
                                        cryptogram_textBox.Text = "ОШИБКА! КЛЮЧ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО АНГЛИЙСКИЕ БУКВЫ!";
                                    }

                                }
                            }

                        };
                    }
                    else
                        cryptogram_textBox.Text = "КЛЮЧ НЕ ДОЛЖЕН СОДЕРЖАТЬ ЦИФР!";
                }
                else
                    cryptogram_textBox.Text = "КЛЮЧ НЕ ДОЛЖЕН СОДЕРЖАТЬ СПЕЦСИМВОЛОВ!";
            }
        }
        private void decoder_button_Click(object sender, EventArgs e)
        {
            string result = "";
            string cryptogram = cryptogram_textBox.Text.ToUpper();
            if (caesar_radioButton.Checked)
            {
                if (rightLanguageInText())
                {
                    int key = (int)key_numericUpDown.Value;
                    if (russion_radioButton.Checked)
                        result = caesarEncryption(rusAlfabet, cryptogram, rusAlfabetPower, key * -1);
                    else
                        result = caesarEncryption(engAlfabet, cryptogram, engAlfabetPower, key * -1);
                    decryption_textBox.Text = result;
                }
                else
                {
                    string text = original_textBox.Text;
                    if (russion_radioButton.Checked)
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            var letter = text[i];
                            if (engAlfabet.IndexOf(letter) >= 0)
                            {
                                decryption_textBox.Text = "ОШИБКА! ТЕКСТ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО РУССКИЕ БУКВЫ!";
                            }

                        }
                    }
                    else if (english_radioButton.Checked)
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            var letter = text[i];
                            if (rusAlfabet.IndexOf(letter) >= 0)
                            {
                                cryptogram_textBox.Text = "ОШИБКА! ТЕКСТ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО АНГЛИЙСКИЕ БУКВЫ!";
                            }

                        }
                    }
                }
                
            }
            else if (vigenere_radioButton.Checked)
            {
                if (notSpecSymbolsInKey())
                {
                    if (notNumberInKey())
                    {
                        if (rightLanguageInKey())
                        {
                            if (rightLanguageInText())
                            {
                                string key = key_textBox.Text;
                                if (russion_radioButton.Checked)
                                {
                                    result = vigenereDecryption(rusAlfabet, cryptogram, rusAlfabetPower, key);
                                }
                                else
                                {
                                    result = vigenereDecryption(engAlfabet, cryptogram, engAlfabetPower, key);
                                }
                                decryption_textBox.Text = result;
                            }
                            else
                            {
                                string text = original_textBox.Text;
                                if (russion_radioButton.Checked)
                                {
                                    for (int i = 0; i < text.Length; i++)
                                    {
                                        var letter = text[i];
                                        if (engAlfabet.IndexOf(letter) >= 0)
                                        {
                                            decryption_textBox.Text = "ОШИБКА! ТЕКСТ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО РУССКИЕ БУКВЫ!";
                                        }

                                    }
                                }
                                else if (english_radioButton.Checked)
                                {
                                    for (int i = 0; i < text.Length; i++)
                                    {
                                        var letter = text[i];
                                        if (rusAlfabet.IndexOf(letter) >= 0)
                                        {
                                            decryption_textBox.Text = "ОШИБКА! ТЕКСТ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО АНГЛИЙСКИЕ БУКВЫ!";
                                        }

                                    }
                                }
                            }
                        }
                        else
                        {
                            string key = key_textBox.Text;
                            if (russion_radioButton.Checked)
                            {
                                for (int i = 0; i < key.Length; i++)
                                {
                                    var letter = key[i];
                                    if (engAlfabet.IndexOf(letter) >= 0)
                                    {
                                        decryption_textBox.Text = "ОШИБКА! КЛЮЧ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО РУССКИЕ БУКВЫ!";
                                    }

                                }
                            }
                            else if (english_radioButton.Checked)
                            {
                                for (int i = 0; i < key.Length; i++)
                                {
                                    var letter = key[i];
                                    if (rusAlfabet.IndexOf(letter) >= 0)
                                    {
                                        decryption_textBox.Text = "ОШИБКА! КЛЮЧ ДОЛЖЕН СОДЕРЖАТЬ ТОЛЬКО АНГЛИЙСКИЕ БУКВЫ!";
                                    }

                                }
                            }

                        };
                    }
                    else
                        decryption_textBox.Text = "КЛЮЧ НЕ ДОЛЖЕН СОДЕРЖАТЬ ЦИФР!";
                }
                else
                    decryption_textBox.Text = "КЛЮЧ НЕ ДОЛЖЕН СОДЕРЖАТЬ СПЕЦСИМВОЛОВ!";
                
            }
        }

        private void original_textBox_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                original_textBox.Text = "";
                flag = true;
            }
        }

        private void original_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!flag)
            {
                original_textBox.Text = "";
                flag = true;
            }
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void key_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!flag)
            {
                original_textBox.Text = "";
                flag = true;
            }
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            original_textBox.Text = "";
            cryptogram_textBox.Text = "";
            decryption_textBox.Text = "";
            key_textBox.Text = "";
            original_textBox.Text = "ВВЕДИТЕ ТЕКСТ / ENTER TEXT";
            flag = false;
            caesar_radioButton.Checked = true;
            vigenere_radioButton.Checked = false;
            russion_radioButton.Checked = true;
            english_radioButton.Checked = false;
            caesar_radioButton.Enabled = true;
            vigenere_radioButton.Enabled = true;
            russion_radioButton.Enabled = true;
            english_radioButton.Enabled = true;
        }

        private void clearOrig_button_Click(object sender, EventArgs e)
        {
            flag = true;
            original_textBox.Text = "";
        }

        private void clearCrypt_button_Click(object sender, EventArgs e)
        {
            cryptogram_textBox.Text = "";
        }

        private void clearDecrypt_button_Click(object sender, EventArgs e)
        {
            decryption_textBox.Text = "";
        }

        private void vigenere_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(vigenere_radioButton.Checked)
            {
                key_textBox.Enabled = true;
                key_numericUpDown.Enabled = false;
            }
            else
            {
                key_textBox.Enabled = false;
                key_numericUpDown.Enabled = true;
                key_textBox.Text = "";
            }
        }
    }
}
